using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DM_lab5
{
    class Equivalence : Expression
    { 
        Expression exp1;
        Expression exp2;

        public Equivalence(Expression exp1, Expression exp2) : base(exp1.getList()) 
        {
            this.exp1 = exp1;
            this.exp2 = exp2;
        }

        public override bool calculate(int n)
        {

            return new Intersection(new Implication(exp1, exp2), new Implication(exp2, exp1)).calculate(n);
        }
    }
}
