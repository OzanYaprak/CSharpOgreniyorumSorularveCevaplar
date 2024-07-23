using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UsingIfadesiNeIcinKullanilir
{
	internal class Program
	{
		//Projede olusturdugumuz nesnelerin bellekten ne zaman silinecegine karar veren yapi Garbage Collector'dur. //Garbage Collector bir nesnenin kullanilmadigi tahmin ettigi anda o nesneyi arka planda bellekten siler.
		//Buyuk capli projelerde olusturdugumuz nesnenin garbage collector'a gitmeden kendimiz silmemiz gerektigi durumlar olabilir, bu durumlarda asagidaki ornekteki gibi kullanim yapilabilinir.

		//Using ifadesi icerisinde kullanilacak nesneler mutlaka IDisposible interface ni implement etmek zorunda.

		static void Main(string[] args)
		{
			using (SqlConnection sqlConnection = new SqlConnection())
			{
				sqlConnection.Open();
			}
			using (StreamReader streamReader = new StreamReader("/path"))
			{

			}
			//Burada olusturdugumuz nesne ornegi sadece belirtilmis olan suslu parantezler icerisinde kullanim yapilabilinir, suslu parantezler disina gecildiginde olusturulmus olan nesne ornegi bellek uzerinden silinecektir.
		}
	}
}
