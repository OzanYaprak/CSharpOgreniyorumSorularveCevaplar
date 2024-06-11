using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassIleStructArasindakiFarklarNelerdir
{
	internal class Program
	{
		static void Main(string[] args)
		{
			//CLASS miras alinabilir, classlar referans tiplidir. Datalar Bellegin Heap bolgesinde tutulur, bellegin stack bolgesinde ise bu heap bolgesindeki yerini isaret eden pointerlar bulunuyor.
			//STRUCT miras Alinamaz, structlar value tiplidir. Bellegin stack bolgesinde tutuldugu icin her zaman kopyalari olusur. // Stracklar bellegin stack bolgesinde tutuldugu icin daha az maliyetlidir, dataya ulasmak daha hizlidir.

			uyeClass uyeClass = new uyeClass();
			uyeStruct uyeStruct = new uyeStruct(20);
		}


		//Miras alinabilinir.
		//Classlar Referans tipdir
		class uyeClass 
		{
			private string deger;
            public uyeClass()
            {
				deger = "Ozan";
            }
        }

		//Miras alinamaz.
		//Struct value tipdir.
		struct uyeStruct
		{
            public int yas { get; set; }
            public uyeStruct(int yas2) //struct icerisinde constructor metotlar mutlaka parametre almalidir.
			{
                yas = yas2;
            }
        }
	}
}
