namespace FacadePattern.Entities
{
    /// <summary>
    /// State entity class
    /// </summary>
    public class State
    {
        public string Name => "Washington";
     
        /// <summary>
        /// Getting a state details using given zip code
        /// </summary>
        /// <param name="zipCode">zip code value will be search for state</param>
        /// <returns>full state info instance</returns>
        public State GetStateForZipCode(string zipCode)
        {
            // service or db lookup would go here
            return new State();
        }
    }
}