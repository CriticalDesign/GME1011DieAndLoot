using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DieProject
{
    internal class LootBox
    {
        //attributes
        private bool _isOpen;
        private List<string> _theLoot;

        //default / no-argument constructor
        public LootBox()
        {
            _isOpen = false;

            _theLoot = new List<string>();  //initialize the list
            //add some loot
            _theLoot.Add("a coin");
            _theLoot.Add("a stick");
            _theLoot.Add("cheese");
        }

        //accessor
        public bool IsOpen()
        {
            return _isOpen;
        }

        //mutator + accessor (unusual, but possible.
        public string DispenseLoot()
        {
            if (_isOpen)
                return "loot box is already empty";
            else
            {
                _isOpen = true;

                Die myChances = new Die(100);
                myChances.Roll();
                int lootIndex = -1;
                if (myChances.LookAtDie() < 50)
                    lootIndex = 0;
                else if (myChances.LookAtDie() < 75)
                    lootIndex = 1;
                else
                    lootIndex = 2;

                Console.WriteLine("Debug check random number " + myChances.LookAtDie());

                string myLoot = _theLoot[lootIndex];
                _theLoot = new List<string>();
                return myLoot;
            }
        }
    }
}
