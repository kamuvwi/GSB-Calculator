using System;
using operations;

namespace Squareroot
{
    public interface ISquareroot
    {
        public dynamic Squareroot(dynamic a);
    }
    public class Squareroots : ISquareroot
    {
        public dynamic result;

        public dynamic Squareroot(dynamic a)
        {
            result = Squarerooting.Squareroot(a);
            return result;
        }
    }
}
