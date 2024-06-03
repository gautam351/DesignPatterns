using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns




    /* simple in between a factory will be created which will return the type of object requestedc
       
     Advanctages : 
    1. hides the instentiation logic.
    2. Reduces duplication of code


    difference between factory and abstract :
    in abstract you will request a factory and using that factory you will get the intance . 
    -> whereas in factory you will directly get the object from the factory .

    */

{

     interface ICar
    {
       
    }

    internal class FactoryDesignPatternCarA:ICar
    {

    }


    internal class FactoryDesignPatternCarB : ICar
    {




    }


    internal class Factory 
    {


        public ICar GetInstance(string Type)
        {
            switch (Type) {
                case "CarA": return new FactoryDesignPatternCarA();
                case "CarB": return new FactoryDesignPatternCarB();
                default: return null;


            }
        }


    }



}
