namespace Csharp_Assignment_1
{
    internal class Patient
	{
		private string firstName;
		private string lastName;
        private double weight;
        private double height;

		public Patient()
		{
		}

        public string FirstName { get => firstName; set => firstName = value; }
        public string LastName { get => lastName; set => lastName = value; }
        public double Weight { get => weight; set => weight = value; }
        public double Height { get => height; set => height = value; }
    }

}

