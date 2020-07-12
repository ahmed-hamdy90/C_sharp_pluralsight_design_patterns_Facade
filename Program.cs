using System;
using FacadePattern.Services;

namespace FacadePattern
{
    class Program
    {
        static void Main(string[] args)
        {
            BigClassFacade bigClass = new BigClassFacade();
            
            bigClass.IncreaseBy(50);
            bigClass.DecreaseBy(20);
            
            Console.WriteLine($"Final Number : {bigClass.GetCurrentValue()}");
        }
    }
}
