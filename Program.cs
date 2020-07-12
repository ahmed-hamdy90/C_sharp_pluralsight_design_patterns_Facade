using System;
using FacadePattern.Services;

namespace FacadePattern
{
    class Program
    {
        static void Main(string[] args)
        {
            BigClass bigClass = new BigClass();
            
            bigClass.SetValueI(3);
            
            bigClass.IncrementI();
            bigClass.IncrementI();
            bigClass.IncrementI();
            
            bigClass.DecrememntI();
            
            Console.WriteLine($"Final Number : {bigClass.GetValueA()}");
        }
    }
}
