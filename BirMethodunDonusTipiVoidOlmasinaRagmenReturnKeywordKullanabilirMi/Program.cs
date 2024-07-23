using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BirMethodunDonusTipiVoidOlmasinaRagmenReturnKeywordKullanabilirMi
{
	internal class Program
	{
		//Return ifadesi sadece bir data donmek icin kullanilmaz ayni zamanda o methodu durdurmak icinde kullanilabilinir.
		static void Main(string[] args)
		{
			Program program = new Program();

			program.OrnekMetot();
		}

		public void OrnekMetot()
		{
			Console.WriteLine("Return oncesi");

			return; //Burada methodu durdurduk.

			Console.WriteLine("Return sonrasi"); //Burasi calismayacak 
		}
	}
}
