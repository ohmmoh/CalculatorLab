using System;
using System.Collections.Generic;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CPE200Lab1
{
    public class RPNCalculatorEngine : CalculatorEngine
    {
        public string RPNProcess(string str)
        {
            string firstOp, secondOp;
            string[] strArr = str.Split(' ');
            Stack rpnStack = new Stack();
           
                foreach(string s in strArr)
                {
                    Console.WriteLine(s);
                    if (isNumber(s))
                    {
                        rpnStack.Push(s);
                    }
                    else if (isOperator(s))
                    {
                        firstOp = rpnStack.Pop().ToString();
                        secondOp = rpnStack.Pop().ToString();
                    rpnStack.Push(calculate(s, firstOp, secondOp));
                    }
                    
                }
            
            return "E";
        }
        
        
    }
}
