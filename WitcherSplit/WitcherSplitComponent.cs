using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Windows.Forms;
using System.Xml;
using LiveSplit.Model;
using LiveSplit.UI;
using LiveSplit.UI.Components;
using WitcherSplit.LiveSplit.BunnySplit;

namespace WitcherSplit {
    public class WitcherSplitComponent: LogicComponent {
        private ComponentSettings settings;

        private HashSet<string> visited = new HashSet<string>();
        
        private bool doSplit = false;
        private TimerModel model;
        private SplitWriter splitWriter;
        private LiveSplitState state;

        public WitcherSplitComponent(LiveSplitState state) {
            this.state = state;
            
           
            Trace.WriteLine("[WS] INIT");
            settings = new ComponentSettings();
            settings.logfilePath = @"C:\Users\chatz\Documents\The Witcher 3\scriptslog.txt";
            

            LogFileMonitor logFileMonitor = new LogFileMonitor(settings.logfilePath,"\r\n");
            logFileMonitor.OnLine += onLine;
            
            logFileMonitor.Start();
            model = new TimerModel { CurrentState = state };
            model.InitializeGameTime();

            state.OnStart += onStart;
            splitWriter = new SplitWriter();
            
            onStart(null,null);
        }

        private void onStart(object sender, EventArgs phase) {
           

            visited.Clear();
        }

        private void onLine(object sender, LogFileMonitorLineEventArgs e) {
            string line = e.Line;

            string tag = "[Script] [addFact] ";
            if (line.Contains(tag)) {
                string[] factLine = line.Substring(tag.Length).Split(new [] {" : "}, StringSplitOptions.None);
                string fact = factLine[0];
                string value = factLine[1];
                
                
                /*if (!visited.Contains(quest)) {
                    splitWriter.write(quest);
                }*/
                
                Debug.WriteLine("changed fact: "+ fact + " to value " + value);
                
                

                if (visited.Add(fact) && (state.Run.Any(seg => seg.Name == fact) || model.CurrentState.CurrentPhase == TimerPhase.NotRunning) ) {
                    if (model.CurrentState.CurrentPhase == TimerPhase.NotRunning) {
                        model.Start();
                    } 
                    else {
                        model.Split();

                        // if its the last one stop the run
                        // the last one is an empty split containing the quest name of the next quest afterwards
                        if (fact == state.Run[state.Run.Count-1].Name) {
                            model.Split();
                        }
                    }

                    Debug.WriteLine("did split");
                }
            }
        }

        public override XmlNode GetSettings(XmlDocument document)
        {
            return settings.GetSettings(document);
        }

        public override Control GetSettingsControl(LayoutMode mode)
        {
            return settings;
        }

        public override void SetSettings(XmlNode settings)
        {
            this.settings.SetSettings(settings);
        }

        public override void Update(IInvalidator invalidator, LiveSplitState state, float width, float height, LayoutMode mode) {
         
        }

        public override string ComponentName { get => "WitcherSplit"; }

        public override void Dispose() {
            
        }
    }
}