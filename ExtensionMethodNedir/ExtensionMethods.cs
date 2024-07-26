using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExtensionMethodNedir
{
	public static class ExtensionMethods // Extension Methodlar Static Olmak Zorunda
	{
		public static bool CiftMi(this int sayi)
		{
			return sayi % 2 == 0;
		}
	}
}

