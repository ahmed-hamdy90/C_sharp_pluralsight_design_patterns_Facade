using FacadePattern.Entities;

namespace FacadePattern
{
    /// <summary>
    /// WeatherFacadeResults represent the Results of weather temperature
    /// </summary>
    public class WeatherFacadeResults
    {
        /// <summary>
        /// Fahrenheit temperature value
        /// </summary>
        public int Fahrenheit { get; set; }

        /// <summary>
        /// Celsius temperature value
        /// </summary>
        public int Celsius { get; set; }

        /// <summary>
        /// City instance info which temperature result for
        /// </summary>
        public City City { get; set; }

        /// <summary>
        /// State instance info which temperature result for
        /// </summary>
        public State State { get; set; }
    }
}