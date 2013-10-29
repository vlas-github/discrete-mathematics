using System;
using System.Collections.Generic;
using System.Collections;
using System.Linq;
using System.Text;

namespace DM_lab5_2.ExpressionClasses
{
    class Negation : Expression
    {
        Expression exp;

        public Negation(Expression exp) : base() 
        {
            this.exp = exp;
        }

        public override bool calculate(List<bool> values)
        {
            return !exp.calculate(values);
        }
    }
}
