using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SealedMethodNedir
{
	internal class Program
	{
		//sealed methodlar override edilemeyen methodlar anlamına gelir

		static void Main(string[] args)
		{
		}
	}


	public class baseClass
	{
		public string Name { get; set; }

		public virtual string getName()
		{
			return Name;
		}
	}

	public class firstChildClass : baseClass
	{
		public sealed override string getName() //method burada sealed olarak tanımlandığı için içinde bulunduğu class'ı miras alacak diğer classlar bu methodu ezemeyecek yani override edemeyecekler.
		{
			//return base.getName(); //base keyword miras alınan class'ı temsil eder, burada methodun içini miras aldığı sınıf içerisindeki aynı isimli methodun gövdesiyle dolduruyor.

			return Name.ToUpper();
		}
	}

	public class secondChildClass : firstChildClass
	{
	}
}
