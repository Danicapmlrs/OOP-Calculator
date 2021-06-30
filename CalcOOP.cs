using System;
using System.Collections.Generic;
using System.Text;

namespace OOP_Calculator
{
    class CalcOOP
    {
        private String Operands;

        public void setasAdd()
        {
            Operands = "+";
        }
        public void setasMinus()
        {
            Operands = "-";
        }
        public void setasMultiply()
        {
            Operands = "*";
        }
        public void setasDivide()
        {
            Operands = "/";
        }
        public String getOperand() 
        {
            return Operands;
        }
    }


}
