using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace methodsHomeWork
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] inventary = { "меч", "щит" };
            bool isWork = true;
            do
            {
                Console.WriteLine("меню: ");
                Console.WriteLine("1) Инвентарь\n2) Добавить элемент в инвентарь\n3) Удалить предмет из инвентаря\n4) Выход");
                int userInput = int.Parse(Console.ReadLine());

                switch (userInput)
                {
                    case 1://печать массива
                        int indexElement = 0;
                        indexElement++;
                        PrintArray(inventary);
                        Console.WriteLine();
                        break;
                    case 2://добавить элемент
                        Console.Write("Введите название предмета: ");
                        string newItem = Console.ReadLine();
                        AddItem(ref inventary, newItem);
                        Console.WriteLine();
                        break;
                    case 3://удалить элемент
                           //P.S : не получилось
                        Console.Write("Введите номер предмета для удаления: ");
                        int deleteIndex = int.Parse(Console.ReadLine());
                        if (deleteIndex >= 0 && deleteIndex < inventary.Length)
                        {
                            string[] tempArray = new string[inventary.Length - 1];
                            for (int i = 0; i < inventary.Length; i++)
                            {
                                if (i < deleteIndex)
                                {
                                    tempArray[i] = inventary[i];
                                }
                                else if (i > deleteIndex)
                                {
                                    tempArray[i - 1] = inventary[i];
                                }
                            }
                            inventary = tempArray;
                        }
                        DeleteElement(ref inventary, deleteIndex);
                        Console.WriteLine();
                        break;
                    case 4://выход
                        isWork = false;
                        break;
                }
            } while (isWork == true);
            Console.ReadKey();
        }

        private static void PrintArray(string[] array)
        {
            for (int i = 0; i < array.Length; i++)
            {
                Console.Write($"{i}) {array[i]}\n");
            }
        }

        private static void AddItem(ref string[] array, string newItem)
        {
            string[] tempArray = new string[array.Length + 1];
            for (int i = 0; i < array.Length; i++)
            {
                tempArray[i] = array[i];
            }
            tempArray[tempArray.Length - 1] = newItem;
            array = tempArray;
        }
        private static void DeleteElement(ref string[] deleteItem, int deleteIndex)
        {
        }
    }
}
