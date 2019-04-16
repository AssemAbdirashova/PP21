using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Attempt2
{
    enum CalcState
    {
        Zero,
        AccamulateDigits,
        Operation,
        Equal,
        
    }
   
    class Brain
    {
        public string tempNumber = "";
        public string op = "";
        CalcState calcState = CalcState.Zero;
        public string resultNumber = "";

        DisplayTextDelegate textDelegate;
        public Brain(DisplayTextDelegate textDelegate)
        {
            this.textDelegate = textDelegate;
        }
       
        public void Process(string msg)
        {
            switch (calcState)
            {
                case CalcState.Zero:
                    Zero(msg, false);
                    break;
                case CalcState.AccamulateDigits:
                    AccamulateDigits(msg, false);
                    break;
                case CalcState.Operation:
                    Operation(msg, false);
                    break;
                case CalcState.Equal:
                    break;
                default:
                    break;
            }
        }
        void Zero(string msg, bool Input)
        {
            if (Input)
            {
                calcState = CalcState.Zero;
            }
            else
            {
                
                if (Rules.IsNotZeroDigit(msg[0]))
                {
                    AccamulateDigits(msg, true);
                }
                else if (Rules.IsAgain(msg[0]))
                {
                    calcState = CalcState.Zero;
                }
            }
        }
        void AccamulateDigits(string msg, bool Input)
        {
            if (Input)
            {
                calcState = CalcState.AccamulateDigits;
                tempNumber = tempNumber + msg;

                textDelegate.Invoke(tempNumber);
            }
            else
            {
                if (Rules.IsDigit(msg[0]))
                {
                    AccamulateDigits(msg, true);
                }
                else if (Rules.IsDouble(msg[0]))
                {
                    AccamulateDigits(msg, true);
                }
                else if (Rules.IsAgain(msg[0]))
                {
                    Zero(msg, true);
                }
                else if (Rules.IsOption(msg[0]))
                {
                    Operation(msg, true);
                }
                else if (Rules.IsEqual(msg[0]))
                {
                    Equal(msg, true);
                }
            }
        }
        void Operation(string msg, bool Input)
        {
            if (Input)
            {
                resultNumber = tempNumber;
                tempNumber = "";
                op = msg;
            }
            else
            {
                if (Rules.IsNotZeroDigit(msg[0]))
                {
                    AccamulateDigits(msg, true);
                }
            }
        }
        void Equal(string msg, bool Input)
        {
            if (Input)
            {
                if (op == "+")
                {
                    resultNumber = (float.Parse(resultNumber) + float.Parse(tempNumber)).ToString();
                    textDelegate(resultNumber);
                    resultNumber = "";
                    tempNumber = "";
                    op = "";
                }
                else if (op == "-")
                {
                    resultNumber = (float.Parse(resultNumber) - float.Parse(tempNumber)).ToString();
                    textDelegate(resultNumber);
                    resultNumber = "";
                    tempNumber = "";
                    op = "";
                }
                else if (op == "*")
                {
                    resultNumber = (float.Parse(resultNumber)*float.Parse(tempNumber)).ToString();
                    textDelegate(resultNumber);
                    resultNumber = "";
                    tempNumber = "";
                    op = "";
                }
                else if (op == "/")
                {
                    resultNumber = (float.Parse(resultNumber)/float.Parse(tempNumber)).ToString();
                    textDelegate(resultNumber);
                    resultNumber = "";
                    tempNumber = "";
                    op = "";
                }
            }


        }
    }
}