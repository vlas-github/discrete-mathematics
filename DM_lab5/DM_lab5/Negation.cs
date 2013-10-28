using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DM_lab5
{
    class Negation : Expression
    {
        Expression exp;

        public Negation(Expression exp) : base(exp.getList()) 
        {
            this.exp = exp;
        }

        public override bool calculate(int n)
        {

            return !exp.calculate(n);
        }
    }
}
