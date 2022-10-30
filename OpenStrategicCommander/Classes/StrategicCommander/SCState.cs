using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;

namespace OpenStrategicCommander.Classes.StrategicCommander
{
    class SCState
    {
        public int xAxesState;
        public int yAxesState;
        public int zAxesState;
        public byte ButtonState;
        public byte ModifierState;

        public SCState()
        {
            xAxesState = 0;
            yAxesState = 0;
            zAxesState = 0;

            ButtonState = 0;
            ModifierState = 0;
        }

        public SCState(byte[] data)
        {
            if (data.Length >= 7)
            {
                xAxesState = ((data[2] & 0x03) << 8) | (data[1]);
                if (xAxesState >= 512) { xAxesState -= 512 * 2; }
                //Debug.WriteLine("xAxes:\t" + xAxesState.ToString());

                yAxesState = (((data[3] & 0x0f) << 6) | ((data[2] & 0xfc) >> 2));
                if (yAxesState >= 512) { yAxesState -= 512*2; }
                //Debug.WriteLine("yAxes:\t" + yAxesState.ToString());

                zAxesState = (((data[4] & 0x3f) << 4) | ((data[3] & 0xf0) >> 4));
                if (zAxesState >= 512) { zAxesState -= 512 * 2; }
                //Debug.WriteLine("zAxes:\t" + zAxesState.ToString());

                ButtonState = data[5];
                ModifierState = data[6];
            }
        }
    }
}
