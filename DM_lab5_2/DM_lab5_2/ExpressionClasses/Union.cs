using System;
using System.Collections.Generic;
using System.Collections;
using System.Linq;
using System.Text;

namespace DM_lab5_2.ExpressionClasses
{
    class Union : Expression
    {
        Expression exp1;
        Expression exp2;

        public Union(Expression exp1, Expression exp2) : base() 
        {
            this.exp1 = exp1;
            this.exp2 = exp2;
        }

        public override bool calculate(List<bool> values)
        {
            return exp1.calculate(values) || exp2.calculate(values);
        }
    }
}
