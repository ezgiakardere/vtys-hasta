namespace kıvıl.Entities
{
	public class Test
	{
		public int TestId { get; set; } 
		public int KanBasıcı { get; set; }
		public int Kolestrol { get; set; }
		public int KanSekeri { get; set; }

		// Foreign key
		public int HastaId { get; set; }

		// Navigation property
		public Hasta Hasta { get; set; }


	}
}
