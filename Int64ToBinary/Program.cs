namespace Int64ToBinary
{
    public class Program
    {
        static void Main(string[] args)
        {
            LongToBinary.GetBinaryFromLong(457667858674766545);
            Console.WriteLine();
            LongToBinary.GetBinaryFromLong(234122343431232133);
        }
    }

    public static class LongToBinary
    {
        public static void GetBinaryFromLong(long value)
        {
            long i;

            Console.Write("0");
            for (i = 1 << 30;  i > 0; i = i / 2)
            {
                if((value & i) != 0)
                {
                    Console.Write("1");
                }
                else
                {
                    Console.Write("0");
                }
            }
        }
    }
}
