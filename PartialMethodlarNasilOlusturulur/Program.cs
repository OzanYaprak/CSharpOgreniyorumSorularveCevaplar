using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PartialMethodlarNasilOlusturulur
{
	internal class Program
	{
		//Partial Metotlar Geriye Herhangi Bir Değer Dönemez, Void Olmak Zorundalar.
		//Partial Metotlar Kapalı Bir Şekilde Private Metot Olduklarından Dolayı Ezilemezler ve Sadece Bulundukları Class İçerisinde Kullanılırlar, Harhngi Bir Nesne Örneği Üzerinden Erişemeyiz.
		//Partial Metotlar Bir Erişim Belirleyicisine Sahip Değillerdir.

		static void Main(string[] args)
		{
			Product product = new Product();

			product.Calistir();
		}

		partial class Product
		{
			//Partial Class İçerisinde Bir Partial Metot Olmalı
			partial void FirstMethod(string value);
		}
		partial class Product
		{
			public void Calistir()
			{
				FirstMethod("OzanYaprak"); //Partial Metot, Kendi bulunduğu class içerisinde çağırılır.
			}


			partial void FirstMethod(string value)
			{
                Console.WriteLine(value);
            }
		}
	}
}
