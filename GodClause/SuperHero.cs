/////////////////////////////////////////////////////////////////////////////////////////////////////////////
////                                                                                                       // 
////     Made by: Matthew Yaworski      of       Comp123 section 063                                       // 
////     Last date modified: February 02 15                                                                //
////       This class is derived from the Hero class.                                                      //
////       It calls a method that generate 3 random unique powers by using 3 arrays. It can also display   // 
////       those powers.                                                                                   // 
////                                                                                                       //     
/////////////////////////////////////////////////////////////////////////////////////////////////////////////

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GodClause
{
    class SuperHero : Hero
    {

        //Private Variables
        private string[] superPowers = { "Super Speed", "Super Strength", "Body Armour", "Flight", "Fire Generation", "Weather Control", "Darkenss", "Light", "Air", "Solid", "Heat", "Water", "Mass", "Arcane", "Biotic" };
        // Eg private string [] superpowersUnlockedSet = superPowers [x] + superPowerUnlocked [x];
        private bool[] superPowersUnlocked = { false, false, false, false, false, false };
        private int totalNumberOfPowers = 0;
        private string[] superpowersUnlockedSet = new string[3];
        private int numberOfPowers = 0;
        
        //calls generate random powers      
        public void skillSet(string name)
        {
            this.name = name;
            generateRandomPowers();
        }

        //generates random powers by using the string of the superPowers array along with randoms to produce a true or false result. 
        //If true the corresponding element in the superPowersUnlocked boolean array is true it becomes part of the superpowersUnlockedSet array. 
        //if there a 3 true elements then the method continues by calling the settingPowers method. 
        private void generateRandomPowers()
        {
            Random RND = new Random();
            int briefRNDValue;

            while (this.numberOfPowers < 3)
            {
                briefRNDValue = RND.Next(0, 7);
                switch (briefRNDValue)
                {
                    case 1:
                        if (superPowersUnlocked[0] != true)
                        {
                            this.numberOfPowers++;
                        }
                        this.superPowersUnlocked[0] = true;
                        break;

                    case 2:
                        if (superPowersUnlocked[1] != true)
                        {
                            this.numberOfPowers++;
                        }
                        this.superPowersUnlocked[1] = true;
                        break;

                    case 3:
                        if (superPowersUnlocked[2] != true)
                        {
                            this.numberOfPowers++;
                        }
                        this.superPowersUnlocked[2] = true;
                        break;

                    case 4:
                        if (superPowersUnlocked[3] != true)
                        {
                            this.numberOfPowers++;
                        }
                        this.superPowersUnlocked[3] = true;
                        break;

                    case 5:
                        if (superPowersUnlocked[4] != true)
                        {
                            this.numberOfPowers++;
                        }
                        this.superPowersUnlocked[4] = true;
                        break;

                    case 6:
                        if (superPowersUnlocked[5] != true)
                        {
                            this.numberOfPowers++;
                        }
                        this.superPowersUnlocked[5] = true;
                        break;
                }
            }
            settingPowers();
        }


         //method is called using the generatePowers method. Basically assigns the elements in superPowersUnlockedSet which produces the final output
//Extra // this is what assigns superPowersUnlockedSet by looking at which elements are true in 
//|||||//the superPowers unlocked array and assigning the coresponding element in the superPowers array to one 
//||||///in the superpowersUnlockedSet array. i had a different method that is better but i decided to stick with what i made first
        public void settingPowers()
        {
            for (int x = 0; x <= 5; x++)
            {
                if (this.superPowersUnlocked[x] == true)
                {
                    this.superpowersUnlockedSet[totalNumberOfPowers] = this.superPowers[x];
                    this.totalNumberOfPowers++;
                }

            }


        }


        //This basically outputs the three random super powers, which are generated by the generatePowers method withen this class
        public void showPowers()
        {
            Console.WriteLine("Your current powers are");
            for (int x = 0; x < this.superpowersUnlockedSet.Length; x++)
            {
                {
                    Console.Write("{0}, ", this.superpowersUnlockedSet[x]);

                }
            }
        }

        public void showpowers()
        {
            Console.WriteLine("Your current powers are");
            for (int x = 0; x < this.superPowersUnlocked.Length; x++)
            {
                {
                    Console.Write("{0}, ", this.superPowers[x]);
                }
            }

        }

        //public string idk(string[] superPowers)
        //{
        //    string ok = (" " + superpowersUnlockedSet[0] + " ," + superpowersUnlockedSet[1] + " ," + superpowersUnlockedSet[2]);
        //    return ok;
        //}



    }
}