namespace Tdd
{
    public class Fibonacci
    {
        private int N1 { get; set; } = 0;
        private int N2 { get; set; } = 1;
        private int ValueInPostion { get; set; }

        public int GetValue(int position)
        {
            for (int i = 1; i < position - 1; i++)
            {
                ValueInPostion = N1 + N2;
                N1 = N2;
                N2 = ValueInPostion;
            }
            return ValueInPostion;
        }
    }
}
