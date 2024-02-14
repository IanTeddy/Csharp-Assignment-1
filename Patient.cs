namespace Csharp_Assignment_1
{
    public class Patient
	{
        // instance variables
		private string firstName;
		private string lastName;
        private double weight;
        private double height;

        // constructor
		public Patient(string firstName, string lastName, double weight, double height)
		{
            this.firstName = firstName;
            this.lastName = lastName;
            this.weight = weight;
            this.height = height;
		}

        // Properties with getter and setter 
        public string FirstName { get => firstName; set => firstName = value; }
        public string LastName { get => lastName; set => lastName = value; }
        public double Weight { get => weight; set => weight = value; }
        public double Height { get => height; set => height = value; }


        // a method to calculate the blood pressure of the patient
        public string CalBloodPressure(int systolic, int diastolic) {
            string result;

            if(systolic < 120 && diastolic < 80) {
                result = "NORMAL";
            } else if(systolic < 130 && diastolic < 80) {
                result = "ELEVATED";
            } else if(systolic < 140 || diastolic < 90) {
                result = "HIGH BLOOD PRESSURE (HYPERTENSION) STAGE 1";
            } else if(systolic > 180 || diastolic > 120) {
                result = "HYPERTENSIVE CRISIS (consult your doctor immediately)";
            } else if(systolic >= 140 || diastolic >= 90) {
                result = "HIGH BLOOD PRESSURE (HYPERTENSION) STAGE 2";
            } else {
                result = "Please enter valid value.";
            }
            return result;
        }

        // a method to calculate BMI
        public double CalculateBMI(double weight, double height) {
            // formula is BMI = kg/m x m
            double heighInMeter = height / 100;
            return weight / (heighInMeter * heighInMeter);
        }


        // a method to print patient info
        public void PrintInfo(int systolic, int diastolic) {
            Console.WriteLine($"Full Name: {firstName} {lastName} " +
                $"\nWeight: {weight} " +
                $"\nHight:{height}" +
                $"\nBlood Pressuer: {CalBloodPressure(systolic, diastolic)}" +
                $"\nBMI: {CalculateBMI(weight, height)}");

            if(CalculateBMI(weight, height) >= 25.0) {
                Console.WriteLine("Overweight");
            } else if(CalculateBMI(weight, height) >= 18.5) {
                Console.WriteLine("Normal (In the healthy range)");
            } else {
                Console.WriteLine("Underweight");
            }

        }

        public static int CalculateAge(int year) {
            int age = 2023 - year;
            return age;
        }

    }

}

