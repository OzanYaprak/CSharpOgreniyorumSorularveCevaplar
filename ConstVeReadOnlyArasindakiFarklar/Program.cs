using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConstVeReadOnlyArasindakiFarklar
{
	internal class Program
	{
		static void Main(string[] args)
		{
			Kare kare = new Kare();
            
			Console.WriteLine(kare.KDV);
			Console.ReadKey();
        }

		internal class Kare
		{
			public const double Pi = 3.14; //Ilk olusturuldugunda mutlaka bir deger verilmesi gerekiyor.
			
			public readonly int KDV; //Ilk olusturuldugunda bir deger verilmeyebilinir. //Mutlaka bir nesne ornegi uzerinden erisilmesi gerekiyor.

            public Kare()
            {
                KDV = 18;
            }
        }
	}
}
