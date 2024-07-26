using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MethodOverloadNedir
{
	internal class Program
	{
		// Method imzasi : metotun ismi, metotun almis oldugu parametlerin sayisi ve parametrelerin turu o metotun imzasi olur.
		// Bir metot imzasi demek o metotu diger metotlardan ayiran ozelliklere denir.

		static void Main(string[] args)
		{
            Console.WriteLine(OrnekClass.Topla("ozan","yaprak"));
            Console.WriteLine(OrnekClass.Topla(4,9));
            Console.WriteLine(OrnekClass.Topla(4,9,11));
        }
	}

	public static class OrnekClass
	{
		public static int Topla(int a, int b)
		{
			return a + b;
		}

		public static string Topla(string isim, string soyisim)
		{
			return isim + " " + soyisim;
		}

		public static int Topla(int a, int b, int c)
		{
			return a + b + c;
		}
	}
}
