using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ContinueIleBreakKeywordleriArasindakiFarkNedir
{
	internal class Program
	{
		// continue ve break keywordleri daha cok for dongulerinde kullanilir.
		static void Main(string[] args)
		{
			for (int i = 0; i < 20; i++) 
			{
				if (i == 10) { break; } // burada donguden cikiliyor
				if (i == 10) { continue; } // burada ise donguden cikilmiyor, sadece i 10 a esit oldugunda ekrana yazdirilmiyor ve diger islemler devam ediyor.

                Console.WriteLine(i);
            }
		}
	}
}
