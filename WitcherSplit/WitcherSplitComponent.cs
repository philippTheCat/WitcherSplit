using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO.Pipes;
using System.Linq;
using System.Threading;
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
            
            ThreadStart childref = new ThreadStart(Listen);
            Debug.WriteLine("In Main: Creating the Child thread");
         
            Thread childThread = new Thread(childref);
            childThread.Start();
            
            model = new TimerModel { CurrentState = state };
            model.InitializeGameTime();

            state.OnStart += onStart;
            splitWriter = new SplitWriter();
            
            onStart(null,null);
        }

        private void Listen() {
            var server = new NamedPipeServerStream("WitcherSplit", PipeDirection.InOut, -1);
            server.WaitForConnection();

           while(true)
            {
                var len = new byte[1];
                server.Read(len, 0, 1); 
                
                byte[] buffer = new byte[len[0]];

                server.Read(buffer, 0, len[0]);

                byte[] factNameBuf = buffer.Take(len[0] - 4).ToArray();
                byte[] factValueBuf = buffer.Skip(len[0] - 4).ToArray();

                string factName = System.Text.Encoding.Default.GetString(factNameBuf);
                int factValue = BitConverter.ToInt32(factValueBuf, 0);
                Debug.WriteLine("factName:" + factName + "\n\n");
                Debug.WriteLine("factValue: " + factValue);
                
                onFactChange(factName, factValue);
            }
        }

        private void onStart(object sender, EventArgs phase) {
           

            visited.Clear();
        }

        private void onFactChange(String fact, int value) {
       
                
                
                /*if (!visited.Contains(quest)) {
                    splitWriter.write(quest);
                }*/
                
                Debug.WriteLine("changed fact: "+ fact + " to value " + value);



            if (visited.Add(fact) && (state.Run.Any(seg => seg.Name == fact) ||
                                      model.CurrentState.CurrentPhase == TimerPhase.NotRunning)) {
                if (model.CurrentState.CurrentPhase == TimerPhase.NotRunning) {
                    model.Start();
                }
                else {
                    model.Split();

                    // if its the last one stop the run
                    // the last one is an empty split containing the quest name of the next quest afterwards
                    if (fact == state.Run[state.Run.Count - 1].Name) {
                        model.Split();
                    }
                }

                Debug.WriteLine("did split");
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