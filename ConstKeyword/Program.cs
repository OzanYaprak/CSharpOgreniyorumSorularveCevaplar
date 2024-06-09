using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConstKeyword
{
	internal class Program
	{
		static void Main(string[] args)
		{
			//const keyword bir degerin hem compile zamaninda hemde runtime zamaninda degerin degistirilememesini saglar.
			//CLASS,STRUCT,ARRAY,METHOD VE PROPERTYLERE CONST KEYWORD UYGULAMASI YAPILAMAZ !!

		}

		internal class kare
		{
			public const double PiDegeri = 3.14; //Mutlaka bir deger atamasi yapmamiz gerekmekte.
			public const string Isim = "Ozan";
			public const int Yas = 33;
			public const bool Evli = false;

			//Yukarida yazilmis olan degiskenlerin hic bir tanesi const keywordunden dolayi baska bir yerde degistirilemez.
		}
	}
}
