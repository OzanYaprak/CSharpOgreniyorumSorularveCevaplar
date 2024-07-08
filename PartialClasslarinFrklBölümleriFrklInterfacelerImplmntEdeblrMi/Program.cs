using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PartialClasslarinFrklBölümleriFrklInterfacelerImplmntEdeblrMi
{
	internal class Program
	{
		//Partial classlar farklı interfaceleri implement edebilir.

		static void Main(string[] args)
		{
			FirstClass firstClass = new FirstClass();

		}
	}

	public interface FirstInterface
	{
		void FirstMethod();
        int FirstProperty { get; set; }
    }

	public interface SecondInterface
	{
		void SecondMethod();
		int SecondProperty { get; set; }
	}
}
