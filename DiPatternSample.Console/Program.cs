using System;

namespace DiPatternSample.Console
{
    class Program
    {
        static void Main(string[] args)
        {
            BL bl = new BL(new DAL());

            bl.GetProducts().ForEach(x => System.Console.WriteLine($"{x.Id}{x.Name}-{x.Price}-{x.Stock}"));;
            System.Console.ReadLine();
        }
    }
}
