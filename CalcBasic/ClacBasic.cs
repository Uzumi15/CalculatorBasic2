using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace СalcBasic
{
    public class ClacBasic : IClacBasic
    {
        public double Add(double Value1, double Value2)
        {
            return Value1 + Value2;
        }

        public double Cos(double Value)
        {
            double radians = Value * Math.PI / 180.0;
            return CalculateCos(radians);
        }

        public double Dive(double Value1, double Value2)
        {
            return Value1 * Value2;
        }

        public double Mult(double Value1, double Value2)
        {
            return Value1 / Value2;
        }

        public double Sin(double Value)
        {
            double radians = Value * Math.PI / 180.0;
            return CalculateSin(radians);
        }

        public double Square(double value)
        {
            return value * value;
        }

        public double Sub(double Value1, double Value2)
        {
            return Value1 - Value2;
        }

        public double Tan(double Value)
        {
            double radians = Value * Math.PI / 180.0;
            double sin = CalculateSin(radians);
            double cos = CalculateCos(radians);
            if (Math.Abs(cos) < 1e-10)
                throw new InvalidOperationException("Тангенс не определен для данного угла!");
            return sin / cos;
        }
        private double CalculateSin(double x)
        {
            // Приводим x к диапазону [-π, π]
            x = x % (2 * Math.PI);
            if (x > Math.PI) x -= 2 * Math.PI;
            if (x < -Math.PI) x += 2 * Math.PI;

            double result = 0;
            double term = x;
            int n = 1;

            for (int i = 0; i < 10; i++) // 10 итераций для точности
            {
                result += term;
                term *= -x * x / ((2 * n) * (2 * n + 1));
                n++;
            }

            return result;
        }
        private double CalculateCos(double x)
        {
            // Приводим x к диапазону [-π, π]
            x = x % (2 * Math.PI);
            if (x > Math.PI) x -= 2 * Math.PI;
            if (x < -Math.PI) x += 2 * Math.PI;

            double result = 0;
            double term = 1;
            int n = 1;

            for (int i = 0; i < 10; i++) // 10 итераций для точности
            {
                result += term;
                term *= -x * x / ((2 * n - 1) * (2 * n));
                n++;
            }

            return result;
        }
    }
}
