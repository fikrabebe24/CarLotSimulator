using System;
namespace CarLotSimulator
{
	public class Car
	{
		public Car()
		{
		}

        public string Make { get; set; }
		public string Model { get; set; }
		public int Year { get; set; }
		public string EngineNoise { get; set; }
		public string HonkNoise { get; set; }
		public bool IsDriveable { get; set; }

        public Car(string make, string model, int year)
        {

        }

        public string MakeEngineNoise(string noise)
		{
			return "voom";
		}

		public string MakeHonkNoise(string sound)
		{
			return "hoot";
		}

        internal void MakeHonkNoise()
        {
            throw new NotImplementedException();
        }

        internal void MakeEngineNoise()
        {
            throw new NotImplementedException();
        }
    }
}

