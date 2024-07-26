using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace KacFarkliOverloadTuruVardir
{
	internal class Program
	{
		// 3 Tur overload vardir ;
		// - Method Overloading
		// - Constructor Overloading
		// - Operator Overloading

		static void Main(string[] args)
		{
			Urun urun = new Urun(3);
			Urun urun_2 = new Urun(3, "Ozan");

			Dikdortgen dikdortgen_1 = new Dikdortgen { Uzunluk = 25 , Yukseklik = 15 };
			Dikdortgen dikdortgen_2 = new Dikdortgen { Uzunluk = 25 , Yukseklik = 15 };

			var consolaYazdirCikartma = dikdortgen_1 - dikdortgen_2;
			var consolaYazdirToplam = dikdortgen_1 + dikdortgen_2;

			Console.WriteLine("Cikartma:" + consolaYazdirCikartma.ToString());
			Console.WriteLine("Toplam:" + consolaYazdirToplam.ToString());

		}
	}

	public class Urun
	{
		public int Id { get; set; }
		public string Isim { get; set; }
		public int Fiyat { get; set; }

		// Constructor Overloading //

		public Urun()
		{

		}

		public Urun(int id)
		{
			this.Id = id;
			this.Isim = null;
			this.Fiyat = 0;
		}

		public Urun(int id, string isim)
		{
			this.Id = id;
			this.Isim = isim;
			this.Fiyat = 0;
		}

		public Urun(int id, string isim, int fiyat)
		{
			this.Id = id;
			this.Isim = isim;
			this.Fiyat = fiyat;
		}
	}

	public class Dikdortgen
	{
		public int Uzunluk { get; set; }
		public int Yukseklik { get; set; }

		public override string ToString()
		{
			return Uzunluk + "," + Yukseklik;
		}

		// Operator Overloading //

		//Cikartma Operatoru
		public static Dikdortgen operator -(Dikdortgen dikdortgen_1, Dikdortgen dikdortgen_2) { return new Dikdortgen { Uzunluk = dikdortgen_1.Uzunluk - dikdortgen_2.Uzunluk, Yukseklik = dikdortgen_1.Yukseklik - dikdortgen_2.Yukseklik }; }
		
		//Toplama Operatoru
		public static Dikdortgen operator +(Dikdortgen dikdortgen_1, Dikdortgen dikdortgen_2) { return new Dikdortgen { Uzunluk = dikdortgen_1.Uzunluk + dikdortgen_2.Uzunluk, Yukseklik = dikdortgen_1.Yukseklik + dikdortgen_2.Yukseklik }; }
	}
}
