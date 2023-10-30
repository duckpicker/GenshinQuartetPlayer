using WindowsInput.Native;

namespace QuartetPlayer
{
    internal class Keyboard
    {
        public static int instrumentID = 0;

        public static string changeInstrument(int id) {
            instrumentID = id;
            if (instrumentID == 0) return "Лира/Цитра";
            if (instrumentID == 1) return "Старая лира";
            else return "Барабан";
        }

        public static Dictionary<int, VirtualKeyCode> noteToKeyLyre = new()
        {   
            {48, VirtualKeyCode.VK_Z},
            {50, VirtualKeyCode.VK_X},
            {52, VirtualKeyCode.VK_C},
            {53, VirtualKeyCode.VK_V},
            {55, VirtualKeyCode.VK_B},
            {57, VirtualKeyCode.VK_N},
            {59, VirtualKeyCode.VK_M},

            {60, VirtualKeyCode.VK_A},
            {62, VirtualKeyCode.VK_S},
            {64, VirtualKeyCode.VK_D},
            {65, VirtualKeyCode.VK_F},
            {67, VirtualKeyCode.VK_G},
            {69, VirtualKeyCode.VK_H},
            {71, VirtualKeyCode.VK_J},

            {72, VirtualKeyCode.VK_Q},
            {74, VirtualKeyCode.VK_W},
            {76, VirtualKeyCode.VK_E},
            {77, VirtualKeyCode.VK_R},
            {79, VirtualKeyCode.VK_T},
            {81, VirtualKeyCode.VK_Y},
            {83, VirtualKeyCode.VK_U}
        };

        public static Dictionary<int, VirtualKeyCode> noteToKeyOldLyre = new()
        {
            {48, VirtualKeyCode.VK_Z},
            {50, VirtualKeyCode.VK_X},
            {51, VirtualKeyCode.VK_C},
            {53, VirtualKeyCode.VK_V},
            {55, VirtualKeyCode.VK_B},
            {57, VirtualKeyCode.VK_N},
            {58, VirtualKeyCode.VK_M},

            {60, VirtualKeyCode.VK_A},
            {62, VirtualKeyCode.VK_S},
            {63, VirtualKeyCode.VK_D},
            {65, VirtualKeyCode.VK_F},
            {67, VirtualKeyCode.VK_G},
            {69, VirtualKeyCode.VK_H},
            {70, VirtualKeyCode.VK_J},

            {72, VirtualKeyCode.VK_Q},
            {73, VirtualKeyCode.VK_W},
            {75, VirtualKeyCode.VK_E},
            {77, VirtualKeyCode.VK_R},
            {79, VirtualKeyCode.VK_T},
            {80, VirtualKeyCode.VK_Y},
            {82, VirtualKeyCode.VK_U}
        };
    }
}
