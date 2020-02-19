using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp33
{
	class Futbolcu
	{
		public string AdSoyad { get; set; }
		public int FormaNo { get; set; }
		public int Hiz { get; set; }
		public int Dayaniklik { get; set; }
		public int Pas { get; set; }
		public int Sut { get; set; }
		public int Yetenek { get; set; }
		public int Kararlilik { get; set; }
		public int DogalForm { get; set; }
		public int Sans { get; set; }

		public Futbolcu(string AdSoyad,int FormaNo)
		{
			this.AdSoyad = AdSoyad;
			this.FormaNo = FormaNo;
			Hiz = RastgeleSayiUret.Uret(50, 100);
            Dayaniklik = RastgeleSayiUret.Uret(50, 100);
            Pas = RastgeleSayiUret.Uret(50, 100);
            Sut = RastgeleSayiUret.Uret(50, 100);
            Yetenek = RastgeleSayiUret.Uret(50, 100);
            Kararlilik = RastgeleSayiUret.Uret(50, 100);
            DogalForm = RastgeleSayiUret.Uret(50, 100);
            Sans = RastgeleSayiUret.Uret(50, 100);
        }
		public virtual bool PasVer()
		{
			double PasSkor;
			PasSkor = Pas * 0.3 + Yetenek * 0.3 + Dayaniklik * 0.1 + DogalForm * 0.1 + Sans * 0.2;
			if (PasSkor > 60)
				return true;
			else
				return false;
		}
		public virtual bool GolVurusu()
		{
			double GolSkor;
			GolSkor = Yetenek * 0.3 + Sut * 0.2 + Kararlilik * 0.1 + DogalForm * 0.1 +Hiz * 0.1 + Sans * 0.2;

			if (GolSkor > 70)
				return true;
			else
				return false;
		}
	}
}
