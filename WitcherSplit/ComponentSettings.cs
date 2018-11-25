using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Xml;
using System.Reflection;


namespace WitcherSplit {

namespace LiveSplit.BunnySplit
{
    public class ComponentSettings : UserControl
    {
        public string logfilePath;

        private static void AppendElement<T>(XmlDocument document, XmlElement parent, string name, T value)
        {
            XmlElement el = document.CreateElement(name);
            el.InnerText = value.ToString();
            parent.AppendChild(el);
        }

        public XmlNode GetSettings(XmlDocument document)
        {
            XmlElement settingsNode = document.CreateElement("Settings");

            AppendElement(document, settingsNode, "Version", Assembly.GetExecutingAssembly().GetName().Version);
            AppendElement(document, settingsNode, "logfilePath", logfilePath);

            
            return settingsNode;
        }

        private bool FindSetting(XmlNode node, string name, bool previous)
        {
            var element = node[name];
            if (element == null)
                return previous;

            bool b;
            if (bool.TryParse(element.InnerText, out b))
                return b;

            return previous;
        }

        public void SetSettings(XmlNode settings)
        {

            if (settings == null) {
                return;
            }
            var versionElement = settings["Version"];
            if (versionElement == null)
                return;

            logfilePath = settings["logfilePath"].InnerText;

        }
    }
}
}