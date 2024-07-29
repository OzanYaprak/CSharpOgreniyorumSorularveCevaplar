using System;
using System.Collections.Generic;
using System.Diagnostics.SymbolStore;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TemelOOPConceptleriNelerdir
{
	// Encapsulation : Capsulleme
	// Abstraction : Soyutlama
	// Polymorphism : Cok cesitlilik
	// Inheritance : Miras

	internal class Program
	{
		static void Main(string[] args)
		{
			Kisi kisi = new Kisi();
			kisi.Ekle("Ozan","Yaprak");
		}
	}

	// Abstraction : Asagidaki siniflarda public olani sadece kullanici gorebiliyor, diger private olanlarda da islemler yapiliyor fakat bunlari kullanicilara gostermiyoruz. Bu kullanima Abstraction yani Soyutlama deniliyor.
	// Encapsulation : Tek bir method icerisinde diger methodlarin cagrilmasina Encapsulation deniliyor.

	public class Kisi
	{
		public bool Ekle(string isim, string soyisim) 
		{
			if (DogrulamaIslemi(isim,soyisim) == true)
			{
				VeritabaninaEklemeIslemi(isim, soyisim);
				return true;
			}

			return false; 
		}

		private bool DogrulamaIslemi(string isim, string soyisim) 
		{ 
			// Kisi veritabaninda varmi yokmu kontrolu gerceklestirdim.
			return true; 
		}

		private bool VeritabaninaEklemeIslemi (string isim, string soyisim)
		{
			// Kisi varitabanina kayit edilir.
			return true;
		}
	}
}
