using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using GreyMagic;
using System.Diagnostics;
using System.Runtime.InteropServices;
using System.Windows.Forms;
using System.Threading;

namespace LongMacro
{
    public class FinalFantasy
    {
        ExternalProcessReader mem;
        [DllImport("user32.dll", CharSet = CharSet.None, ExactSpelling = false)]
        public static extern IntPtr PostMessage(IntPtr intptr_1, uint uint_2, IntPtr intptr_2, IntPtr intptr_3);

        public enum CraftingCondition
        {
            NORMAL = 1,
            GOOD = 2,
            EXCELLENT = 3,
            POOR = 4
        }

        public FinalFantasy()
        {
            mem = new ExternalProcessReader(Process.GetProcessesByName("ffxiv").First());
        }

        //game state is usually 9 when crafting, 10 when under the effect of buff skills i.e. manipulation
        public int getGameState()
        {
            return BitConverter.ToInt32(mem.ReadBytes(new IntPtr(mem.ImageBase.ToInt32() + 16630424 + 4096), 4), 0);
        }

        //returns the current crafting step
        public int getCurrentStep()
        {
            return BitConverter.ToInt32(mem.ReadBytes(new IntPtr(mem.ImageBase.ToInt32() + 16630448 + 4096), 4), 0);
        }

        public int getExp()
        {
            return BitConverter.ToInt32(mem.ReadBytes(new IntPtr(mem.ImageBase.ToInt32() + 17052680 + 4096), 4), 0);
        }

        //1 = normal, 2 = good, 3 = excellent, 4 = poor
        public int getCondition()
        {
            return BitConverter.ToInt32(mem.ReadBytes(new IntPtr(mem.ImageBase.ToInt32() + 16630480 + 4096), 4), 0);
        }

        public int getCP()
        {
            int cpbase = BitConverter.ToInt32(mem.ReadBytes(new IntPtr(mem.ImageBase.ToInt32() + 17897092 + 4096), 4), 0);
            int offset1 = BitConverter.ToInt32(mem.ReadBytes(new IntPtr(cpbase + 732), 4), 0);
            int offset2 = BitConverter.ToInt32(mem.ReadBytes(new IntPtr(offset1 + 28), 4), 0);
            int CP = BitConverter.ToInt32(mem.ReadBytes(new IntPtr(offset2 + 24), 4), 0);

            return CP;
            //return BitConverter.ToInt32(mem.ReadBytes(new IntPtr(316639656), 4), 0);
        }

        public int getMaxCP()
        {
            return BitConverter.ToInt32(mem.ReadBytes(new IntPtr(mem.ImageBase.ToInt32() + 17006244 + 4096), 4), 0);
        }

        public int getDurability()
        {
            return BitConverter.ToInt32(mem.ReadBytes(new IntPtr(mem.ImageBase.ToInt32() + 16630472 + 4096), 4), 0);
        }

        public int getProgress()
        {
            return BitConverter.ToInt32(mem.ReadBytes(new IntPtr(mem.ImageBase.ToInt32() + 16630452 + 4096), 4), 0);
        }

        public void sendKey(Keys key)
        {
            PostMessage(mem.WindowHandle, 256, (IntPtr)((long)key), IntPtr.Zero);
            Thread.Sleep(100);
            PostMessage(mem.WindowHandle, 257, (IntPtr)((long)key), IntPtr.Zero);
        }
    }
}
