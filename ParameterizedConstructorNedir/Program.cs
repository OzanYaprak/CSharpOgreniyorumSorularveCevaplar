using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ParameterizedConstructorNedir
{
	internal class Program
	{
		//Herhangi bir Constructor'a parametre veriliyorsa bu Parameterized Constructor Oluyor.

		static void Main(string[] args)
		{
			ornekClass ornekClass = new ornekClass("ozan",33); //Parameterized Constructor tarafında tanımlanan parametreleri burada tanımladım.

			Console.WriteLine(ornekClass.Isim);
            Console.WriteLine(ornekClass.Yas);
        }
	}

	public class ornekClass
	{
        public string Isim { get; set; }
        public int Yas { get; set; }

		public ornekClass() //Aşağıda parametreli bir constructor tanımladığımız için default constructor kullanımdan kalkmış oldu, bu durumda default contructor'ı bu şekilde yeniden boş şekilde tanımlayabiliriz.
		{

		}

        public ornekClass(string isim, int yas) //Parameterized Constructor
		{
			this.Isim = isim; //Burada this kullanmak yukarıdaki class içerisindeki Isim propertysine atama yapılacağını belirtir.
			//veya aşağıdaki gibi de kullanılabilinir.
			Yas = yas;
		}
	}
}
