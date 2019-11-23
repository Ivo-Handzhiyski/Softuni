using System;
using System.Collections.Generic;
using System.Text;

namespace StartUp
{
    class Dog : Animal
    {
        public Dog(string name, string favFood)
           : base(name, favFood)
        {

        }

        public override string ExplainSelf()
        {
            return base.ExplainSelf() + Environment.NewLine + "DJAFF";
        }
    }
}
