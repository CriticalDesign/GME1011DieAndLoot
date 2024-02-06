using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DieProject
{
    internal class Die
    {
        //attributes
        private int _numberOfSides;
        private int _sideUp;

        //default constructor
        public Die()
        {
            _numberOfSides = 6;
            Roll();
        }

        //this constructor has an argument to create custom Dice
        public Die(int sidesIn)
        {
            _numberOfSides = sidesIn;

            //let's make sure the die makes sense and fix it otherwise
            if (!(_numberOfSides == 6 || _numberOfSides == 12 || _numberOfSides == 20 || _numberOfSides == 100))
                _numberOfSides = 6;
            
            //call Roll() for a random side up
            Roll();
        }

        //accessor
        public int GetNumberOfSides()
        {
            return _numberOfSides;
        }

        public int LookAtDie()
        {
            return _sideUp;
        }

        //mutator
        public void Roll()
        {
            Random rng = new Random();
            _sideUp = rng.Next(1, _numberOfSides + 1);
        }


        //ToString for debugging
        public override string ToString()
        {
            string output = "";
            output += "Dice are cool[";
            output += _numberOfSides;
            output += ",";
            output += _sideUp;
            output += "]";
            return output;
        }
    }
}
