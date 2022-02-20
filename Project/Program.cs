using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;


namespace Турнир_с_выбыванием
{
    class Program
    {
        static void Rest(int[] A, int size, int indx)//конец просеивания пирамиды
        {        
                int temp, c, s;
                c = 2 * indx;
                while ((size > c + 1))
                {
                    s = 0;
                    if (size > c + 2)//если есть 2 потомка
                    {
                        if ((A[c + 2] > A[indx]) && (A[c + 1] < A[c + 2]))//проверка перехода в правый потомок
                        {
                            temp = A[c + 2];
                            A[c + 2] = A[indx];
                            A[indx] = temp;
                            s = 1;
                            indx = c + 2;//выписываем индекс участвовавшео в обмене элемента
                        }
                        else
                            if (A[c + 1] > A[indx])//проверка перехода в левый потомок
                            {
                                temp = A[c + 1];
                                A[c + 1] = A[indx];
                                A[indx] = temp;
                                s = 1;
                                indx = c + 1;
                            }
                    }
                    else
                        if (A[c + 1] > A[indx])//иначе проверяем при наличии одного потомка
                        {
                            temp = A[c + 1];
                            A[c + 1] = A[indx];
                            A[indx] = temp;
                            s = 1;
                            indx = c + 1;
                        }
                    if (s == 0)
                       break;
                    c = 2 * indx;//проверяем, есть ли потомки у элемента, с которым произошёл обмен
                }
               ;
        }

        static void Main(string[] args)
        {
            //базовый блок, в котором мы вводим размер массива и его инициализируем
            int size, temp, indx, c;//
            string S;

            Console.Write("Размер массива = ");
            S = Console.ReadLine();
            size = Convert.ToInt32(S);

            int[] A = new int[size];


            for (int i = 0; i < size; i++) //Цикл ввода элементов массива
            {
                Console.Write("Введите элемент массива A[{0}] = ", i);
                A[i] = Convert.ToInt32(Console.ReadLine());
            }

            for (int n = size / 2 - 1; n >= 0; n--)
            {
                Rest(A, size, n);//просеивание дерева         
            }

            for (int j = size - 1; j >= 1; j--)
            {
                temp = A[0];
                A[0] = A[j];
                A[j] = temp;
                Rest(A, j, 0);//надо выставить правильные данные 24,   31,  15,   20,   52,   6
            }
            //вот тут у нас должен быть алгоритм сортировки
            //см. вот тут http://prog-cpp.ru/sort-pyramid/ http://algolist.manual.ru/sort/pyramid_sort.php
            //далее должно быть так: берём первый элемент и последний, меняем их местами а потом просеиваем бывший последний элемент. 
            //  Выбираем предпоследний элемент, меняем местами с первым и просеиваем, и так до конца массива. И ах да, тот алгоритм который я реализую сортирует по убыванию.

            for (int i = 0; i < size; i++) //Цикл вывода элементов массива
            {
                Console.WriteLine("Элемент массива A[{0}] = {1}", i, A[i]);
            }
            Console.ReadKey();
        }
    }
}
