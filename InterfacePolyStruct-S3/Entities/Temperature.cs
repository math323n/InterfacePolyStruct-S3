using System;

namespace InterfacePolyStruct_S3.Entities
{
    public class Temperature: IEquatable<Temperature>, IComparable<object>, ICloneable
    {

        protected double celsius;
        protected double fahrenheit;
        protected string text;

        public Temperature(double celsius, double fahrenheit)
        {
            Celsius = celsius;
            Fahrenheit = fahrenheit;
        }

        public double Celsius
        {
            get
            {
                return celsius;
            }

            set
            {
                celsius = value;
            }
        }

        public double Fahrenheit
        {
            get
            {
                return fahrenheit;
            }

            set
            {
                fahrenheit = value;
            }
        }

        public string Text
        {
            get
            {

                return GetText();
            }

            set
            {
                text = value;
            }
        }

        #region Methods
        /// <summary>
        /// Clone method from  ICloneable
        /// </summary>
        /// <returns></returns>
        public object Clone()
        {
            object clone = MemberwiseClone();

            return clone;
        }

        /// <summary>
        /// CompareTo from IComparable
        /// </summary>
        /// <param name="other"></param>
        /// <returns></returns>
        public int CompareTo(object other)
        {
            if(other == null)
            {
                return 1;
            }
            // Cast other as Temperature

            // if NOT null return the CompareTo
            if(other is Temperature otherTemperature)
            {
                return celsius.CompareTo(otherTemperature.celsius);
            }
            // Else throw ArgumentException
            else
            {
                throw new ArgumentException("Object is not a Temperature");
            }

        }

        /// <summary>
        /// Equals method to check for same objects
        /// </summary>
        /// <param name="other"></param>
        /// <returns></returns>
        public bool Equals(Temperature other)
        {
            // Null check
            if(other == null)
            {
                return false;
            }
            // If the same
            if(ReferenceEquals(this, other))
            {
                return true;
            }
            // Return
            return string.Equals(text, other.text) && celsius == other.celsius && fahrenheit == other.fahrenheit;
        }

        // Override for handling "object" type
        public override bool Equals(object obj)
        {
            // If obj is temperature
            if(obj is Temperature temp)
            {
                return Equals(temp);
            }
            return false;
        }

        /// <summary>
        /// Overrides ToString()
        /// </summary>
        /// <returns></returns>
        public override string ToString()
        {

            // Return complete info
            return $"Celsius: {Celsius}\n" +
                $"Fahrenheit: {Fahrenheit}\n" +
                $"Text: {Text}";
        }

        /// <summary>
        /// Overrides GetHashCode()
        /// </summary>
        /// <returns Hashcode></returns>
        public override int GetHashCode()
        {
            // "unchecked" Supress overflow 
            unchecked
            {

                // Method Two
                // int to store hash
                int hash = (int)2166136261;

                // Multiply hash with a second prime number and add each fields hash code
                hash = (hash * 16777619) ^ Celsius.GetHashCode();
                hash = (hash * 16777619) ^ Fahrenheit.GetHashCode();
                hash = (hash * 16777619) ^ Text.GetHashCode();
                return hash;
            }
        }

        private string GetText()
        {
            if(Celsius < -30)
            {
                return "Winter is Coming";
            }
            else if(celsius >= -30 && Celsius < -10)
            {
                return "Life on Planet Rossem";
            }
            else if(Celsius >= -10 && Celsius < 0)
            {
                return "We are home by Christmas";
            }
            else if(Celsius >= 0 && Celsius < 10)
            {
                return "Cold";
            }
            else if(Celsius >= 10 && Celsius < 20)
            {
                return "Temperate";
            }
            else if(Celsius >= 20 && Celsius < 30)
            {
                return "Os lige nu";
            }
            else if(Celsius >= 30 && Celsius < 40)
            {
                return "Os lige om lidt";
            }
            else
            {
                return "Blazing heart of the Sun";
            }

        }
        #endregion
    }
}