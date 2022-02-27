/*
 * Создано в SharpDevelop.
 * Пользователь: Konstantin
 * Дата: 21.02.2022
 * Время: 16:21
 * 
 * Для изменения этого шаблона используйте меню "Инструменты | Параметры | Кодирование | Стандартные заголовки".
 */
using System;

namespace Cursach
{
	/// <summary>
	/// Description of ArrayInput.
	/// </summary>
	/// //причина для изменения: новый способ ввода. Отвечает за инициализацию массива
	public class ArrayInput
	{
		int size;
		String reader;		
		public ArrayInput()
		{
		}	

		public int [] IntConsoleOutput()
		{
			Console.Write("Размер массива = ");
            reader = Console.ReadLine();
            size = Convert.ToInt32(reader);            
            int[] A = new int[size];
            for (int i = 0; i < A.Length; i++) //Цикл ввода элементов массива
            {
                Console.Write("Введите элемент массива A[{0}] = ", i);
                A[i] = Convert.ToInt32(Console.ReadLine());
            }            
            return A;
		}
	}
}
