using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BirInterfaceUyesiniExplicitOlarakImplementEtmekNeDemektir
{
	internal class Program
	{
		static void Main(string[] args)
		{
			Sekil sekil = new Sekil();
			sekil.Ciz();

			IKare kare = new Sekil();
			kare.Ciz();

			IUcgen ucgen = new Sekil();
			ucgen.Ciz();
		}


		class Sekil : IKare, IUcgen
		{
			//Genel method
			public void Ciz()
			{
				Console.WriteLine("Sekil Class Cizme islemi basladi..");
				Console.ReadKey();
			}


			//Interface Methodlarini Acik Bir Sekilde Implementasyon Islemi Gerceklestirebiliriz
			//Asagidaki methodlar mutlaka interface uzerinden erisilmesi gerekir.
			void IKare.Ciz() { Console.WriteLine("IKare Ciz Metotu Calisti"); Console.ReadKey(); }
			void IUcgen.Ciz() { Console.WriteLine("IUcgen Ciz Metotu Calisti"); Console.ReadKey(); }
		}

		interface IKare
		{
			void Ciz();
		}

		interface IUcgen
		{
			void Ciz();
		}
	}
}
