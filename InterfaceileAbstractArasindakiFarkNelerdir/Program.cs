using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceileAbstractArasindakiFarkNelerdir
{
	internal class Program
	{
		#region Fark 1
		//Interfaceler field'lara sahip olmazlar.
		//Interfaceler propertyler'e ve methodlar'a sahip olabilirler.
		//Fakat ;
		//Abstract siniflar field, method ve propertylere'de sahip olabilirler.
		#endregion
		#region Fark 2
		//Bir interface birden fazla interface'i miras alabilir.
		//Fakat ;
		//Abstract siniflar sadece bir abstract siniftan miras alabilir.
		//Abstract class'lar birden fazle interface'de miras olarak alabilirler.
		#endregion
		#region Fark 3 
		//Interfacelerde erisim belirleyiciler yoktur yani bir interface icerisinde sadece methodun imzasi vardir, methodun ismi, donus tipi ve methodun aldigi parametreler vardir ama methodun herhangi bir public, private gibi bir erisim belirleyicisi yoktur.
		//Fakat ;
		//Abstract classlarda erisim belirleyiciler vardir.
		#endregion
		#region Fark 4
		//Interfacelerde method govdeli olmaz !
		//Fakat ;
		//Abstract classlarda methodlar hem govdeli hem govdesiz(abstract keyword ile) olabilirler.
		#endregion

		static void Main(string[] args)
		{
		}

		interface IInterface : IEnumerable<string>,IComparable,IAsyncResult //Birden fazla interface miras alinabilinir.
		{
			//string veri;  //Field Tanimlanamaz.

			void ConsoleYazdir(string yazi); //Sadece methodun imzasini tanimlayabiliriz. Imza : Methodun donustipi, Ismi, Aldigi Parametre
		}
		abstract class BaseClass : FirstChildClass /*, SecondChildClass*/ //Sadece bir tane class miras alinabilir.
		{
			string veri;  //Field Tanimlanabilir.

			public abstract void ConsoleYazdir(string yazi); //Govdesiz methodlar, bulundugu class'i miras alan diger classlar icerisinde govdelerini doldururlar, override edilirler.
			public void ConsoleBastir(string yazi) //Govdeli bir method.
			{
                Console.WriteLine("Base Class");
            }
		}

		class FirstChildClass { }
		class SecondChildClass { }
	}
}
