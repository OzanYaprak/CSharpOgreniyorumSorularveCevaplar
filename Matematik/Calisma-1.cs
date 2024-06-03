using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Matematik
{
    public class Islem
    {
        public string PublicErisim { get; set; }
        private string PrivateErisim { get; set; } // Sadece kapsaminda oldugu class icerisinden erisilebilinir.
        internal string InternalErisim { get; set; } // Bulundugu assembly icerisinde erisilebilinir.
    }

    public class Sekil
    {
        protected string ProtectedErisim { get; set; } // Kapsaminda oldugu class icerisinden, miras aldigi class icerisinden ve farkli assembly icerisinden erisilebilinir. ** NESNE ORNEGI UZERINDEN ERISILEMEZ !
		protected internal string ProtectedInternalErisim { get; set; } // Protected kismina ek olarak Protected Internal da nesne ornegi uzerinden erisilebilinir.
																		// Kendi bulundugu assembly projesi icerisinden erisilebilinir, eger farkli bir assembly projesi uzerinden erisilmesini istersek miras alinmasi gerekir.
		private protected string PrivateProtectedErisim { get; set; } // Sadece kendi bulundugu assembly projesi uzerinde erisilebilinir.
    }


	#region ProtectedErisim Ornek
	public class Test : Sekil
    {
        void Protected()
        {
            ProtectedErisim = ProtectedErisim.ToUpper();

			Sekil sekilTest = new Sekil(); //Protected property e yeni nesne ornegi uretildiginde Erisim YAPILAMAZ
		}
	}
	#endregion

	#region ProtectedInternalErisim Ornek
	public class Test2 : Sekil
	{
		void ProtectedInternal()
		{
			ProtectedInternalErisim = ProtectedInternalErisim.ToUpper();

			Sekil sekilTest = new Sekil(); //Protected Internal ile yeni nesne ornegi uretildiginde o property e Erisim YAPILIR
			sekilTest.ProtectedInternalErisim = ProtectedInternalErisim;
		}
	}
	#endregion

	#region PrivateProtectedErisim Ornek
	public class Test3 : Sekil
	{
		void PrivateProtected()
		{
			PrivateProtectedErisim = PrivateProtectedErisim.ToUpper();
			 
			Sekil sekilTest = new Sekil(); //Private Protected property e yeni nesne ornegi uretildiginde Erisim YAPILAMAZ
		}
	}
	#endregion
}
