using FacadePattern.Entities;

namespace FacadePattern.Services
{
    /// <summary>
    /// WeatherService represent service which responsible for get weather temperature details
    /// </summary>
    public class WeatherService
    {
        /// <summary>
        /// Retrieve the fahrenheit temperature value for given city and state
        /// </summary>
        /// <param name="city">city instance value will get temperature there</param>
        /// <param name="state">state instance value will get temperature there</param>
        /// <returns>fahrenheit temperature value</returns>
        public int GetTempFahrenheit(City city, State state)
        {
            // call to service or db would go here
            
            return 53;
        }
    }
}