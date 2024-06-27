using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SealedClassNedir
{
	internal class Program
	{
		//Sealed classlar miras alınamayan classlar anlamına gelir.

		static void Main(string[] args)
		{
		}
	}


	public sealed class baseClass
	{
		public string Name()
		{
			return "ozan";
		}
	}


	public class chidlClass : baseClass // baseClass sealed keyword sahibi olduğu için miras alınamaz
	{

	}

}
