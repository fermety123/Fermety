using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Обучение1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                uint b=0;
                Console.WriteLine("Герой ты стоишь на улице куда ,ты направишься?(выбирать цифрами) ");
                Console.WriteLine("1) Таверну");
                Console.WriteLine("2) Магазин");
                Console.WriteLine("3) Охота");
                uint a = uint.Parse(Console.ReadLine());
                switch (a)
                {
                    case 1:
                        while (true)
                        {
                            uint c = 0;
                            Console.Clear();
                            Console.WriteLine("1) Поспать");
                            Console.WriteLine("2) Поесть");
                            Console.WriteLine("3) Обратно на улицу");
                            b = uint.Parse(Console.ReadLine());
                            if (b == 3)
                            {
                                Console.Clear();
                                break;
                            }
                            if (b == 1)
                            {
                                Console.Clear();
                                Console.WriteLine("Вы поспали");
                                Console.ReadKey();                               
                                
                            }
                            if (b == 2)
                            {
                                Console.Clear();
                                Console.WriteLine("Вы кушаете");
                                Console.WriteLine("Встать 1)Да 2)Нет");
                                c = uint.Parse(Console.ReadLine());
                                if (c == 1)
                                {
                                    Console.Clear();
                                    Console.WriteLine("Ты встаешь и окидываешь таверну");
                                    Console.ReadKey();
                                }
                                else
                                {
                                    while (true)
                                    {
                                        Console.Clear();
                                        Console.WriteLine("Сидишь дальше");
                                        Console.WriteLine("Встать 1)Да 2)Нет");
                                        uint tav=uint.Parse(Console.ReadLine());
                                        if (tav==1)
                                        {
                                            break;
                                        }
                                    }
                                }
                            }                            
                        }
                        break;  
                     case 2:
                        while (true)
                        {
                            Console.Clear();
                            Console.WriteLine("1) Купить");
                            Console.WriteLine("2) Обратно на улицу");
                            b = uint.Parse(Console.ReadLine());
                            if (b==1)
                            {
                                Console.Clear();
                                Console.WriteLine("Нет денег");
                                Console.ReadKey();
                            }
                            if (b==2)
                            {
                                Console.Clear();
                                break;
                            }
                        }
                        break;
                    case 3:
                        while (true)
                        {
                            Console.Clear();
                            Console.WriteLine("1) Качаться");
                            Console.WriteLine("2) Обратно на улицу");
                            b = uint.Parse(Console.ReadLine());
                            if (b == 1)
                            {
                                Console.Clear();
                                Console.WriteLine("Силеннок маловато");
                                Console.ReadKey();
                            }
                            if(b==2)
                            {
                                Console.Clear();
                                break;
                            }
                        }
                        
                        break;
                        
                }
               
            }
            
        }   
    }
}
