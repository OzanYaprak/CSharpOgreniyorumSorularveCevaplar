using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Event
{
	public class Program
	{
		static void Main(string[] args)
		{
			Car car = new Car();

			car.Model = "Volkswagen";

			car.SpeedEvent += Car_SpeedEvent;
			//Diger bir yontem asagidaki gibi olabilir, daha basit kullanim
			car.SpeedEvent += (speedValue) => { Console.WriteLine("Hiz limitini astiniz ! Hiz:" + " " + speedValue); };

			for (int i = 50; i < 100; i+=5) 
			{
				System.Threading.Thread.Sleep(700); //Her bir for dongusunu pas gectiginde 300 milisecond yavaslatma uygular

				car.Speed = i;

                Console.WriteLine("Arac hizi:" + " " + i);
            }
		}

		private static void Car_SpeedEvent(int speedValue)
		{
            Console.WriteLine("Hiz limitini astiniz ! Hiz:" + " " + speedValue);
        }
	}


	public delegate void SpeedDelegate(int speedValue);


	public class Car
	{
		public event SpeedDelegate SpeedEvent;

		private int _speedValue;

		public string Model { get; set; }
		public int Speed
		{
			get { return _speedValue; }
			set
			{
				if (value > 80)
				{
					SpeedEvent(value); //Eventin firlatildigi kisim
				}
				else { _speedValue = value; }
			}
		}
	}
}
