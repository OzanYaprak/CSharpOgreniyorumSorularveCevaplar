using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CsharpBirdenFazlaSinifiMirasAlmayiDesteklerMi
{
	internal class Program
	{
		static void Main(string[] args)
		{
			//C# da bir sinif birden fazla sinifi mmiras alamaz sadece tek bir sinifi miras alabilir.
			//Fakat birden fazla interface i miras alabilir !
		}

		private class childClassOne: MainOne, MainTwo
		{

		}
		private class childClassTwo : BaseClassOne/*BaseClassTwo*/ //Bu BaseClassTwo miras alinamaz !
		{

		}
		private class childClassThree : BaseClassOne,MainOne,MainTwo //Birden fazla interface alabilir
		{

		}


		interface MainOne { }
		interface MainTwo { }

		class BaseClassOne { }
		class BaseClassTwo { }
	}
}
