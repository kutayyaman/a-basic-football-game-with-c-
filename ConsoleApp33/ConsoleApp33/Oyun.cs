using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace ConsoleApp33
{
	class Oyun
	{
		private List<Futbolcu> takim = new List<Futbolcu>();

		public Oyun()
		{
			takim.Add(new Defans("Burak Cicek", 2));
			takim.Add(new Defans("Tayyip Unuttum",3));
			takim.Add(new Defans("Bilal Unuttum", 4));
			takim.Add(new Defans("Batuhan Ozturk", 5));
			takim.Add(new OrtaSaha("Eren Erciyas", 6));
			takim.Add(new OrtaSaha("Batuhan Gokalp", 7));
			takim.Add(new OrtaSaha("Esat Genc", 8));
			takim.Add(new Forvet("Kutay Yaman", 9));
			takim.Add(new OrtaSaha("Oyuncu10 Oyuncu10", 10));
			takim.Add(new Forvet("Oyuncu11 Oyuncu11", 11));
		}
		public void OyunuBaslat()
		{
			
			int formaNo;
			int kontrol;
			Boolean golOlabilir = true;
			formaNo = RastgeleSayiUret.Uret(2, 11);
            kontrol = formaNo;
			Console.WriteLine("Rastgele Olarak " + formaNo + " numarali " +takim[formaNo-2].AdSoyad + " secildi");
			Console.WriteLine();
			for (int i=0;i<3;i++) //3 kere paslasma olacagı icin 3 kere dönen for 
			{
				
				if(takim[formaNo-2].PasVer()==false) //formaNo-2 yapıyorum çünkü diziler 0dan başlıyor ama benim futbolcuların numarası 2'den baslayarak atandı
				{
					Thread.Sleep(1000); //sonuc ekrana 1 saniye gecikmeli cıksın diye yaptım direkt gelmesini istemiyorum
					Console.WriteLine("" + formaNo + " Numarali " + takim[formaNo - 2].AdSoyad + " isimli oyuncu icin PasVer metodu cagrildi ama basarisiz pas");
					Console.WriteLine();
					golOlabilir = false;
					break;
				}
				else
				{
					Thread.Sleep(1000);
					Console.WriteLine("" + formaNo + " Numarali " + takim[formaNo - 2].AdSoyad + " isimli oyuncu icin PasVer metodu cagrildi ve basarili ");
					Console.WriteLine();
				}

				kontrol = formaNo;
				formaNo = RastgeleSayiUret.Uret(2, 11);
                while (formaNo==kontrol) //tekrardan pas atılmadan önce bir futbolcu kendine pas atamayacagı icin burda onu kontrol ediyorum
				{
					formaNo = RastgeleSayiUret.Uret(2, 11); ; // eğer rastgele secilen futbolcu yine aynıysa tekrardan rastgele futbolcu seciyor.
				}
				Thread.Sleep(1000);
				Console.Write("Pasi " + formaNo + " numarali " + takim[formaNo - 2].AdSoyad + " isimli oyuncuya atti ");
				Console.WriteLine();
			}
			if(golOlabilir)//hatali pas yapıldıysa buraya girilmeyecek
			{
				
				Boolean golMu=takim[formaNo - 2].GolVurusu();
				if(golMu)
				{
					Thread.Sleep(1000);
					Console.WriteLine("GOL DENEMESI!!! GOOOOOOL GOLU ATAN OYUNCU " + takim[formaNo - 2].FormaNo + " numarali oyuncu olan " + takim[formaNo - 2].AdSoyad);
					Console.WriteLine();
				}
				else
				{
					Thread.Sleep(1000);
					Console.WriteLine("GOL DENEMESI YAPILDI ANCAK GOL VURUSU BASARISIZ GOLU KACIRAN OYUNCU " + takim[formaNo - 2].FormaNo + "numarali oyuncu olan " + takim[formaNo - 2].AdSoyad);
					Console.WriteLine();
				}
			}
			
		}
	}
}
