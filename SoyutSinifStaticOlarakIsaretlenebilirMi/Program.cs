using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SoyutSinifStaticOlarakIsaretlenebilirMi
{
	internal class Program
	{
		//Bir soyut sinif static olarak isaretlenemez ama soyut siniflar (Abstract) static uyelere sahip olabilirler.
		//Field, Property, Method vb.
		static void Main(string[] args)
		{
			BaseClass._ucret = 300;
			BaseClass.UcretYaz();
		}

		public abstract class BaseClass
		{
			public static int _ucret; //Static bir methodda kullanilacaksa, buradaki field da static olmak zorunda.

			public static void UcretYaz() { Console.WriteLine("Ucret:" + " " + _ucret); }
		}

		public class ChildClass : BaseClass
		{

		}
	}
}
