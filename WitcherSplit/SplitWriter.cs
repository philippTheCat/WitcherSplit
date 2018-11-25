using System;
using System.Diagnostics;

namespace WitcherSplit {
    public class SplitWriter {
        private string lastQuest;
        private string lastGoal;
        
        
        public void write(string quest) {
            string[] strings = quest.Split(new[] {" : "}, StringSplitOptions.None);
            output(strings[0],strings[1], lastQuest == strings[0]);

            /*if (lastQuest != strings[0] || lastGoal != strings[1]) {
                lastQuest = strings[0];
                lastGoal = strings[1];
            }*/
        }

        private void output(string questname, string goalname, bool subsplit) {
            //string quest = subsplit ? " - " : string.Format("{{{0}}}", questname);
            Trace.WriteLine(string.Format("<Segment>\n" +
                                          "    <Name>{0} : {1}</Name>\n" +
                                          "    <SplitTimes>\n" +
                                          "    <SplitTime name=\"Personal Best\" />\n" +
                                          "    <BestSegmentTime />\n" +
                                          "    <SegmentHistory />\n" +
                                          "</Segment>)\n", questname, goalname));
        }
    }
}