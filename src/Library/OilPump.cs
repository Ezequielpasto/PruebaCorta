namespace Ucu.Poo.Cars
{
    /// <summary>
    /// Representa una bomba de aceite.
    /// </summary>
    public class OilPump
    {
        /// <summary>
        /// El sensor de la bomba de aceite.
        /// </summary>
        public Sensor Sensor { get; private set; } = new Sensor();
        
        public int CountFaultySensors()
        {
            if (Sensor.IsFaulty)
            {
                return 1;
            }
            else
            {
                return 0;
            }
        }
    }
    
    

}
