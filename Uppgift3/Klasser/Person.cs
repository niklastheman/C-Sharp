using System.Collections.Generic;

namespace Klasser
{
    public class Person
    {
        private string _name;
        private int _age;
        public List<Car> Cars { get; set; }

        /// <summary>
        /// Hämtar en persons namn
        /// </summary>
        /// <returns>String</returns>
        public string GetName()
        {
            return _name;
        }
        /// <summary>
        /// Hämtar en persons ålder
        /// </summary>
        /// <returns>Integer</returns>
        public int GetAge()
        {
            return _age;
        }

        
        public Person(string name, int age)
        {
            this._name = name;
            this._age = age;
            Cars = new List<Car>();
        }

    }

}