namespace FacadePattern
{
    /// <summary>
    /// IWeatherFacade interface
    /// </summary>
    public interface IWeatherFacade
    {
        /// <summary>
        /// Retrieve the temperature result for the city which xip code belong to
        /// </summary>
        /// <param name="zipCode">zip code value for city</param>
        /// <returns>the current temperature result</returns>
        WeatherFacadeResults GetTempInCity(string zipCode);
    }
}