using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VirtualMethodNedir
{
	internal class Program
	{
		static void Main(string[] args)
		{
			childClass childClass = new childClass();

			Console.WriteLine(childClass.getProductName("çikolata", "5001"));

		}


		public abstract class baseClass
		{
			public abstract string getProduct(int id);

			public virtual string getProductName(string name, string serialNumber)
			{
				return name + " " + serialNumber;
			}
		}


		public class childClass : baseClass
		{
			public override string getProduct(int id)
			{
				throw new NotImplementedException();
			}

			//Base class içerisinde yazılan method yerine override ettiğimiz için aşağıdaki method çalışacak
			public override string getProductName(string name, string serialNumber)
			{
				return name.ToUpper() + " " + serialNumber.ToUpper();
			}
		}
	}
}
