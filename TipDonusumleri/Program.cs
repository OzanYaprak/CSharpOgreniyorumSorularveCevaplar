namespace TipDonusumleri
{
	internal class Program
	{
		private static void Main(string[] args)
		{
			#region Tip Donusumleri

			#region Implicit Type (Kapali tip donusumu)

			int sayi = 100;
			long sayi2 = sayi; //Long, int dan daha yuksek seviyede bir veri tipidir.

			#endregion Implicit Type (Kapali tip donusumu)

			#region Explicit Type (Acik tip donusumu)

			long sayi3 = 500;
			//int sayi4 = sayi3;

			//Eger yukaridaki sekilde yaparsak hata aliriz, cunku int veri tipi long veri tipinden daha dusuk seviyededir.
			//Bu yuzden asagidaki gibi kullanim daha dogru olur.

			int sayi4 = (int)sayi3;

			//Fakat

			byte sayi5 = (byte)sayi3; //Bu sekilde kullanimda bir veri kaybi olabilir, cunku byte veri tipi -255 ile +255 arasinda bir deger alabilir fakat biz burada 500 gonderiyoruz.

			#endregion Explicit Type (Acik tip donusumu)

			#endregion Tip Donusumleri
		}
	}
}