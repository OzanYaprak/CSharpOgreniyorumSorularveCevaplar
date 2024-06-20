using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BirInterfacedenNesneOrnegiAlabilirmiyiz
{
	//interfacelerin new anahtar sozcugu ile nesne ornegini alamayiz.

	internal class Program
	{
		static void Main(string[] args)
		{
			/*IIslem islem = new IIslem();*/     // Burada hata aliriz cunku bir interfaceden yeni bir nesne ornegi yaratamayiz. 

			//Fakat !

			IIslem islem = new Hesap(); // Bu sekilde bir kullanim ile bir IIslem turunde nesne ornegi yaratabiliriz.

            Console.WriteLine(islem.Topla(5,7));
			Console.ReadKey();
        }

		interface IIslem
		{
			int Topla(int a, int b);
			int Cikar(int a, int b);
		}


		class Hesap : IIslem
		{
			public int Cikar(int a, int b)
			{
				return a - b;
			}

			public int Topla(int a, int b)
			{
				return a + b;
			}
		}
	}
}
