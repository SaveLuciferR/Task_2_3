using System;
using System.Diagnostics.CodeAnalysis;
using System.Runtime.CompilerServices;

namespace Task_2_3
{
	class Programm
	{
		static void Main(string[] agrs)
		{

			try
			{
				double metrOnDum = 25.4;
				int d;

				while (true)
				{
					Console.WriteLine("Введите кол-во чисел для таблицы");
					d = Convert.ToInt32(Console.ReadLine());

					if (d > 0)
					{
						break;
					}

					Console.WriteLine("Кол-во чисел не может быть меньше или равно 0");
				}


				Console.WriteLine("Дюймы (четные числа)");
				for (int j = 2; j <= d; j += 2)
				{
					Console.Write(j + "\t");
				}

				Console.WriteLine("\n");
				Console.WriteLine("For: ");
				for (int j = 2; j <= d; j += 2)
				{
					Console.Write("{0:f1}\t", j * metrOnDum);
				}

				Console.WriteLine("\n");
				Console.WriteLine("While: ");

				int i = 2;
				while (i <= d)
				{
					Console.Write("{0:f1}\t", i * metrOnDum);
					i += 2;
				}

				Console.WriteLine("\n");
				Console.WriteLine("DoWhile");
				i = 2;

				do
				{
					Console.Write("{0:f1}\t", i * metrOnDum);
					i += 2;
				} while (i <= d);
			}
			catch
			{
				Console.WriteLine("Число должно быть целым");
			}
		}
	}
}