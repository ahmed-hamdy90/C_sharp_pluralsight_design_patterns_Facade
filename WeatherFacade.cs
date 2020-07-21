using FacadePattern.Entities;
using FacadePattern.Services;

namespace FacadePattern
{
    /// <summary>
    /// WeatherFacade represent solution of get the current temperature for given location by zip code value
    /// which rely on multi-dependencies applying Facade design pattern 
    /// </summary>
    public class WeatherFacade : IWeatherFacade
    {
        private readonly ConverterService _converterService;
        private readonly GeoLookupService _geoLookupService;
        private readonly WeatherService _weatherService;

        /// <summary>
        /// WeatherFacade constructor,
        /// empty constructor depend on another constructor with internal initial instances which need
        /// this pattern called Inversion of Control pattern
        /// </summary>
        public WeatherFacade() : this(new ConverterService(), new GeoLookupService(), new WeatherService())
        {
            
        }

        /// <summary>
        /// WeatherFacade constructor
        /// </summary>
        /// <param name="converterService">convert service instance</param>
        /// <param name="geoLookupService">geo service instance</param>
        /// <param name="weatherService">weather service instance</param>
        public WeatherFacade(ConverterService converterService, GeoLookupService geoLookupService,
            WeatherService weatherService)
        {
            _converterService = converterService;
            _geoLookupService = geoLookupService;
            _weatherService = weatherService;
        }
        
        /// <inheritdoc cref="IWeatherFacade.GetTempInCity"/>
        public WeatherFacadeResults GetTempInCity(string zipCode)
        {
            // call service 1
            City city = _geoLookupService.GetCityForZipCode(zipCode);
            State state = _geoLookupService.GetStateForZipCode(zipCode);
            
            // call service 2
            int fahrenheit = _weatherService.GetTempFahrenheit(city, state);
            
            // call service 3
            int celsius = _converterService.ConvertFahrenheitToCelsius(fahrenheit);
            
            // create temperature result
            var result = new WeatherFacadeResults()
            {
                City = city,
                State = state,
                Fahrenheit = fahrenheit,
                Celsius = celsius
            };

            return result;
        }
    }
}