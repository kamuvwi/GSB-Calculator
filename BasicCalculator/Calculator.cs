using Divide;
using Adding;
using Subtract;
using Multiply;
using Squared;
using Cubed;


namespace BasicCalculator
{
   
    public interface ICalcultorBasic
    {
        public dynamic Add(dynamic a, dynamic b);
        public dynamic Divide(dynamic a, dynamic b);
        public dynamic Difference(dynamic a, dynamic b);
        public dynamic Multiply(dynamic a, dynamic b);
        public dynamic Square(dynamic a);
        public dynamic Cubed(dynamic a);

    }
    public class Calculator : IAdd, IDivide, ISubtract, IMultiply, ISquared, ICubed
    {
        // Creating objects of Geeks1 and Geeks2 class 
        Ad add = new Ad();
        Div divide = new Div();
        Sub subtract = new Sub();
        Multiple multiply = new Multiple();
        Squares square = new Squares();
        Cubes cube = new Cubes();
        
        public dynamic result;

        public dynamic Cubed(dynamic a)
        {
            result = cube.Cubed(a);
            return result;
        }
        public dynamic Square(dynamic a)
        {
            result = square.Square(a);
            return result;
        }

        public dynamic Multiply(dynamic a, dynamic b)
        {
            result = multiply.Multiply(a, b);
            return result;
        }
        public dynamic Difference(dynamic a, dynamic b)
        {
            result = subtract.Difference(a, b);
            return result;

        }

        public dynamic Add(dynamic a, dynamic b)
        {
            result = add.Add(a, b);
           
            return result;
        }
        public dynamic Divide(dynamic a, dynamic b)
        {
            
            result = divide.Divide(a, b);
            return result;

        }

    }
}