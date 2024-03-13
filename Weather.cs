using System;
namespace hydac_customer
{
	public class Weather
	{
		public float Temperature;
		public float Humidity;
		public float Precipitation;
		public DateTime MeasurementDate;

		public Weather(float Temperature, float Humidity, float Precipitation, DateTime MeasurementDat)
		{
			Temperature = Temperature;
			Humidity = Humidity;
			Precipitation = Precipitation;
			MeasurementDate = MeasurementDate;
		}
		public float GetTemperature()
		{
			return Temperature;
		}
		public void SetTemperature(float NewTemperature)
		{
			Temperature = NewTemperature;
		}

		public float GetHumidity()
		{
			return Humidity;
		}
		public void SetHumidity(float NewHumdity)
		{
			Humidity = NewHumdity;
		}

		public float GetPrecipitation()
		{
			return Precipitation;
		}
		public void SetPrecipitation(float NewPrecipitation)
		{
			Precipitation = NewPrecipitation;
		}

	}
}

