﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kompil.ASP
{
     class NumderNode : ExpressionNode
    {
        

        public NumderNode(Token number)
        {
            this.number = number;
        }
    }
}
