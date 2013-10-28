using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DM_lab5
{
    class Union : Expression
    {
        Expression exp1;
        Expression exp2;

        public Union(Expression exp1, Expression exp2) : base(exp1.getList()) 
        {
            this.exp1 = exp1;
            this.exp2 = exp2;
        }

        public override bool calculate(int n)
        {

            return exp1.calculate(n) || exp2.calculate(n);
        }
    }
}
