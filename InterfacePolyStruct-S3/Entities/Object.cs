using System;
using System.Collections.Generic;
using System.Text;

namespace InterfacePolyStruct_S3.Entities
{
    public abstract class Object
    {
        public override string ToString()
        {
            return $"Test";
        }

        public virtual bool Equals(object other)
        {
            return true;

        }

 

    }
}