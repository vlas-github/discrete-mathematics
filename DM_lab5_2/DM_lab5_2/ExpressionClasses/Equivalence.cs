using System;
using System.Collections.Generic;
using System.Collections;
using System.Linq;
using System.Text;

namespace DM_lab5_2.ExpressionClasses
{
    class Equivalence : Expression
    { 
        Expression exp1;
        Expression exp2;

        public Equivalence(Expression exp1, Expression exp2) : base() 
        {
            this.exp1 = exp1;
            this.exp2 = exp2;
        }

        public override bool calculate(List<bool> values)
        {
            return new Intersection(new Implication(exp1, exp2), new Implication(exp2, exp1)).calculate(values);
        }
    }
}
