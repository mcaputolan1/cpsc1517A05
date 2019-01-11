using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPReview
{
    public class Die
    {
        //this is the definition of a object
        //it is a conceptual view of the data
        //   that will be held by a physical
        //   instance (object) of this class

        //Data Members
        //is an internal private data storage item
        //private data members cannot be reached directly
        //   by the user
        //public data members can be reached directly
        //   by the user

        private int _Size;
        private string _Color;

        //Properties
        //a property is an external interface between the user
        //   and a single piece of data within the instance
        //a property has two abilities
        //   a) the ability to assign a value to the internal
        //      data member
        //   b) return an internal data member value to the user

        //Fully Implemented Property
        public int Size
        {
            get
            {
                //takes internal values and return it to the user
                return _Size;
            }
            set
            {
                //takes the supplied user value and places it into
                //  the internal private data member
                //the incoming piece of data is placed into a special
                //  variable that is called: value
                //optionally you may place validation on the incoming
                //  value
                if (value >= 6 && value <= 20)
                {
                    _Size = value;
                }
                else
                {
                    throw new Exception("Die cannot be " + value.ToString() + " sides. Die must have between 6 and 20 sides.");
                }
                
            }
        }

        //Auto Implemented Property
        // public
        // It has a data type
        // It has a name
        // It does not have an internal data member that you can directly access
        //The system will create internally, a data storage area of the appropriate
        // data type and manage the area
        //The only wat to access the data of an Auto Implemented Property is via
        // the property
        //usually use when there is no need for any internal validation  or other property logic
        public int FaceValue { get; set; }

        public string Color
        {
            get
            {
                return _Color;
            }
            set
            {
                // (value == null) This will fail for an empty string
                // (value == "") This will fail for a null value
                if(string.IsNullOrEmpty(value))
                {
                    throw new Exception("Color has no value.");
                }
                else
                {
                    _Color = value;
                }
            }
        }

        //Constructors

        //Behaviors (methods)
    }
}
