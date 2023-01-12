using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kata_Temperaturas
{
    class Temperature
    {
        public enum TemperatureScale { C, F, K }

        private double _value;
        public double Value { get { return _value; } }
        public TemperatureScale Scale { get; private set; }

        public Temperature(double value, TemperatureScale scale)
        {
            _value = value;
            Scale = scale;
        }

        public Temperature Add(Temperature other)
        {
            return new Temperature(Value + other.Value, Scale);
        }

        public Temperature Subtract(Temperature other)
        {
            return new Temperature(Value - other.Value, Scale);
        }

        public Temperature MultiplyBy(Temperature other)
        {
            return new Temperature(Value * other.Value, Scale);
        }

        public Temperature DivideBy(Temperature other)
        {
            return new Temperature(Value / other.Value, Scale);
        }

        public Temperature ToFahrenheit()
        {
            if (Scale == TemperatureScale.F)
                return this;
            else if (Scale == TemperatureScale.C)
                return new Temperature((Value * 9 / 5) + 32, TemperatureScale.F);
            else
                return new Temperature((Value - 273.15) * 9 / 5 + 32, TemperatureScale.F);
        }

        public Temperature ToCelsius()
        {
            if (Scale == TemperatureScale.C)
                return this;
            else if (Scale == TemperatureScale.F)
                return new Temperature((Value - 32) * 5 / 9, TemperatureScale.C);
            else
                return new Temperature(Value - 273.15, TemperatureScale.C);
        }

        public Temperature ToKelvin()
        {
            if (Scale == TemperatureScale.K)
                return this;
            else if (Scale == TemperatureScale.F)
                return new Temperature((Value + 459.67) * 5 / 9, TemperatureScale.K);
            else
                return new Temperature(Value + 273.15, TemperatureScale.K);
        }

        public override string ToString()
        {
            string scale = Scale == TemperatureScale.C ? "C" : Scale == TemperatureScale.F ? "F" : "K";
            return Value + scale;
        }
    }
}
