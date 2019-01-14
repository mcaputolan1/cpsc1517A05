﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPReview
{
    public class Die
    {
        //create a new instance of the math class Random
        //this istance (orrureny, objecr) will be shared by each instance of the class like
        // this instance will be created when the first instance of Die is created
        private static Random _rnd = new Random();

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

        private int _Sides;
        private string _Color;

        //Properties
        //a property is an external interface between the user
        //   and a single piece of data within the instance
        //a property has two abilities
        //   a) the ability to assign a value to the internal
        //      data member
        //   b) return an internal data member value to the user

        //Fully Implemented Property
        public int Sides
        {
            get
            {
                //takes internal values and return it to the user
                return _Sides;
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
                    _Sides = value;
                    Roll(); //consider placing this method within the property
                            //  if the set is public and not private
                            //if private then the method SetSides solves this problem
                }
                else
                {
                    throw new Exception("Die cannot be " + value.ToString() + " sides. Die must have between 6 and 20 sides.");
                }

            }
        }
        //another version of Sides using a private set and auto implemented property
        //in this version, you would need to code a method like SetSides()
        //public int Sides { get; private set; }

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
                if (string.IsNullOrEmpty(value))
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

        // optional; If not supplied the system defailt constructor
        //   is used which will assign a system value to each data member/auto
        // implemented property according to it's data type

        // you can have any number of instructors within your class
        // as soon as you code code a constructor your program is responsible for
        //   all constructors

        //syntax of a constructor
        // public classname([list of parameters]) { ... }

        // typical constructors
        // Default constructor
        //   this is similar to the system default constructor
        public Die()
        {
            //you could leave this constructor empty and the system would
            //  access the normal default value to your data members and
            //  auto implemented properties

            //you can directly access a private data member any place within
            //your class
            _Sides = 6;

            //you can access any property any place within your class
            Color = "White";

            //you could use a class method to generate a value for
            //  a data member/auto property
            Roll();
        }

        //Greedy Constructor
        //Typically has a parameter for each data member and auto implemented property
        //  within your class
        //parameter order is not important
        //this constructor allows the outside user to create and assign their
        //  own values to the data members/auto properties at the time of
        //  instance creation
        public Die(int sides, string color, int facevalue)
        {
            //since this data is coming from an outside source, it is best
            //  to use your property to save the values; especially if the
            //  property has validation
            Sides = sides;
            Color = color;
            FaceValue = facevalue;
        }

        //Behaviors (methods)
        //these are actions that the class can perform
        //the actions may or may not alter data members/auto property values
        //the actions could simply take a value(s) from the user
        //  and perform some logic operations against the values

        //can be public or private
        //create a method that allows the user to change the number of sides on a die
        public void SetSides(int sides)
        {
            if (sides >= 6 && sides <= 20)
            {
                Sides = sides;
            }
            else
            {
                //optionally,
                //a) throw a new exception
                throw new Exception("Invalid value for sides");
                //b) set _Sides to a default value
                //Sides = 6;
            }
            Roll();
        }

        public void Roll()
        {
            //no parameters are required for this method since it will be
            //  using the internal data values to complete its functionality

            //randomy generate a value for the die depending on the maximum sides
            FaceValue = _rnd.Next(1, Sides + 1);
        }
        
    }
}
