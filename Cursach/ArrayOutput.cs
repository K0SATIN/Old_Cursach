/*
 * Создано в SharpDevelop.
 * Пользователь: Konstantin
 * Дата: 21.02.2022
 * Время: 15:54
 * 
 * Для изменения этого шаблона используйте меню "Инструменты | Параметры | Кодирование | Стандартные заголовки".
 */
using System;

namespace Cursach
{
	/// <summary>
	/// Description of SortArrayOutput.
	/// </summary>
	/// //причина для изменения: новый способ вывода. Вывод массива
	public class ArrayOutput
	{
		int [] Array;
		public ArrayOutput(int [] OutsideArray)
		{
			Array = OutsideArray;
		}
		
		public void ByConsole()
		{
			for (int i = 0; i < Array.Length; i++) //Цикл вывода элементов массива
            {
            	Console.WriteLine("Элемент массива A[{0}] = {1}", i, Array[i]);
            }
            Console.ReadKey();
		}
	}
}
