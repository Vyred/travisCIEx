
/////////////////////////////////////////////////////////////////////////////////////////////////////////////
////                                                                                                       // 
////     Made by: Matthew Yaworski      of       Comp123 section 063                                       // 
////     Last date modified: February 02 15                                                                //
////       This program is meant to display the functionality of inheretence and classes through a game    //
////       like theme of creating stats, and having a more specified hero with powers, with methods like   //
////       fight, showPowers and showStats                                                                 //     
/////////////////////////////////////////////////////////////////////////////////////////////////////////////
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
///
namespace GodClause
{
    class Calibur
    {
        static void Main(string[] args)
        {


            //SecondSoul hero = new SecondSoul();
            //hero.creator("hero");
            //hero.show();
            //hero.fight();
             ////////////////////////////////////
            ////////////////////////////////////
            //SecondSoul hero = new SecondSoul();
            //hero.creator("hero");
            //hero.show();
            //hero.fight();


            SuperHero heroUlti = new SuperHero();
            heroUlti.skillSet("Super Hero");
            heroUlti.showPowers();
            heroUlti.creator("Super Hero");
           Console.WriteLine ("Enter anything to fight, enter q to exit");
           string mainResponse = Console.ReadLine();
            while (mainResponse != "q" || mainResponse != "Q")
            {
            heroUlti.show();
            heroUlti.fight();
            mainResponse = Console.ReadLine();
            }
            Console.WriteLine("Press any key to exit");
            Console.ReadKey();
        }

        }
    }



