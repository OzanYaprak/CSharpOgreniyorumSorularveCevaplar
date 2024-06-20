using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BirInterfaceDigerBirInterfacedenMirasAlabilirmi
{
	//C# da bir interface baska bir interfaceden miras alabilir veya birden fazla interfaceden miras alabilir.

	internal class Program
	{
		static void Main(string[] args)
		{
		}


		public class Urun : IDataIslem //Interface implement islemi
		{
			public string Detay(string id)
			{
				throw new NotImplementedException();
			}

			public void Ekle(string veri)
			{
				throw new NotImplementedException();
			}

			public string Guncelle(string id)
			{
				throw new NotImplementedException();
			}

			public void Sil(string id)
			{
				throw new NotImplementedException();
			}

			//IDataEkstra Miras alinan method
			public string TumDataGetir()
			{
				throw new NotImplementedException();
			}

			//IDataEkstra Miras alinan method
			public string TumDataSil()
			{
				throw new NotImplementedException();
			}

			//IDataEkstra2 Miras alinan method
			public string TumDataGuncelle(string id)
			{
				throw new NotImplementedException();
			}
		}


		interface IDataIslem : IDataEkstra, IDataEkstra2 //Miras alma islemi //Birden fazla interface miras alinabilinir
		{
			void Ekle(string veri);
			void Sil(string id);
			string Guncelle(string id);
			string Detay(string id);
		}



		interface IDataEkstra
		{
			string TumDataGetir();
			string TumDataSil();
		}

		interface IDataEkstra2
		{
			string TumDataGuncelle(string id);
		}
	}
}
