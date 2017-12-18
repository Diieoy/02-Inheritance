namespace Inheritance3
{
    class ExponentiationOperation : AbstractOperation
    {
        public ExponentiationOperation(int arg1, int arg2) : base(arg1, arg2)
        {
        }

        public override int GetResult()
        {
            int result = 1;

            for (int i = 0; i < Arg2; i++)
            {
                result = result * Arg1;
            }

            return result;
        }

        public override string ToString()
        {
            return (Arg1 + " to the " + Arg2 + " power = " + GetResult());
        }
    }
}
