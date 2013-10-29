using System;
using System.Collections.Generic;
using System.Collections;
using System.Linq;
using System.Text;

namespace DM_lab5_2.ExpressionClasses
{
    class Variable : Expression
    {
        private int index;

        public Variable(int index) : base() 
        {
            this.index = index;
        }

        public override bool calculate(List<bool> values)
        {
            return values[index];
        }
    }
}
