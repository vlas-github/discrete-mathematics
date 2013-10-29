using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DM_lab5_2.ExpressionClasses
{
    class ConverseImplication : Expression
    {
        Expression exp1;
        Expression exp2;

        public ConverseImplication(Expression exp1, Expression exp2)
            : base() 
        {
            this.exp1 = exp1;
            this.exp2 = exp2;
        }

        public override bool calculate(List<bool> values)
        {
            return new Union(new Negation(exp1), exp2).calculate(values);
        }
    }
}
