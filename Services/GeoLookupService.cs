using FacadePattern.Entities;

namespace FacadePattern.Services
{
    /// <summary>
    /// GeoLookupService represent service which responsible for getting GEO locations 
    /// </summary>
    public class GeoLookupService
    {
        /// <summary>
        /// Getting a city details using given zip code
        /// </summary>
        /// <param name="zipCode">zip code value will be search for city</param>
        /// <returns>full city info instance</returns>
        public City GetCityForZipCode(string zipCode)
        {
            return new City();
        }
        
        /// <summary>
        /// Getting a state details using given zip code
        /// </summary>
        /// <param name="zipCode">zip code value will be search for state</param>
        /// <returns>full state info instance</returns>
        public State GetStateForZipCode(string zipCode)
        {
            return new State();
        }
    }
}