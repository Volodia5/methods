using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dossiers
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] init = {"Иванов Иван Иванович"};
            string[] pos = {"Главный чебупель"};
            bool isWork = true;
            do
            {
                Console.WriteLine("меню: ");
                Console.WriteLine("1) Инвентарь\n2) Добавить досье\n3) Удалить досье\n4) Поиск досье по фамилии\n5) Выход");
                int userInput = int.Parse(Console.ReadLine());

                switch (userInput)
                {
                    case 1://печать массива
                        int indexElement = 0;
                        indexElement++;
                        PrintArray(ref init,ref pos);
                        Console.WriteLine();
                        break;
                    case 2://добавить элемент
                        Console.Write("Введите ФИО : ");
                        string newInit = Console.ReadLine();
                        Console.Write("Введите должность : ");
                        string newPos = Console.ReadLine();
                        AddDossier(ref init,ref pos, newInit ,newPos);
                        Console.WriteLine();
                        break;
                    case 3://удалить элемент
                           //P.S : не получилось
                        Console.Write("Введите номер досье для удаления: ");
                        int deleteIndex = int.Parse(Console.ReadLine());
                        if (deleteIndex >= 0 && deleteIndex < init.Length)
                        {
                            string[] tempArray = new string[init.Length - 1];
                            for (int i = 0; i < init.Length; i++)
                            {
                                if (i < deleteIndex)
                                {
                                    tempArray[i] = init[i];
                                }
                                else if (i > deleteIndex)
                                {
                                    tempArray[i - 1] = init[i];
                                }
                            }
                            init = tempArray;
                            Console.WriteLine();
                            for (int i = 0; i < pos.Length; i++)
                            {
                                if (i < deleteIndex)
                                {
                                    tempArray[i] = pos[i];
                                }
                                else if (i > deleteIndex)
                                {
                                    tempArray[i - 1] = pos[i];
                                }
                            }
                            pos = tempArray;
                        }
                        Console.WriteLine();
                        break;
                    case 4://выход
                        break;
                    case 5://выход
                        isWork = false;
                        break;
                }
            } while (isWork == true);
            Console.ReadKey();
        }

        private static void PrintArray(ref string[] init,ref string[] pos)
        {
            for (int i = 0; i < init.Length; i++)
            {
                Console.Write($"{i}) {init[i]}");
            }

        }

        private static void AddDossier(ref string[] initials, ref string[] position, string newInit , string newPos)
        {
            string[] tempArray = new string[initials.Length + 1];
            for (int i = 0; i < initials.Length; i++)
            {
                tempArray[i] = initials[i];
            }
            tempArray[tempArray.Length - 1] = newInit;
            initials = tempArray;
            string[] tempArray1 = new string[initials.Length + 1];
            for (int i = 0; i < position.Length; i++)
            {
                tempArray1[i] = position[i];
            }
            tempArray1[tempArray1.Length - 1] = newPos;
            position = tempArray1;
        }
    }
}
