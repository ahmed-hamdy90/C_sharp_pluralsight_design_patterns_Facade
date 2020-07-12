namespace FacadePattern.Services
{
    /// <summary>
    /// BigClassFacade represent solution for <see cref="BigClass"/> class applying facade pattern,
    /// this class include only calling methods need from <see cref="BigClass"/> class 
    /// </summary>
    public class BigClassFacade
    {
        private readonly BigClass _bigClass;

        /// <summary>
        /// BigClassFacade constructor
        /// </summary>
        public BigClassFacade()
        {
            // initialize instance and reset the value
            _bigClass = new BigClass();
            _bigClass.SetValueI(0);
        }

        /// <summary>
        /// Increase the current value by given number value
        /// </summary>
        /// <param name="numberToAdd">number will be add</param>
        public void IncreaseBy(int numberToAdd)
        {
            _bigClass.AddToI(numberToAdd);
        }

        /// <summary>
        /// Decrease the current value by given number value
        /// </summary>
        /// <param name="numberToSubtract">number will be subtract</param>
        public void DecreaseBy(int numberToSubtract)
        {
            _bigClass.AddToI(-numberToSubtract);
        }

        /// <summary>
        /// Retrieve the current value which applying on it both <see cref="IncreaseBy"/> and <see cref="DecreaseBy"/> operations 
        /// </summary>
        /// <returns>current value</returns>
        public int GetCurrentValue()
        {
            return _bigClass.GetValueA();
        }
    }
}