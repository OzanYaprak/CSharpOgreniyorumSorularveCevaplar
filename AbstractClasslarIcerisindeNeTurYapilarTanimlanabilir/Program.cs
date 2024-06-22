using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractClasslarIcerisindeNeTurYapilarTanimlanabilir
{
	internal class Program
	{
		static void Main(string[] args)
		{
			ChildClass childClass = new ChildClass();

			BaseClass._ucret = 1000;

			childClass.UcretiYaz();
		}


		public abstract class BaseClass
		{
			public static int _ucret; //Bir soyut sinifin static uyelerine (bunlar field olabilir, property olabilir, method olabilir) yukarida gozuktugu gibi direkt soyut sinif uzerinden erisilebilinir, fakat static olmayan hicbir uyesine erisilemez.

			public string _yas; //Field

			public string Ad { get; set; } //Property

			public void GovdeliMethod() { Console.WriteLine("Govdeli Method Calisti"); } //Ici Burada doldurulur, miras alinan class uzerinden yeni nesne ornegi olusturuldugunda erisilebilinir/kullanilabilinir.

			public abstract void GovdesizMethod(); //Ici Implement edildigi class icerisinde doldurulur.



			public void UcretiYaz() { Console.WriteLine("Ucret:" + _ucret); }
		}


		public class ChildClass : BaseClass
		{
			public override void GovdesizMethod()
			{
				throw new NotImplementedException();
			}
		}
	}
}
