using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DM_lab5
{
    class Modulo2 : Expression
    {
        Expression exp1;
        Expression exp2;

        public Modulo2(Expression exp1, Expression exp2) : base(exp1.getList()) 
        {
            this.exp1 = exp1;
            this.exp2 = exp2;
        }

        public override bool calculate(int n)
        {

            return new Union(new Intersection(exp1, new Negation(exp2)), 
                             new Intersection(exp2, new Negation(exp1))).calculate(n);
        }
    }
}
