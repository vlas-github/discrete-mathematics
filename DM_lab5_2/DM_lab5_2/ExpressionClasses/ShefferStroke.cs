using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DM_lab5_2.ExpressionClasses
{
    class ShefferStroke : Expression
    {
        Expression exp1;
        Expression exp2;

        public ShefferStroke(Expression exp1, Expression exp2)
        {
            this.exp1 = exp1;
            this.exp2 = exp2;
        }

        public override bool calculate(List<bool> values)
        {
            return new Negation(new Intersection(exp1, exp2)).calculate(values);
        }
    }
}
