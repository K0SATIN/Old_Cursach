/*
 * Создано в SharpDevelop.
 * Пользователь: Konstantin
 * Дата: 21.02.2022
 * Время: 15:36
 * 
 * Для изменения этого шаблона используйте меню "Инструменты | Параметры | Кодирование | Стандартные заголовки".
 */
using System;
using System.Linq;

namespace Cursach
{
    class Program
    {
        static void Main(string[] args)
        {     
        	ArrayInput AI = new ArrayInput();
        	int[] A = AI.IntConsoleOutput();             
			ChoseSortAlgoritmt Tournir = new ChoseSortAlgoritmt();
			ArrayOutput ConsolOutput = new ArrayOutput(Tournir.Int_Tournir(A));
           	ConsolOutput.ByConsole();       
        }
    }
}