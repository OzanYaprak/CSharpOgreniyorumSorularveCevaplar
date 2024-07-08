using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PartialClasslarinFrklBölümleriFrklInterfacelerImplmntEdeblrMi
{
	public partial class FirstClass : SecondInterface
	{
        public string Name { get; set; }
        public string Surname { get; set; }
        public int Yas { get; set; }



		public int SecondProperty { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }

		void SecondInterface.SecondMethod()
		{
			throw new NotImplementedException();
		}
	}
}
