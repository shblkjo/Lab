using System;
using Lab.Interfaces;
// Deepseek

namespace Lab.Implementations.GenCode3
{
    /// <summary>
    /// Конвертер температур между шкалами Цельсия, Фаренгейта и Кельвина
    /// </summary>
    public class TemperatureConverter : ITemperatureConverter
    {
        private const double AbsoluteZeroCelsius = -273.15;
        private const double AbsoluteZeroFahrenheit = -459.67;
        private const double AbsoluteZeroKelvin = 0;

        /// <summary>
        /// Проверяет, что температура по Цельсию не ниже абсолютного нуля
        /// </summary>
        private void ValidateCelsius(double celsius)
        {
            if (celsius < AbsoluteZeroCelsius)
                throw new ArgumentOutOfRangeException(nameof(celsius),
                    $"Температура не может быть ниже абсолютного нуля ({AbsoluteZeroCelsius}°C)");
        }

        /// <summary>
        /// Проверяет, что температура по Фаренгейту не ниже абсолютного нуля
        /// </summary>
        private void ValidateFahrenheit(double fahrenheit)
        {
            if (fahrenheit < AbsoluteZeroFahrenheit)
                throw new ArgumentOutOfRangeException(nameof(fahrenheit),
                    $"Температура не может быть ниже абсолютного нуля ({AbsoluteZeroFahrenheit}°F)");
        }

        /// <summary>
        /// Проверяет, что температура по Кельвину не ниже абсолютного нуля
        /// </summary>
        private void ValidateKelvin(double kelvin)
        {
            if (kelvin < AbsoluteZeroKelvin)
                throw new ArgumentOutOfRangeException(nameof(kelvin),
                    $"Температура не может быть ниже абсолютного нуля ({AbsoluteZeroKelvin} K)");
        }

        public double KelvinToCelsius(double kelvin)
        {
            ValidateKelvin(kelvin);
            return kelvin - 273.15;
        }

        public double FahrenheitToCelsius(double fahrenheit)
        {
            ValidateFahrenheit(fahrenheit);
            return (fahrenheit - 32) * 5 / 9;
        }

        public double CelsiusToKelvin(double celsius)
        {
            ValidateCelsius(celsius);
            return celsius + 273.15;
        }

        public double FahrenheitToKelvin(double fahrenheit)
        {
            ValidateFahrenheit(fahrenheit);
            return (fahrenheit + 459.67) * 5 / 9;
        }

        public double CelsiusToFahrenheit(double celsius)
        {
            ValidateCelsius(celsius);
            return (celsius * 9 / 5) + 32;
        }

        public double KelvinToFahrenheit(double kelvin)
        {
            ValidateKelvin(kelvin);
            return (kelvin * 9 / 5) - 459.67;
        }
    }
}