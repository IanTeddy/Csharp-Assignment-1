using System;
namespace Csharp_Assignment_1
{
	public class Patient
	{
		private string firstName;
		private string lastName;
		private Double weight;
		private Double height;

		public Patient()
		{
		}

        public double Height { get => height; set => height = value; }
        public double Weight { get => weight; set => weight = value; }
        public string LastName { get => lastName; set => lastName = value; }
        public string FirstName { get => firstName; set => firstName = value; }
    }
}

