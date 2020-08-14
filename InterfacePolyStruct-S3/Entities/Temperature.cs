using System;

namespace InterfacePolyStruct_S3.Entities
{
    public class Temperature: IEquatable<Temperature>, IComparable, ICloneable
    {

        protected double celsius;
        protected double fahrenheit;
        protected string text;

        public Temperature(double celsius, double fahrenheit, string text)
        {
            Celsius = celsius;
            Fahrenheit = fahrenheit;
            Text = text;
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
                return text;
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
            return $"Celsius: {celsius}\n" +
                $"Fahrenheit: {fahrenheit}\n" +
                $"Text: {text}";
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
                hash = (hash * 16777619) ^ celsius.GetHashCode();
                hash = (hash * 16777619) ^ fahrenheit.GetHashCode();
                hash = (hash * 16777619) ^ text.GetHashCode();
                return hash;
            }
        }
        #endregion
    }
}