using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PartialStructInterfaceMethodOlusturmakMumkunMu
{
	public class BaseClass : IOrnek //IOrnek Interface'i iki ayrı class içerisinde partial olarak bölünmüş olup, her bölündüğü class içerisinde bir adet method yazılmıştır.
	{
		//Implement ettiğimizde 2 ayrı class içerisinde tanımlanan metotlar buraya gelir.
		public void Ornek1()
		{
			throw new NotImplementedException();
		}

		public void Ornek2()
		{
			throw new NotImplementedException();
		}
	}
}
