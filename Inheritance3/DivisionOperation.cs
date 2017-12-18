﻿namespace Inheritance3
{
    class DivisionOperation : AbstractOperation
    {
        public DivisionOperation(int arg1, int arg2) : base(arg1, arg2)
        {
        }

        public override int GetResult()
        {
            return (Arg1 / Arg2);
        }

        public override string ToString()
        {
            return (Arg1 + " / " + Arg2 + " = " + GetResult());
        }
    }
}
