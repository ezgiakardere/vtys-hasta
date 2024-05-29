namespace kıvıl.Entities
{
	public class Hasta
	{
		public int HastaId { get; set; } 
		public string Isim { get; set; }
		public string Soyisim { get; set; }
		public string Cinsiyet { get; set; }
		public int Yas { get; set; }
		public bool EgzersizYapıyorMu { get; set; }
		public bool AileGecmisi { get; set; }
		public bool SigaraKullanımı { get; set; }
		public bool AlkolKullanımı { get; set; }
		public bool KalpKriziRiski { get; set; }

		// Navigation property
		public Test Test { get; set; }



	}
}
