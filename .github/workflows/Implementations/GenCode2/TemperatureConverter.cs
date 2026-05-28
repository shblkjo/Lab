using Lab.Interfaces;
using System;
// Qwen

namespace Lab.Implementations.GenCode2
{
    public class TemperatureConverter : ITemperatureConverter
    {
        // Физические константы абсолютного нуля
        private const double AbsoluteZeroCelsius = -273.15;
        private const double AbsoluteZeroFahrenheit = -459.67;
        private const double AbsoluteZeroKelvin = 0.0;

        /// <summary>
        /// Преобразует Кельвины в Цельсии.
        /// </summary>
        public double KelvinToCelsius(double kelvin)
        {
            if (kelvin < AbsoluteZeroKelvin)
            {
                throw new ArgumentOutOfRangeException(nameof(kelvin),
                    $"Температура в Кельвинах не может быть ниже {AbsoluteZeroKelvin} (абсолютный ноль).");
            }

            return kelvin - 273.15;
        }

        /// <summary>
        /// Преобразует Фаренгейты в Цельсии.
        /// </summary>
        public double FahrenheitToCelsius(double fahrenheit)
        {
            if (fahrenheit < AbsoluteZeroFahrenheit)
            {
                throw new ArgumentOutOfRangeException(nameof(fahrenheit),
                    $"Температура в Фаренгейтах не может быть ниже {AbsoluteZeroFahrenheit} (абсолютный ноль).");
            }

            return (fahrenheit - 32) * 5.0 / 9.0;
        }

        /// <summary>
        /// Преобразует Цельсии в Кельвины.
        /// </summary>
        public double CelsiusToKelvin(double celsius)
        {
            if (celsius < AbsoluteZeroCelsius)
            {
                throw new ArgumentOutOfRangeException(nameof(celsius),
                    $"Температура в Цельсиях не может быть ниже {AbsoluteZeroCelsius} (абсолютный ноль).");
            }

            return celsius + 273.15;
        }

        /// <summary>
        /// Преобразует Фаренгейты в Кельвины.
        /// </summary>
        public double FahrenheitToKelvin(double fahrenheit)
        {
            if (fahrenheit < AbsoluteZeroFahrenheit)
            {
                throw new ArgumentOutOfRangeException(nameof(fahrenheit),
                    $"Температура в Фаренгейтах не может быть ниже {AbsoluteZeroFahrenheit} (абсолютный ноль).");
            }

            return (fahrenheit + 459.67) * 5.0 / 9.0;
        }

        /// <summary>
        /// Преобразует Цельсии в Фаренгейты.
        /// </summary>
        public double CelsiusToFahrenheit(double celsius)
        {
            if (celsius < AbsoluteZeroCelsius)
            {
                throw new ArgumentOutOfRangeException(nameof(celsius),
                    $"Температура в Цельсиях не может быть ниже {AbsoluteZeroCelsius} (абсолютный ноль).");
            }

            return (celsius * 9.0 / 5.0) + 32;
        }

        /// <summary>
        /// Преобразует Кельвины в Фаренгейты.
        /// </summary>
        public double KelvinToFahrenheit(double kelvin)
        {
            if (kelvin < AbsoluteZeroKelvin)
            {
                throw new ArgumentOutOfRangeException(nameof(kelvin),
                    $"Температура в Кельвинах не может быть ниже {AbsoluteZeroKelvin} (абсолютный ноль).");
            }

            return (kelvin * 9.0 / 5.0) - 459.67;
        }
    }
}