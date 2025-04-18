using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Lab5Lib;

namespace Lab5App
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Animal[] arrAnimals;

            Console.Write("Введiть кiлькiсть тварин: ");
            int cntAnimals = int.Parse(Console.ReadLine());
            arrAnimals = new Animal[cntAnimals];

            for (int i = 0; i < cntAnimals; i++)
            {
                Console.Write("Введiть iм'я тварини: ");
                string sName = Console.ReadLine();

                Console.Write("Введiть вид тварини: ");
                string sSpecies = Console.ReadLine();

                Console.Write("Введiть вiк тварини: ");
                string sAge = Console.ReadLine();

                Console.Write("Введiть вагу тварини (кг): ");
                string sWeight = Console.ReadLine();

                Console.Write("Введiть зрiст тварини (м): ");
                string sHeight = Console.ReadLine();

                Console.Write("Введiть середовище: ");
                string sRegion = Console.ReadLine();

                Console.Write("Чи є тварина дикою? (y - так, n - нi): ");
                ConsoleKeyInfo keyIsWild = Console.ReadKey();
                Console.WriteLine();

                Console.Write("Чи є тварина зникаючим видом? (y - так, n - нi): ");
                ConsoleKeyInfo keyIsDied = Console.ReadKey();
                Console.WriteLine();

                Console.WriteLine();

                Animal animal = new Animal();

                animal.Name = sName;
                animal.Species = sSpecies;
                animal.Age = int.Parse(sAge);
                animal.Weight = double.Parse(sWeight);
                animal.Height = double.Parse(sHeight);
                animal.Region = sRegion;
                animal.IsWild = keyIsWild.Key == ConsoleKey.Y ? true : false;
                animal.IsDied = keyIsDied.Key == ConsoleKey.Y ? true : false;

                arrAnimals[i] = animal;
            }

            foreach (Animal a in arrAnimals)
            {
                Console.WriteLine();
                Console.WriteLine(new string('-', 50));
                Console.WriteLine("Дані про тварину {0}", a.Name);
                Console.WriteLine(new string('-', 50));
                Console.WriteLine("Вид: " + a.Species);
                Console.WriteLine("Вiк: " + a.Age);
                Console.WriteLine("Вага: " + a.Weight.ToString("0.00") + " кг");
                Console.WriteLine("Зрiст: " + a.Height.ToString("0.00") + " м");
                Console.WriteLine("Середовище: " + a.Region);
                Console.WriteLine(a.IsWild ? "Це дика тварина" : "Це домашня тварина");
                Console.WriteLine(a.IsDied ? "Це зникаючий вид" : "Це не зникаючий вид");
                Console.WriteLine();
                Console.WriteLine("Iндекс маси тiла: " + a.indexMassBody.ToString("0.00"));
            }

            Console.ReadKey();
        }
    }
}