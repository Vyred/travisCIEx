/////////////////////////////////////////////////////////////////////////////////////////////////////////////
////                                                                                                       // 
////     Made by: Matthew Yaworski      of       Comp123 section 063                                       // 
////     Last date modified: February 02 15                                                                //
////       This class is the parent class hero of the SuperHero class                                      //
////       It sets several stats and allows the derived class to have access to them; as well as the fight //
////       and the showStats methods.                                                                      //
////                                                                                                       //     
/////////////////////////////////////////////////////////////////////////////////////////////////////////////
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GodClause
{
    class Hero
    {
     
 
         // PRIVATE PROPERTIES ++++++++++++++++++++++++++++++++++++++++
        private int speed;
        private int strength;
        private int health;
        private int currentHealth;
       
        // Public Properties
        public string name;
      


        // CONSTRUCTOR +++++++++++++++++++++++++++++++++++++++++++++++
        public void creator (string name)
        {
             this.name = name;
             Console.WriteLine ("");
             generateAbilities(this.speed, this.strength, this.health);
             this.currentHealth = this.health;
            //this.speed = speed;0
            //this.strength = streNngth;
           // this.health = health;
        }





        //just a method to register a user response
        //private static string checkKey (string consoleKey)
        private static string checkKey (string consoleKey)
        {
            consoleKey = Console.ReadLine();
            return consoleKey;
        }

        //called from the main method, this method asks if you want to attempt a hit, if so the hitAttempt method is called. Otherwise this only outputs a message
        public void fight()
        {
            String consoleKey = "";
            Console.WriteLine("Select an option");

            Console.WriteLine("Enter 1: to attempt a normal hit");
            Console.WriteLine("");
            string response = checkKey(consoleKey);

            switch (response)
            {
                case "1":
                    Console.WriteLine("ok");
                    hitAttempt();
                    break;
            }
        }

        //a Random variable determines whether or not you land a hit, if so this method calls hitdamage otherwise it outputs a message and ends. called from the fight method within this class
        private void hitAttempt ()
        {
            int theHit;
            int hitChance = 0;
            Random strikeRND = new Random();
            int landedHit = strikeRND.Next(hitChance, 100);
           // i know it should be less than but it takes to long to see a result
            if (landedHit >= 20)
            {
             theHit = hitDamage(strength);
            }
            else
            {
                theHit = 0;
                Console.WriteLine("your hit missed!");
            }
            Console.WriteLine("The damage you outputted was {0}", theHit);
        }



        //This method works with the hitattempt method and is in the sequence that is the fight method. This method outputs a random number called damage and displays it      
        private int hitDamage(int strength)
        {
            Random strikeRND = new Random();
            int damageMultiplier = strikeRND.Next(1, 6);
            int damage = damageMultiplier * this.strength;
            return damage;
        }

        ///assigns the called vaariables strength, speed and health a value between 1 and 100
        private void generateAbilities(int strength, int speed, int health)
        {
             Random RND = new Random();
             this.strength = RND.Next(1, 100);
             this.health = RND.Next(1, 100);
             this.speed = RND.Next(1, 100);
            
        }


        //private void generateAbilities(int avocation)
        //{

        //    int adder;
        //    while (this.strength + this.health + this.speed < 1000)
        //    {
        //        adder = 1000 - this.strength - this.health - this.speed;
        //        //blackbox weakend
        //    Random strengthRND = new Random();
        //     this.strength += strengthRND.Next(0, adder / 3);
        //    Random healthRND = new Random();
        //     this.health += healthRND.Next(0, adder / 3);
        //      Random speedRND = new Random();
        //     this.speed += speedRND.Next(0, adder / 3);
        //    }
        //    //pasives
        //}



        ////this method is meant to dislays stats (properties) that were assigned via the hero call
        public void show()
       {

           Console.WriteLine("****************************");
           Console.WriteLine("stength: {0}", this.strength);
           Console.WriteLine("speed: {0}", this.speed);
           Console.WriteLine("health: {0}/{1} ", this.currentHealth, this.health);
           Console.WriteLine("name: {0}", this.name);
           Console.WriteLine("****************************");
        }
        
    }

    }
