using System;
using System.Diagnostics;
using System.Runtime.InteropServices;

namespace BlockUserInput
{
    public class BlockSystemInput
    {
        [StructLayout(LayoutKind.Sequential)]
        private struct KBDLLHOOKSTRUCT
        {
            public int key;
            public int scanCode;
            public int flags;
            public int time;
            public IntPtr extra;
        }

        //System level functions to be used for hook and unhook keyboard input  
        private delegate IntPtr LowLevelKeyboardProc(int nCode, IntPtr wParam, IntPtr lParam);
        [DllImport("user32.dll", CharSet = CharSet.Auto, SetLastError = true)]
        private static extern IntPtr SetWindowsHookEx(int id, LowLevelKeyboardProc callback, IntPtr hMod, uint dwThreadId);
        [DllImport("user32.dll", CharSet = CharSet.Auto, SetLastError = true)]
        private static extern bool UnhookWindowsHookEx(IntPtr hook);
        [DllImport("user32.dll", CharSet = CharSet.Auto, SetLastError = true)]
        private static extern IntPtr CallNextHookEx(IntPtr hook, int nCode, IntPtr wp, IntPtr lp);
        [DllImport("kernel32.dll", CharSet = CharSet.Auto, SetLastError = true)]
        private static extern IntPtr GetModuleHandle(string name);
        [DllImport("user32.dll", CharSet = CharSet.Auto)]
        private static extern short GetAsyncKeyState(int key);

        //Declaring Global objects     
        private static IntPtr ptrHook;
        private static LowLevelKeyboardProc objKeyboardProcess;
        private static int[] keys;
        private static bool altModifier;

        private static IntPtr CaptureKey(int nCode, IntPtr wp, IntPtr lp)
        {
            if (nCode >= 0)
            {
                KBDLLHOOKSTRUCT objKeyInfo = (KBDLLHOOKSTRUCT)Marshal.PtrToStructure(lp, typeof(KBDLLHOOKSTRUCT));

                foreach (int key in keys)
                {
                    // Disabling Windows keys 
                    if (objKeyInfo.key == key || (HasAltModifier(objKeyInfo.flags) && altModifier))
                    {
                        return (IntPtr)1; // if 0 is returned then All the above keys will be enabled
                    }
                }
            }
            return CallNextHookEx(ptrHook, nCode, wp, lp);
        }

        // Check for using Alt, AltGr
        static bool HasAltModifier(int flags)
        {
            return (flags & 0x20) == 0x20;
        }

        // Set keys to ignore
        public static void SetKeys(int[] userKeys)
        {
            keys = userKeys;
        }

        // Disable enable alt modifier to ignore if true it ignores alt + key pressing
        public static void SetAltModifiers(bool enableAltModifier)
        {
            altModifier = enableAltModifier;
        }

        // Start getting user keys to disable
        public static void Start()
        {
            ProcessModule objCurrentModule = Process.GetCurrentProcess().MainModule;
            objKeyboardProcess = new LowLevelKeyboardProc(CaptureKey);
            // Set Hook to get key pressing
            ptrHook = SetWindowsHookEx(13, objKeyboardProcess, GetModuleHandle(objCurrentModule.ModuleName), 0);
        }

        // Stop getting user keys
        public static void Stop()
        {
            // Remove hook to stop getting keys
            UnhookWindowsHookEx(ptrHook);
        }
    }
}