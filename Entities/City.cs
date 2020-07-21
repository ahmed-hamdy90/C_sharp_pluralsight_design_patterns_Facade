namespace FacadePattern.Entities
{
    /// <summary>
    /// City entity class
    /// </summary>
    public class City
    {
        public string Name => "Redmond";
        
        /// <summary>
        /// Getting a city details using given zip code
        /// </summary>
        /// <param name="zipCode">zip code value will be search for city</param>
        /// <returns>full city info instance</returns>
        public City GetCityForZipCode(string zipCode)
        {
            // service or db lookup would go here
            return new City();
        }
    }
}