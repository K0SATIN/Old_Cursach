/*
 * Создано в SharpDevelop.
 * Пользователь: Konstantin
 * Дата: 22.02.2022
 * Время: 13:56
 * 
 * Для изменения этого шаблона используйте меню "Инструменты | Параметры | Кодирование | Стандартные заголовки".
 */
using System;

namespace Cursach
{
	/// <summary>
	/// Description of ChoseSortAlgoritmt.
	/// </summary>
	/// причина для изменения: новый алгоритм сортировки. Выбор и реализация алгоритма сортировки
	public class ChoseSortAlgoritmt
	{		
		public ChoseSortAlgoritmt() {}		
		int temp;
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
                       	indx = c + 2;//выписываем индекс участвовавшие в обмене элемента
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
		}	
		
		//вот тут у нас должен быть алгоритм сортировки
        //см. вот тут http://prog-cpp.ru/sort-pyramid/ http://algolist.manual.ru/sort/pyramid_sort.php
        //далее должно быть так: берём первый элемент и последний, меняем их местами а потом просеиваем бывший последний элемент. 
        //  Выбираем предпоследний элемент, меняем местами с первым и просеиваем, и так до конца массива. И ах да, тот алгоритм который я реализую сортирует по убыванию.     

		public int [] Int_Tournir(int [] A)
		{
			for (int n = A.Length / 2 - 1; n >= 0; n--)
            {
           		Rest(A, A.Length, n);//просеивание дерева         
            }
            for (int j = A.Length - 1; j >= 1; j--)
            {
            	temp = A[0];
                A[0] = A[j];
                A[j] = temp;
                Rest(A, j, 0);
            }
        	return A;	            
		}
	}
}
