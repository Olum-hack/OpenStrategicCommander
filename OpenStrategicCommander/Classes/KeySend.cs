using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Runtime.InteropServices;
using System.Diagnostics;
using System.Windows.Forms;

namespace OpenStrategicCommander.Classes
{    
    class KeySend
    {
        [DllImport("user32.dll", SetLastError = true)]
        static extern bool SendMessage(IntPtr hWnd, uint Msg, int wParam, IntPtr lParam);

        [DllImport("user32.dll")]
        private static extern IntPtr GetForegroundWindow();

        [DllImport("user32.dll", CharSet = CharSet.Auto)]
        private static extern uint MapVirtualKey(uint uCode, uint uMapType);

        const uint WM_KEYDOWN = 0x0100;
        const uint WM_KEYUP = 0x0101;

        /// <summary>
        /// Send KeyDown and KeyUp
        /// </summary>
        /// <param name="keys"></param>
        public static void SendKey(Keys keys)
        {
            //Get the actuall Window
            IntPtr intPtr = GetForegroundWindow();


            uint repeatCount = 0;
            uint extended = 0;
            uint context = 0;
            uint previousState = 0;
            uint transition = 0;

            uint scanCode = MapVirtualKey((uint)keys, 0);

            uint lParamDown = repeatCount
                | (scanCode << 16)
                | (extended << 24)
                | (context << 29)
                | (previousState << 30)
                | (transition << 31);

            previousState = 1;
            transition = 1;
            uint lParamUp = repeatCount
                | (scanCode << 16)
                | (extended << 24)
                | (context << 29)
                | (previousState << 30)
                | (transition << 31);

            bool SM1 = SendMessage(intPtr, WM_KEYDOWN, (int)keys, unchecked((IntPtr)(int)lParamDown));
            bool SM2 = SendMessage(intPtr, WM_KEYUP, (int)keys, unchecked((IntPtr)(int)lParamUp));
            int error =Marshal.GetLastWin32Error();
        }
    }
}
