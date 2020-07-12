using System;
using FacadePattern.Entities;
using FacadePattern.Services;

namespace FacadePattern
{
    class Program
    {
        static void Main(string[] args)
        {
            // As see this problem of multi-dependencies to apply one operation
            // get the current temperature for given location by zip code value
            const string zipCode = "98074"; 
                
            // call service 1
            GeoLookupService geoLookupService = new GeoLookupService();
            City city = geoLookupService.GetCityForZipCode(zipCode);
            State state = geoLookupService.GetStateForZipCode(zipCode);
            
            // call service 2
            WeatherService weatherService = new WeatherService();
            int fahrenheit = weatherService.GetTempFahrenheit(city, state);
            
            // call service 3
            ConverterService metricConverter = new ConverterService();
            int celsius = metricConverter.ConvertFahrenheitToCelsius(fahrenheit);
            
            Console.WriteLine("The current temperature is {0} F / {1} C in {2}, {3}",
                fahrenheit, celsius, city.Name, state.Name);
        }
    }
}
