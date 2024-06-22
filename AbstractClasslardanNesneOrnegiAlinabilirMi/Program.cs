using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractClasslardanNesneOrnegiAlinabilirMi
{
	internal class Program
	{
		//Soyut siniflardan nesne ornegi alinamaz fakat soyut yani abstract siniflardan baska classlara miras alinabilinir.
		//Bu miras alinan sinif uzerinden yeni bir nesne ornegi olusturulabilinir.
		static void Main(string[] args)
		{
			//TestSinif testSinif = new TestSinif(); //NESNE ORNEGI ALINAMAZ !

			Test test = new Test();

			test.Run();
		}

		abstract class TestSinif
		{
			public abstract void Run(); //Gozdesiz method
		}

		class Test : TestSinif
		{
			public override void Run()
			{
                Console.WriteLine("Method Calistirildi");
            }
		}
	}
}
