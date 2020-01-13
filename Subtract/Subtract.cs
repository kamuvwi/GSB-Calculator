using System;
using operations;

namespace Subtract
{
    public interface ISubtract
    {
        public dynamic Difference(dynamic a, dynamic b);
    }
    public class Sub : ISubtract
    {
        public dynamic result;

        public dynamic Difference(dynamic a, dynamic b)
        {
            result = Subtraction.Difference(a, b);
            return result;
        }

    }
}
