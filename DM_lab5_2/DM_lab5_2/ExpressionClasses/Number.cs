using System;
using System.Collections.Generic;
using System.Collections;
using System.Linq;
using System.Text;

namespace DM_lab5_2.ExpressionClasses
{ 
    class Number : Expression
    {
        bool value;

        public Number(bool value)
        {
            this.value = value;
        }

        public override bool calculate(List<bool> values)
        {
            return value;
        }
    }
}
