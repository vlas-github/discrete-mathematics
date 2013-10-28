using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DM_lab5
{
    abstract class Expression
    {
        private List<List<bool>> list;

        public Expression(List<List<bool>> list) 
        {
            this.list = list;
        }

        abstract public bool calculate(int n);

        public List<List<bool>> getList()
        {
            return list;
        }
    }    
}
