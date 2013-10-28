using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DM_lab5
{
    class Variable : Expression
    {
        private int index;

        public Variable(List<List<bool>> list, int index) : base(list) 
        {
            this.index = index;
        }

        public override bool calculate(int n)
        {

            return getList()[n][index];
        }
    }
}
