﻿using System;

namespace DaysOfTheWeek
{
	class Program
	{
		static void Main(string[] args)
		{
			//Задание 3 
			//Словарь
			//Программа предлагает пользователю ввести порядковый номер дня недели от 1 до 7
			//В соответствии с введенным значение, программа выводит на экран англоязычное название дня недели
			//например, если пользователь ввел 1, то на экран будет выведено  Monday
			//исправленный до рабочего состояния код дает до 5 пунктов 
			



			Console.WriteLine("Введите порядковый номер дня недели:");
			char weekDayNo = Convert.ToChar(Console.ReadLine());

			switch (weekDayNo)
			{
				case '1':
					Console.WriteLine("Monday");
					break;
				case '2':
					Console.WriteLine("Tuesday");
					break;
				case '3':
					Console.WriteLine("Wednesday");
					break;
				case '4':
					Console.WriteLine("Thursday");
					break;
				case '5':
					Console.WriteLine("Friday");
					break;
				case '6':
					Console.WriteLine("Saturday");
					break;
				case '7':
					Console.WriteLine("Sunday");
					break;

				default:
					Console.WriteLine("Invalid day number");
					break;

			}
		}
	}

}