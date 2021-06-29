using System;
using System.Runtime.InteropServices;

namespace PrimaryButtonSwapper
{
    class Program
    {
        [DllImport("user32.dll")]
        public static extern Int32 SwapMouseButton(Int32 bSwap);

        static void Main(string[] args)
        {
            int right = SwapMouseButton(1);
            if (right != 0)
            {
                SwapMouseButton(0);
            }
        }
    }
}
