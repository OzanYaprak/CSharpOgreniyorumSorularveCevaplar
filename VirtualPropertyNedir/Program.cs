using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VirtualPropertyNedir
{
	//virtual nerelerde kullanılır ?
	//Methodlarda, Propertylerde, Eventlerde ve İndekslerde kullanılır.

	internal class Program
	{
		static void Main(string[] args)
		{
			childClass childClass = new childClass();

			childClass.FirstName = "Ozan";
			childClass.LastName = "Yaprak";

			Console.WriteLine(childClass.FullName);
		}

		public class baseClass
		{
			private string _firstName;
			private string _lastName;

			public string FirstName { get { return _firstName; } set { _firstName = value; } }
			//Yukarıdaki gibi bir yazım yapılabilinir fakat C# 7 den sonra aşağıdaki gibi lambda ile de yazılabilinir, ikiside aynı işlem
			public string LastName { get => _lastName; set => _lastName = value; }

			//virtual yazıldığı için baseClass'ı miras alan bir class'da aşağıdaki property override edilebilinir.
			//get okunabilirlik özelliği dolu 
			public virtual string FullName { get { return _firstName.ToUpper() + " " + _lastName.ToUpper(); } }
		}


		public class childClass : baseClass
		{
			//baseClass içerisinde yazılmış olan property, aşağıda override edildiği için aşağıda yazılmış olan çalışacaktır.
			public override string FullName
			{
				get { return FirstName.Length.ToString() + " " + LastName.Length.ToString(); }
			}
		}
	}
}