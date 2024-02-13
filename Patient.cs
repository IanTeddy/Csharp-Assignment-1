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
                result = "NORMALLLLLL";
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

    }

}

