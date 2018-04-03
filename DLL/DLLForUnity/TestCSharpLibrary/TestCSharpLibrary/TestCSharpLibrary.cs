using System;
using System.Runtime.InteropServices;

namespace TestCSharpLibrary
{
    public class TestCSharpLibrary
    {
        [DllImport("TestCPPLibrary")]
        public static extern float TestMultiply(float a, float b);

        [DllImport("TestCPPLibrary")]
        public static extern float TestDivide(float a, float b);

        public static float SharpMultiply(float a, float b)
        {
            return (a * b);
        }

        public static float SharpDivide(float a, float b)
        {
            if (b == 0)
            {
                return 0;
            }

            return (a / b);

        }
    }
}