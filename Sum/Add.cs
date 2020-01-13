using System;
using operations;

namespace Adding
{
    public interface IAdd
    {
        public dynamic Add(dynamic a, dynamic b);
    }
    public class Ad : IAdd
    {
        public dynamic result;

        public dynamic Add(dynamic a, dynamic b)
        {
            result = Addition.Sum(a, b);
            return result;
        }
    }
}
