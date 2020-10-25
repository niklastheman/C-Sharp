using System;

namespace Klasser
{
    public class Car
    {
        // Fields
        public string _model;
        private decimal _odometer;

        // Properties
        public int WeightInKG { get; set; }
        public string Registered { get; set; }
        public bool IsElectric { get; set; }
        public string LicensePlate { get; set; }

        /// <summary>
        /// Sätter modellen på bilen.
        /// </summary>
        /// <param name="modelname">Modellnamn.</param>
        public Car(string modelname)
        {
            _model = modelname;
        }

        /// <summary>
        /// Sätter alla uppgifter om en bil.
        /// </summary>
        /// <param name="model"></param>
        /// <param name="weight"></param>
        /// <param name="registered"></param>
        /// <param name="licenseplate"></param>
        /// <param name="electric"></param>
        public Car(string model, int weight,
            string registered,
            string licenseplate,
            bool electric)
        {
            this._model = model;
            this.WeightInKG = weight;
            this.Registered = registered;
            this.LicensePlate = licenseplate;
            this.IsElectric = electric;
        }

        /// <summary>
        /// Adderar hur långt ett fordon har kört till milmätaren.
        /// </summary>
        /// <param name="lengthDriven">Hur långt fordonet har kört</param>
        public void SetOdometer(decimal lengthDriven)
        {
            if (lengthDriven > 0)
            {
                _odometer += lengthDriven;
            }
            
        }

        /// <summary>
        /// Hämtar milmätaren och omvandlar till <b>string</b>.
        /// </summary>
        /// <returns>String</returns>
        public string GetOdometer()
        {
            return _odometer.ToString();
        }

        /// <summary>
        /// Skriver ut all information om en bil.
        /// </summary>
        public void GetInfo()
        {
            Console.WriteLine();
            Console.WriteLine($"Modell: {_model}");
            Console.WriteLine($"Vikt: {WeightInKG}kg");
            Console.WriteLine($"Registrerades: {Registered}");
            Console.WriteLine($"Registreringsnummer: {LicensePlate}");
            if (IsElectric)
                Console.WriteLine("\"Detta är en elbil!\"");
        }


    }

}