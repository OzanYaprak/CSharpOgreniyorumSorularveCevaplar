using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CopyConstructorNedir
{
	internal class Program
	{
		//Eğer bir constructor parametre olarak class'ın kendisini alıyorsa, buna copy constructor denilir.

		static void Main(string[] args)
		{
			ornekClass ornekClass1 = new ornekClass();
			ornekClass ornekClass2 = new ornekClass(ornekClass1);
			//Daha önceden var olan bir nesne örneğinden yeni bir nesne örneği oluşturduk.


            Console.WriteLine(ornekClass2.Yas);
        }
	}

	public class ornekClass
	{
        public string Isim { get; set; }
        public int Yas { get { return 32; } set { } }

		public ornekClass() { }

		public ornekClass(ornekClass ornekClass) //Copy Constructor
		{
			Isim = ornekClass.Isim;
			Yas = ornekClass.Yas;
		}
    }
}
