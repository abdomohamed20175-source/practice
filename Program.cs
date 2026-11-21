using System.Runtime.Intrinsics.Arm;

namespace practice
{
    internal class Program
    {
        public static void RepalceArray(ref int[] prices)
        {
           prices = new int[] { 100, 200, 300 };
        }
        static void Main(string[] args)
        {
            int[] b = { 10, 20, 30 };
            Console.WriteLine(b[0]);// 10
            RepalceArray(ref b);
            Console.WriteLine(b[0]);
        }
    }
}
