using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classwork_19_dec_17
{
    struct Viewer
    {
        public string name;
        public string lastname;
        public char sex;
        public int age;
        public override string ToString()
        {
            return String.Format($"     {name,10} ---       {lastname,15} ---       {age,2} ---     {sex}");
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Random rand = new Random();
            Viewer[,] Viewers = new Viewer[8, 8];
            char[] sexinfo = { 'M', 'F' };
            int countofpeople = rand.Next(18, 24);
            int x, y;

            for (int i = 0; i < countofpeople; i++)
            {
                while (true)
                {
                    x = rand.Next(0, 8);
                    y = rand.Next(0, 8);
                    if (Viewers[x, y].age == 0)
                    {
                        Viewers[x, y] = new Viewer { age = rand.Next(18, 60), sex = sexinfo[(rand.Next(0, 2))] };
                        break;
                    }
                }
            }
            List<Viewer> peopleincinema = new List<Viewer>();
            for (int i = 0; i < Viewers.GetLength(0); i++)
            {
                for (int j = 0; j < Viewers.GetLength(1); j++)
                {
                    if (Viewers[i, j].age == 0)
                        Console.Write(" - ");
                    else
                    {
                        Console.Write($" {Viewers[i, j].sex} ");
                        peopleincinema.Add(Viewers[i, j]);
                    }
                }
                Console.WriteLine();
            }
            Console.WriteLine();
            Console.WriteLine($"Statistics:");
            foreach (var item in peopleincinema)
            {
                Console.WriteLine(item);
            };

            float averageage = 0f;
            int countofmen = 0;
            int countofwomen = 0;
            float averageageM = 0f;
            float averageageF = 0f;
            Console.WriteLine($"Number of viewers: {peopleincinema.Count}");
            foreach (var item in peopleincinema)
            {
                averageage += item.age;
                if (item.sex == 'M')
                {
                    countofmen++;
                    averageageM += item.age;
                }
                else
                {
                    countofwomen++;
                    averageageF += item.age;
                }
            }
            Console.WriteLine($"Males: {countofmen}");
            Console.WriteLine($"Females: {countofwomen}");
            Console.WriteLine($"Average age: {averageage / peopleincinema.Count:f}");
            Console.WriteLine($"Average age of men: {averageageM/countofmen:f}");
            Console.WriteLine($"Average age of women: {averageageF / countofwomen:f}");
        }
    }
}
