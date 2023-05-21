namespace Monte_Carlo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Pi();
        }
        static void Pi()
        {
            double n, k;
            double s, x, y;
            k = 0;
            n = 1000;
            Random r = new Random();
            for (int i = 1; i <= n; i++)
            {
                x = r.NextDouble();
                y = r.NextDouble();
                if (x * x + y * y <= 1)
                {
                    k = k + 1;
                }
            }
            s = 4 * (k / n);
            Console.WriteLine("Результат Пи = " + s);
            Console.WriteLine("Точное Пи=" + Math.PI);
        }
    }
}