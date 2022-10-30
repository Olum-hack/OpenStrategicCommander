using System;
using System.Windows.Forms;

namespace OpenStrategicCommander.Classes.StrategicCommander
{
    [Serializable()]
    internal class SCAxes
    {
        public bool Depressed = false;
        readonly SC.AxesKey _Axe;
        Hotkey Hotkeys = null;

        public SCAxes(SC.AxesKey Axe)
        {
            _Axe = Axe;
        }

        public void AddHotkey(Keys KeyValue)
        {
            RemoveHotkey();
            Hotkeys = new Hotkey(KeyValue, 0);        
        }

        public Keys GetHotkey()
        {
            if (Hotkeys != null)
            {
                return Hotkeys.KeyValue;
            }
            else
            {
                return Keys.None;
            }
        }

        public void RemoveHotkey()
        {
            Hotkeys = null;
        }

        public SC.AxesKey Axe
        {
            get { return _Axe; }
        }
    }
}
