using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp2.Tools
{
    interface ICalculator { }
    interface ICalculator<T> : ICalculator
    {
        public T Add(T arg1, T arg2);
    }

    static class Calculators
    {
        private static Dictionary<Type, ICalculator> _calculators = new Dictionary<Type, ICalculator>
        {
            [typeof(int)] = new IntCalculator(),
            [typeof(double)] = new DoubleCalculator(),

        };

        public static ICalculator<T> GetInstance<T>()
        {
            return (ICalculator<T>)_calculators[typeof(T)];
        }
    }

    class IntCalculator : ICalculator<int>
    {
        public int Add(int arg1, int arg2)
        {
            return arg1 + arg2;
        }
    }

    class DoubleCalculator : ICalculator<double>
    {
        public double Add(double arg1, double arg2)
        {
            return arg1 + arg2;
        }
    }
}
