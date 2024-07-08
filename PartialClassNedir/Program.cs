using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PartialClassNedir
{
	internal class Program
	{
		//Partial class, bir class nesnesinin iki veya daha fazla parçaya bölünmesine denir.

		//Örnek olarak ; Bir classımız bulunuyor ve bu class içerisinde yüzlerce property var ve yine aynı class içerisinde örneğin 70-80 tane metotumuz var, bu kod karmaşıklığını azaltmak için Partial class kullanılabilinir.
		//Bu şekilde yaparak bir class ta metotları tutabilir, diğer class ta ise propertyleri tutabiliriz.
		//Bu iki ayrı classın isimleri aynı olur ve ikiside partial keyword kullanır.
		//İki ayrı class compile(derleme) zamanında tekrar otomatik olarak bir araya getirilir.

		static void Main(string[] args)
		{
			FirstClass firstClass = new FirstClass();

            Console.WriteLine(firstClass.SecondMethod());

            Console.WriteLine(firstClass.Surname);
        }
	}
}
