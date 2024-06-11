using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NestedTypeNedir
{
	internal class Program
	{
		static void Main(string[] args)
		{
			//Nested type ic ice tipler olarak cevrilebilinir, ornegin bir class in icerisinde bir class tanimlarsak, bu class in icersinde tanimladigimiz class nested type bir class oluyor.

			//Nested classtan bir nesne ornegi alma islemi asagidaki gibidir ;
			uye.editor editor = new uye.editor();
		}

		internal class uye
		{
            public string name { get; set; }

            public class editor // Bu nested class 
			{
                public string editorName { get; set; }
            }
		}
	}
}
