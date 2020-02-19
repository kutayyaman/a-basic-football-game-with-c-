using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp33
{
	class Forvet:Futbolcu
	{
		public int Bitiricilik { get; set; }
		public int IlkDokunus { get; set; }
		public int Kafa { get; set; }
		public int OzelYetenek { get; set; }
		public int SogukKanlilik { get; set; }
		public Forvet(string AdSoyad,int FormaNo):base(AdSoyad,FormaNo)
		{
            Bitiricilik = RastgeleSayiUret.Uret(70, 100);
			IlkDokunus = RastgeleSayiUret.Uret(70, 100);
            Kafa = RastgeleSayiUret.Uret(70, 100);
            OzelYetenek = RastgeleSayiUret.Uret(70, 100);
            SogukKanlilik = RastgeleSayiUret.Uret(70, 100);

        }
		public override bool PasVer()
		{
			double PasSkor;
			PasSkor = Pas * 0.3 + Yetenek * 0.2 + OzelYetenek * 0.2 + Dayaniklik * 0.1 + DogalForm * 0.1 + Sans * 0.1;
			if (PasSkor > 60)
				return true;
			else
				return false;
		}
		public override bool GolVurusu()
		{
			double GolSkor;
			GolSkor = Yetenek * 0.2 + OzelYetenek * 0.2 + Sut * 0.1 + Kafa * 0.1 + IlkDokunus * 0.1 + Bitiricilik * 0.1 + SogukKanlilik * 0.1 + Kararlilik * 0.1 + DogalForm * 0.1 + Sans * 0.1; 

			if (GolSkor > 70)
				return true;
			else
				return false;
		}
	}
}
