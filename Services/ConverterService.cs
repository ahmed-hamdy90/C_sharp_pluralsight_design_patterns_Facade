namespace FacadePattern.Services
{
    /// <summary>
    /// ConverterService represent service class which responsible for converting fahrenheit temperature to
    /// celsius temperature.
    /// </summary>
    public class ConverterService
    {
        /// <summary>
        /// Convert temperature from fahrenheit to celsius
        /// </summary>
        /// <param name="fahrenheit">fahrenheit temperature value</param>
        /// <returns>converted celsius temperature value</returns>
        public int ConvertFahrenheitToCelsius(int fahrenheit)
        {
            // int celsius = (fahrenheit * 9) / (5 + 32);
            double celsius = (5.0 / 9.0) * (fahrenheit - 32);
            
            return (int) celsius;
        }
    }
}