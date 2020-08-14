using System;




namespace InterfacePolyStruct_S3.Entities
{
    public class Temperature: Object, IEquatable<object>, IComparable, ICloneable
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

        public bool Equals( Temperature other)
        {
            throw new NotImplementedException();
        }
        #endregion
    }
}
