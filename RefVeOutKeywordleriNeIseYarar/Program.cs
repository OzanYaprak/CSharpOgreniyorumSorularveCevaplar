using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RefVeOutKeywordleriNeIseYarar
{
	internal class Program
	{
		// Out : Bir method içerisinde birden fazla değer dönebilmeyi sağlar
		// Ref : Value type (int, double, decimal vb) değişken tiplerinin referans type gibi davranmasını sağlıyor.

		// Value typelar (int, double, decimal vb) ram stack bölgesinde tutulur, Bu tür veriler fonksiyonlar çağrıldığında yaratılır ve fonksiyon bittiğinde bellekten otomatik olarak temizlenir.
		// Reference types örnek olarak sınıflar (classes), diziler (arrays), ve delegeler (delegates) belleğinde (heap) tutulur ve stack bölgesinde de pointerları olur. Heap belleği, daha büyük ve uzun ömürlü verilerin saklanması için kullanılır. 
		// Heap'teki bellek yönetimi, .NET'in çöp toplayıcısı (garbage collector) tarafından otomatik olarak yapılır, bu da artık kullanılmayan nesnelerin bellekten temizlenmesini sağlar.

		static void Main(string[] args)
		{
			Program program = new Program();

			int carpim;
			int cikartma;

			int islem = program.Islem(4, 5, out carpim, out cikartma);

			Console.WriteLine(islem);
			Console.WriteLine(carpim);
			Console.WriteLine(cikartma);


			//////// REF ////////

			int a = 10;

            Console.WriteLine("a değişkeninin değeri : " + " " + a);

			program.getData(ref a);

			Console.WriteLine("Method çalıştıktan sonra a değişkeninin değeri : " + " " + a);
		}

		public int Islem(int a, int b, out int carpim, out int cikartma)
		{
			cikartma = a - b;
			carpim = a * b;

			return a + b;
		}


		public void getData(ref int a) // ref ile belleğin heap bölgesinde tutulmasını sağlıyoruz.
		{
			a = a + 10;
		}
	}
}
