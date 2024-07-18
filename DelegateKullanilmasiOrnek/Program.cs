using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DelegateKullanilmasiOrnek
{
	public class Program
	{
		static void Main(string[] args)
		{
			Isci isci = new Isci();

			Isci isci1 = new Isci { Isim = "Ozan", Soyisim = "Yaprak", Maas = 4500, Tecrube = 4 };
			Isci isci2 = new Isci { Isim = "Erhan", Soyisim = "Yaprak", Maas = 2750, Tecrube = 3 };
			Isci isci3 = new Isci { Isim = "Arif", Soyisim = "Isik", Maas = 5550, Tecrube = 14 };
			Isci isci4 = new Isci { Isim = "Ceku", Soyisim = "Gorali", Maas = 6500, Tecrube = 24 };
			Isci isci5 = new Isci { Isim = "Komutan", Soyisim = "Logar", Maas = 100, Tecrube = 35 };

			List<Isci> isciler = new List<Isci> { isci1, isci2, isci3, isci4, isci5 };

			//isci.MaasIlePromosyon(isciler,5000);
			isci.TecrubeIlePromosyon(isciler,15);
		}

		public class Isci
		{
			public string Isim { get; set; }
			public string Soyisim { get; set; }
			public int Maas { get; set; }
			public int Tecrube { get; set; }


			public void MaasIlePromosyon(List<Isci> isci, int maas)
			{
				foreach (var item in isci)
				{
					if (item.Maas >= maas) { Console.WriteLine("MaasIlePromosyonAlan :" + item.Isim + " " + item.Soyisim); }
				}
			}
			public void TecrubeIlePromosyon(List<Isci> isci, int tecrube)
			{
				foreach (var item in isci)
				{
					if (item.Tecrube >= tecrube) { Console.WriteLine("TecrubeIlePromosyonAlan :" + item.Isim + " " + item.Soyisim); }
				}
			}
		}
	}
}
