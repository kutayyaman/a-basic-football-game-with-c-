using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp33
{
	class Defans:Futbolcu
	{
		public int PozisyonAlma { get; set; }
		public int Kafa { get; set; }
		public int Sicrama { get; set; }
		public Defans(string AdSoyad,int FormaNo):base(AdSoyad,FormaNo)
		{
			PozisyonAlma = RastgeleSayiUret.Uret(50, 90);
            Kafa = RastgeleSayiUret.Uret(50, 90);
            Sicrama = RastgeleSayiUret.Uret(50, 90);

        }
		public override bool PasVer()
		{
			double PasSkor;
			PasSkor = Pas * 0.3 + Yetenek * 0.3 + Dayaniklik * 0.1 +DogalForm * 0.1 + PozisyonAlma * 0.1 + Sans * 0.2;
			if (PasSkor > 60)
				return true;
			else
				return false;
		}
		public override bool GolVurusu()
		{
			double GolSkor;
			GolSkor = Yetenek * 0.3 + Sut * 0.2 + Kararlilik * 0.1 + DogalForm * 0.1 + Kafa * 0.1 + Sicrama * 0.1 + Sans * 0.1;

			if (GolSkor > 70)
				return true;
			else
				return false;
		}
	}
}
