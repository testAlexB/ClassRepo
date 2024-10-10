namespace MyNamespace
{
    public class M
    {
        /// <summary>
        /// раздел с полями класса
        /// </summary>
        private int a_;
        private int b_;

        /// <summary>
        /// раздел с методами класса
        /// </summary>
        public void SetA(int a)
        {
            a_ = a;
        }

        public void SetB(int b)
        {
            b_ = b;
        }

        public int Sum()
        {
            return a_ + b_;
        }

        public static int Sum(int a, int b, int c)
        {
            return a + b + c;
        }
    }
}
