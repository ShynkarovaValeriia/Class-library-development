using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Lab05Lib;

namespace Lab05App
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Town[] arrTowns;

            Console.Write("Введiть кiлькiсть мiст: "); 
            int cntTowns = int.Parse(Console.ReadLine()); 
            arrTowns = new Town[cntTowns];

            for (int i = 0; i < cntTowns; i++)
            {
                Console.Write("Введiть назву мiста: ");
                string sName = Console.ReadLine();

                Console.Write("Введiть назву краiни: "); 
                string sCountry = Console.ReadLine();

                Console.Write("Введiть назву регiону: "); 
                string sRegion = Console.ReadLine();

                Console.Write("Введiть кiлькiсть населення: "); 
                string sPopulation = Console.ReadLine();

                Console.Write("Введiть рiчний дохiд: "); 
                string sYearIncome = Console.ReadLine();

                Console.Write("Введiть площу, кв. км: "); 
                string sSquare = Console.ReadLine();

                Console.Write("Чи є у мiстi порт? (y-так, n-нi): "); 
                ConsoleKeyInfo keyHasPort = Console.ReadKey(); 
                Console.WriteLine();

                Console.Write("Чи є у мiстi аеропорт? (y-так, n-нi): "); 
                ConsoleKeyInfo keyHasAirport = Console.ReadKey(); 
                Console.WriteLine();

                Console.WriteLine();

                Town theTown = new Town();

                theTown.Name = sName; 
                theTown.Country = sCountry; 
                theTown.Region = sRegion;
                theTown.Population = int.Parse(sPopulation); 
                theTown.YearIncome = double.Parse(sYearIncome); 
                theTown.Square = double.Parse(sSquare);
                theTown.HasPort = keyHasPort.Key == ConsoleKey.Y ? true : false; 
                theTown.HasAirport = keyHasAirport.Key == ConsoleKey.Y ? true : false;

                arrTowns[i] = theTown;
            }

            foreach (Town t in arrTowns)
            {
                Console.WriteLine();
                Console.WriteLine(new string('-', 50)); 
                Console.WriteLine("Данi про мiсто {0}", t.Name);
                Console.WriteLine(new string('-', 50));
                Console.WriteLine("Країна: " + t.Country); 
                Console.WriteLine("Регiон: " + t.Region); 
                Console.WriteLine("Кiлькiсть населення: " + t.Population.ToString()); 
                Console.WriteLine("Рiчний дохiд: " + t.YearIncome.ToString("0.00")); 
                Console.WriteLine("Площа: " + t.Square.ToString("0.000")); 
                Console.WriteLine(t.HasPort ? "У мiстi є порт" : "У мiстi нема порту"); 
                Console.WriteLine(t.HasAirport ? "У мiстi є аеропорт" : "У мiстi нема аеропорту"); 
                Console.WriteLine();
                Console.WriteLine("Середнiй рiчний дохiд на одного громадянина: " + t.yearIncomePerInhabitant.ToString("0.00"));
            }

            Console.ReadKey();

        }
    }
}