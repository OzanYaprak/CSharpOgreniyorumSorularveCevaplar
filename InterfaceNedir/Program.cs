using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceNedir
{
	internal class Program
	{
		static void Main(string[] args)
		{
			//Interfaceler Classlara klavuzluk eden yapilardir, hangi yeteneklere sahip olacagini belirleyen yapilardir.

			Urun urun = new Urun();
		}

		public class Urun : IDataIslem
		{
			//PROPERTY
			public int getItem { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }

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

			//Ekstra implement ettigimiz interface den haric olarak buraya yine kendimi yeni methodlar yazabiliriz.

			public List<string> Urunler()
			{
				throw new NotImplementedException();
			}
		}

		public class Kirtasiye : IDataIslem
		{
			//PROPERTY
			public int getItem { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }

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
		}



		//Bir interface icerisinde sadece method ve property tanimlayabiliriz
		//Interface icerisinde tanimlanan methodlarda bir erisim belirleryici bulunmaz, sadece methodun ismi, donus tipi ve alacagi bir parametre var ise tanimlanir.
		interface IDataIslem
		{
			//string name; //Interfaceler field alanlar iceremez !


			void Ekle(string veri);
			void Sil(string id);
			string Guncelle(string id);
			string Detay(string id);

			//Property Tanimlama
			int getItem { get; set; }
		}
	}
}
