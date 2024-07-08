using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrivateConstructorNedir
{
	internal class Program
	{
		//Erişim belirleyici olarak Private kullanılır.

		static void Main(string[] args)
		{
			ornekClass ornekClass = new ornekClass(); //Constructor private olduğu için buradan erişilemez
		}
	}

	public class ornekClass
	{
        public string Isım { get; set; }
        public int Yas { get; set; }

		private ornekClass() //Bulunduğu class içerisinde sadece erişilebilinir.
		{
			Isım = "Ozan";
			Yas = 30;
		}

		ornekClass ornekClass2 = new ornekClass();
    }
}
