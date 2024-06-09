using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CastingIslemi
{
	internal class Program
	{
		static void Main(string[] args)
		{
			#region Casting Islemi

			long test = 100;
			int say1 = (int)test; // (int)test Casting Islemi

			//Diger bir Casting yontemi ise asagidaki gibidir.

			int say2 = Convert.ToInt32(test);

			#endregion Casting Islemi
		}
	}
}
