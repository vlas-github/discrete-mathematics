using System;
using System.Collections.Generic;
using System.Collections;
using System.Linq;
using System.Text;

namespace DM_lab5_2.ExpressionClasses
{
    abstract class Expression
    {
        public Expression() 
        {
        }

        abstract public bool calculate(List<bool> values);
    }    
}
