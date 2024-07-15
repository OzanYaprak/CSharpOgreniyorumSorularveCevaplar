using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DelegateNedir
{
	public delegate void FullNameDelegate(string name, string surname);

	internal class Program
	{
		//Delegateler bir method'a referans veren yapılardır. / Aracılık yapan methodlarda denilebilinir.
		//Methodları daha kolay kontrol edebilmemizi ve dinamik olarak kontrol edebilmemize imkan sağlar.
		//Bir class içerisindeki methodu delegate vasıtası ile çağırabiliriz.
		//Delegate'ler iki sekilde siniflandirilir ; 1.SingleCast Delegate 2.MultiCast Delegate

		//SINGLECAST DELEGATE
		static void Main(string[] args)
		{
			FullNameDelegate fullNameDelegate_1 = new FullNameDelegate(FullNameMethod_1);
			FullNameDelegate fullNameDelegate_2 = new FullNameDelegate(FullNameMethod_2);
			FullNameDelegate fullNameDelegate_3 = new FullNameDelegate(FullNameMethod_3);

			FullNameDelegate multiDelegates = fullNameDelegate_1+fullNameDelegate_2+fullNameDelegate_3; //Yukaridaki tum delegateleri bir araya getirmis oluyoruz.

			multiDelegates.Invoke("Erhan", "Yaprak");

			fullNameDelegate_1("ozan","yaprak");
		}

		public static void FullNameMethod_1(string name, string surname) //Static keyword'e sahip olan classlar, ayni keyword'e sahip olan classlarda kullanilirlar.
		{
            Console.WriteLine(name + " " + surname);
        }


		public static void FullNameMethod_2(string name, string surname)
		{
			Console.WriteLine(name.ToUpper() + " " + surname.ToUpper());
		}


		public static void FullNameMethod_3(string name, string surname)
		{
			Console.WriteLine(surname.ToUpper() + " " + name.ToUpper());
		}
	}
}
