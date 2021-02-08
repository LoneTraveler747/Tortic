using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tortik_2._0
{
    class Program
    {
        static int summ = 0;
        static void menu()
        {
            Console.WriteLine(" Вас пиветствует кондитерская");
            Console.WriteLine(" Создание торта состоит из 3-х пунктов");
            Console.WriteLine(" Первый пункт: Выбор формы торта");
            Console.WriteLine(" Второй пункт: Выбор количества слоём и начинки торта");
            Console.WriteLine(" Третий пункт: Оплата заказа");
        }
        static void Forma()
        {
            int T, R = 1;
            Console.WriteLine(" 1) Квадратная форма ");
            Console.WriteLine(" 2) Круглая форма ");
            Console.WriteLine(" 3) Треугольная форма ");
            Console.Write(" Выберите форму торта: ");
            while (R == 1)
            {               
                while (!int.TryParse(Console.ReadLine(), out T))
                {
                    Console.Clear();
                    Console.WriteLine(" Только форма ");
                    Console.WriteLine(" 1) Квадратная форма ");
                    Console.WriteLine(" 2) Круглая форма ");
                    Console.WriteLine(" 3) Треугольная форма ");
                    Console.Write(" Выберите форму торта: ");
                }               
                switch (T)
                {
                    case 1:
                        {
                            Console.WriteLine(" Вы выбрали квадратную форму");
                            Console.WriteLine(" Стоимость: + 40 руб.");
                            summ += 40;
                            R = 0;
                            break;
                        }  
                    case 2:
                        {
                            Console.WriteLine(" Вы выбрали круглую форму");
                            Console.WriteLine(" Стоимость: + 50 руб.");
                            summ += 50;
                            R = 0;
                            break;
                        }
                    case 3:
                        {
                            Console.WriteLine(" Вы выбрали треугольную форму");
                            Console.WriteLine(" Стоимость: + 60 руб.");
                            summ += 60;
                            R = 0;
                            break;
                        }
                    default:
                        {
                            Console.WriteLine("выбрать можно только 1, 2 или 3");
                            break;
                        }
                }
            }
            Console.Clear();
        }       
        static void sloi()
        {
            int Y = 1, U, I = 1;
            int j;
            Console.Write("Выберите кол-во слоёв в торте от 1 до 3-х: ");
            while (Y == 1)
            {
                while (!int.TryParse(Console.ReadLine(), out U))
                {
                    Console.WriteLine(" Не ломай прогу");
                }
                switch (U)
                {
                    case 1:
                        {
                            Console.Clear();
                            while (I == 1)
                            {
                                Console.WriteLine(" Вы выбрали один слой");
                                Console.WriteLine(" ");
                                Console.WriteLine(" Список начинки слоя:");
                                Console.WriteLine(" ");
                                Console.WriteLine(" 1) шоколадный слой");
                                Console.WriteLine(" 2) ванильный слой");
                                Console.WriteLine(" 3) сюрприз слой");
                                Console.Write(" Выберите начинку слоя: ");
                               while (!int.TryParse(Console.ReadLine(), out j))
                               {
                                    Console.WriteLine(" Не ломай прогу");
                               }
                                Console.Clear();
                                if (j == 1)
                                {
                                    Console.WriteLine(" Вы выбрали шоколадную начинку");
                                    Console.WriteLine(" + 100 руб");
                                    summ += 100;
                                    Y = 0;
                                    I = 0;
                                }
                                if (j == 2)
                                {
                                    Console.WriteLine(" Вы выбрали ванильную начинку");
                                    Console.WriteLine(" + 120 руб");
                                    summ += 120;
                                    Y = 0;
                                    I = 0;
                                }
                                if (j == 3)
                                {
                                    Console.WriteLine(" Вы выбрали начинку с парашей");
                                    Console.WriteLine(" + 0 руб");
                                    summ += 0;
                                    Y = 0;
                                    I = 0;
                                }
                                if (j < 1 || j > 3)
                                {
                                    Console.WriteLine(" Нет такой начинки");
                                    I = 1;
                                    Console.Clear();
                                }
                                else
                                {
                                    I = 0;
                                }
                                
                            }
                            break;                         
                        }
                    case 2:
                        {
                            int l,e;
                            Console.WriteLine(" Вы выбрали два слоя");
                            Console.WriteLine(" ");
                            Console.WriteLine(" Список начинки слоя:");
                            Console.WriteLine(" ");
                            Console.WriteLine(" 1) шоколадный слой");
                            Console.WriteLine(" 2) ванильный слой");
                            Console.WriteLine(" 3) клубничный слой ");
                            Console.Write(" Выберите начинку для первого слоя: ");
                            while (!int.TryParse(Console.ReadLine(), out l))
                            {
                                Console.WriteLine(" Не ломай прогу");
                            }
                            Console.Clear();
                            if ( l == 1)
                            {
                                Console.WriteLine(" Вы выбрали шокладную начинку для первого слоя");
                                Console.WriteLine(" + 100");
                                summ += 100;
                                Y = 0;
                            }
                            if (l == 2) 
                            {
                                Console.WriteLine(" Вы выбрали ванильную начинку для первого слоя");
                                Console.WriteLine(" + 120");
                                summ += 120;
                                Y = 0;
                            }
                            if (l == 3)
                            {
                                Console.WriteLine(" Вы выбрали клубничную начинку для первого слоя");
                                Console.WriteLine(" + 180");
                                summ += 180;
                                Y = 0;
                            }
                            if (l < 1 || l > 3)
                            {
                                Console.WriteLine(" Нет такой начинки");
                                I = 1;
                                Console.Clear();
                            }
                            else
                            {
                                I = 0;
                            }
                            Console.WriteLine(" Список начинки слоя:");
                            Console.WriteLine(" ");
                            Console.WriteLine(" 1) шоколадный слой");
                            Console.WriteLine(" 2) ванильный слой");
                            Console.WriteLine(" 3) сюрприз слой");
                            Console.WriteLine(" Выберите начинку слоя: ");
                            Console.Write(" Выберите начинку для второго слоя: ");
                            while (!int.TryParse(Console.ReadLine(), out e))
                            {
                                Console.WriteLine(" Не ломай прогу");
                            }
                            Console.Clear();
                            if (e == 1)
                            {
                                Console.WriteLine(" Вы выбрали шоколадную начинку для второго слоя ");
                                Console.WriteLine("+ 100");
                                summ += 100;
                                Y = 0;
                            }
                            if (e == 2)
                            {
                                Console.WriteLine(" Вы выбрали ванильную начинку для второго слоя ");
                                Console.WriteLine("+ 120");
                                summ += 100;
                                Y = 0;
                            }
                            if (e == 3)
                            {
                                Console.WriteLine(" Вы выбрали клубничную начинку для второго слоя ");
                                Console.WriteLine("+ 180");
                                summ += 100;
                                Y = 0;
                            }
                            if (e < 1 || e > 3)
                            {
                                Console.WriteLine(" нет такой начинки");
                                I = 1;
                                Console.Clear();
                            }
                            else
                            {
                                I = 0;
                            }
                        }
                        break;
                    case 3:
                        {
                            int z,x,c;
                            Console.WriteLine(" Вы выбрали три слоя");
                            Console.WriteLine(" ");
                            Console.WriteLine(" Список начинки слоя:");
                            Console.WriteLine(" ");
                            Console.WriteLine(" 1) шоколадный слой");
                            Console.WriteLine(" 2) ванильный слой");
                            Console.WriteLine(" 3) клубничный слой ");
                            Console.Write(" Выберите начинку для первого слоя: ");
                            while (!int.TryParse(Console.ReadLine(), out z))
                            {
                                Console.WriteLine(" Не ломай прогу");
                            }
                            Console.Clear();
                            if (z == 1)
                            {
                                Console.WriteLine(" Вы выбрали шокладную начинку для первого слоя");
                                Console.WriteLine(" + 100");
                                summ += 100;
                                Y = 0;
                            }
                            if (z == 2)
                            {
                                Console.WriteLine(" Вы выбрали ванильную начинку для первого слоя");
                                Console.WriteLine(" + 120");
                                summ += 120;
                                Y = 0;
                            }
                            if (z == 3)
                            {
                                Console.WriteLine(" Вы выбрали клубничную начинку для первого слоя");
                                Console.WriteLine(" + 180");
                                summ += 180;
                                Y = 0;
                            }
                            if (z < 1 || z > 3)
                            {
                                Console.WriteLine(" Нет такой начинки");
                                I = 1;
                                Console.Clear();
                            }
                            else
                            {
                                I = 0;
                            }                           
                            Console.WriteLine(" Список начинки слоя:");
                            Console.WriteLine(" ");
                            Console.WriteLine(" 1) шоколадный слой");
                            Console.WriteLine(" 2) ванильный слой");
                            Console.WriteLine(" 3) клубничный слой ");
                            Console.Write(" Выберите начинку для второго слоя: ");
                            while (!int.TryParse(Console.ReadLine(), out x))
                            {
                                Console.WriteLine(" Не ломай прогу");
                            }
                            Console.Clear();
                            if (x == 1)
                            {
                                Console.WriteLine(" Вы выбрали шокладную начинку для второго слоя");
                                Console.WriteLine(" + 100");
                                summ += 100;
                                Y = 0;
                            }
                            if (x == 2)
                            {
                                Console.WriteLine(" Вы выбрали ванильную начинку для второго слоя");
                                Console.WriteLine(" + 120");
                                summ += 120;
                                Y = 0;
                            }
                            if (x == 3)
                            {
                                Console.WriteLine(" Вы выбрали клубничную начинку для второго слоя");
                                Console.WriteLine(" + 180");
                                summ += 180;
                                Y = 0;
                            }
                            if (x < 1 || x > 3)
                            {
                                Console.WriteLine(" Нет такой начинки");
                                I = 1;
                                Console.Clear();
                            }
                            else
                            {
                                I = 0;
                            }
                            Console.WriteLine(" Список начинки слоя:");
                            Console.WriteLine(" ");
                            Console.WriteLine(" 1) шоколадный слой");
                            Console.WriteLine(" 2) ванильный слой");
                            Console.WriteLine(" 3) клубничный слой");
                            Console.Write(" Выберите начинку для трерьего слоя: ");
                            while (!int.TryParse(Console.ReadLine(), out c))
                            {
                                Console.WriteLine(" Не ломай прогу");
                            }
                            Console.Clear();
                            if (c == 1)
                            {
                                Console.WriteLine(" Вы выбрали шокладную начинку для третьего слоя");
                                Console.WriteLine(" + 100");
                                summ += 100;
                                Y = 0;
                            }
                            if (c == 2)
                            {
                                Console.WriteLine(" Вы выбрали ванильную начинку для третьего слоя");
                                Console.WriteLine(" + 120");
                                summ += 120;
                                Y = 0;
                            }
                            if (c == 3)
                            {
                                Console.WriteLine(" Вы выбрали клубничную начинку для третьего слоя");
                                Console.WriteLine(" + 180");
                                summ += 180;
                                Y = 0;
                            }
                            if (c < 1 || c > 3)
                            {
                                Console.WriteLine(" Нет такой начинки");
                                I = 1;
                                Console.Clear();
                            }
                            else
                            {
                                I = 0;
                            }
                        }
                        break;
                    default:
                        {
                            Console.WriteLine(" Нет такого слоя");
                            break;
                        }                
                }               
            }            
        }
        static void vishinka()
        {
            int I = 1;
            int Y;
            Console.WriteLine("Хотите вишинку (Только одну)");
            Console.WriteLine(" 1) Хотите ");
            Console.WriteLine(" 2) Не хотите ");
            while (I == 1)
            {
                while (!int.TryParse(Console.ReadLine(), out Y))
                {
                    Console.WriteLine(" Не ломай прогу");
                }
                switch (Y)
                {
                    case 1:
                        {
                            Console.WriteLine(" Вы выбрали вишинку ");
                            Console.WriteLine(" + 30 ");
                            summ += 30;
                            I = 0;
                        }break;
                    case 2:
                        {
                            Console.WriteLine(" Вы нелюбите вишинку? ");
                            Console.WriteLine(" + 0 ");
                            summ += 0;
                            I = 0;
                        }
                        break;
                    default:
                        {
                            I = 1;
                        }
                    break;
                }
            }
        }
        static void oplata()
        {
            int O, K, B = 1;
            Console.WriteLine(" Сумма заказа: " + summ);
            Console.Write(" Оплатите стоимость: ");
            while (!int.TryParse(Console.ReadLine(), out O))
            {
                Console.WriteLine(" Не ломай прогу");
            }
            K = O - summ;
            if (O <= summ)
            {
                while (B == 1)
                {
                    Console.WriteLine(" Мы принимае полную цену " + summ + " руб.");                  
                    while (!int.TryParse(Console.ReadLine(), out O))
                    {
                        Console.WriteLine(" Не ломай прогу");
                    }                   
                    if (O >= summ)
                    {
                        K = O - summ;
                        B = 0;                      
                    }
                    Console.Clear();
                }               
            }
            Console.WriteLine(" Спасибо за оплату.");
            Console.WriteLine(" Сдача: " + K + " руб.");
            Console.WriteLine(" ");
            Console.WriteLine(" До свидания!");
        }
        static void Main(string[] args)
        {           
            menu();
            Forma();
            sloi();
            vishinka();
            oplata();
            Console.ReadKey();
        }       
    }    
}
