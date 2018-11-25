using System;
using System.Reflection;
using LiveSplit.Model;
using LiveSplit.UI.Components;
using WitcherSplit;

[assembly: ComponentFactory(typeof(Factory))]
namespace WitcherSplit {
   

    
        public class Factory : IComponentFactory
        {
            public ComponentCategory Category => ComponentCategory.Control;
            public string ComponentName => "WitcherSplit";
            public string Description => "In-Game Time and Auto-Split component that works with Witcher3.";

            public string UpdateName => ComponentName;
            public string UpdateURL => "http://play.asdasdasd.org/WitcherSplit/";
            public Version Version => Assembly.GetExecutingAssembly().GetName().Version;
            public string XMLURL => UpdateURL + "updates.xml";
            public IComponent Create(LiveSplitState state) => new WitcherSplitComponent(state);
        }
    
}