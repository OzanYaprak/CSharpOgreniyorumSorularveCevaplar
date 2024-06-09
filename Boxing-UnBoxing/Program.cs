using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Boxing_UnBoxing
{
	internal class Program
	{
		static void Main(string[] args)
		{
			#region Boxing/UnBoxing

			#region Boxing Islemi

			//Boxing islemi value type bir degiskenden referans type bir degiskene tip donusumu yapilmasina denilir.

			int deger = 100; // Value Type Degisken => Byte,Int,Long,Decimal..
			object deger2 = deger; // Object Referance Type bir degiskendir.

			#endregion Boxing Islemi

			#region UnBoxing Islemi

			object deger3 = 100;

			int deger4 = (int)deger3; // (int) Buna Cast Islemi Deniliyor.

			#endregion UnBoxing Islemi

			#endregion Boxing/UnBoxing
		}
	}
}
