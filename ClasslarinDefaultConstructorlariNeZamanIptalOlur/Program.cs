using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClasslarinDefaultConstructorlariNeZamanIptalOlur
{
	internal class Program
	{
		static void Main(string[] args)
		{
			uye uye = new uye();
		}

		//Eger bir classin icersinde hic bir constructor tanimlamasi yapilmazsa o class ile birlikte bir adet default bir constructor tanimlanmis olunuyor.
		//Ne zaman bir parametre alan constructor tanimlarsak o zaman default olan constructor kalkiyor.
		internal class uye
		{
			public string name { get; set; }

			public uye(string name) //Bu sekilde bir ctor tanimlarsak default olan kalkacagi icin main kisminda tanimladigimiz nesne ornegi bir parametre isteyecektir, bunun icin asagida bos, parametresiz bir ctro tanimlamasi yaparsak sorun ortadan kalkar. 
			{
				name = name;
			}

			//CTOR
			public uye() { }
		}
	}
}
