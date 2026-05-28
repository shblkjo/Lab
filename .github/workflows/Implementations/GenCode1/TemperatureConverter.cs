using Lab.Interfaces;
// AliceAI

namespace Lab.Implementations.GenCode1
{
#error version
    public class TemperatureConverter : ITemperatureConverter
    {
        // Константы для абсолютного нуля в разных единицах измерения
        private const double AbsoluteZeroCelsius = -273.15;
        private const double AbsoluteZeroFahrenheit = -459.67;
        private const double AbsoluteZeroKelvin = 0.0;

        /// <summary>
        /// Преобразует Кельвины в Цельсии.
        /// </summary>
        /// <param name="kelvin">Температура в Кельвинах</param>
        /// <returns>Температура в Цельсиях</returns>
        /// <exception cref="ArgumentOutOfRangeException">Выбрасывается, если температура ниже абсолютного нуля</exception>
        public double KelvinToCelsius(double kelvin)
        {
            if (kelvin < AbsoluteZeroKelvin)
                throw new ArgumentOutOfRangeException(nameof(kelvin),
                    $"Температура не может быть ниже абсолютного нуля ({AbsoluteZeroKelvin} K)");

            return kelvin - 273.15;
        }

        /// <summary>
        /// Преобразует Фаренгейты в Цельсии.
        /// </summary>
        /// <param name="fahrenheit">Температура в Фаренгейтах</param>
        /// <returns>Температура в Цельсиях</returns>
        /// <exception cref="ArgumentOutOfRangeException">Выбрасывается, если температура ниже абсолютного нуля</exception>
        public double FahrenheitToCelsius(double fahrenheit)
        {
            if (fahrenheit < AbsoluteZeroFahrenheit)
                throw new ArgumentOutOfRangeException(nameof(fahrenheit),
                    $"Температура не может быть ниже абсолютного нуля ({AbsoluteZeroFahrenheit} °F)");

            return (fahrenheit - 32) * 5 / 9;
        }

        /// <summary>
        /// Преобразует Цельсии в Кельвины.
        /// </summary>
        /// <param name="celsius">Температура в Цельсиях</param>
        /// <returns>Температура в Кельвинах</returns>
        /// <exception cref="ArgumentOutOfRangeException">Выбрасывается, если температура ниже абсолютного нуля</exception>
        public double CelsiusToKelvin(double celsius)
        {
            if (celsius < AbsoluteZeroCelsius)
                throw new ArgumentOutOfRangeException(nameof(celsius),
                    $"Температура не может быть ниже абсолютного нуля ({AbsoluteZeroCelsius} °C)");

            return celsius + 273.15;
        }

        /// <summary>
        /// Преобразует Фаренгейты в Кельвины.
        /// </summary>
        /// <param name="fahrenheit">Температура в Фаренгейтах</param>
        /// <returns>Температура в Кельвинах</returns>
        /// <exception cref="ArgumentOutOfRangeException">Выбрасывается, если температура ниже абсолютного нуля</exception>
        public double FahrenheitToKelvin(double fahrenheit)
        {
            if (fahrenheit < AbsoluteZeroFahrenheit)
                throw new ArgumentOutOfRangeException(nameof(fahrenheit),
                    $"Температура не может быть ниже абсолютного нуля ({AbsoluteZeroFahrenheit} °F)");

            return (fahrenheit + 459.67) * 5 / 9;
        }

        /// <summary>
        /// Преобразует Цельсии в Фаренгейты.
        /// </summary>
        /// <param name="celsius">Температура в Цельсиях</param>
        /// <returns>Температура в Фаренгейтах</returns>
        /// <exception cref="ArgumentOutOfRangeException">Выбрасывается, если температура ниже абсолютного нуля</exception>
        public double CelsiusToFahrenheit(double celsius)
        {
            if (celsius < AbsoluteZeroCelsius)
                throw new ArgumentOutOfRangeException(nameof(celsius),
                    $"Температура не может быть ниже абсолютного нуля ({AbsoluteZeroCelsius} °C)");

            return (celsius * 9 / 5) + 32;
        }

        /// <summary>
        /// Преобразует Кельвины в Фаренгейты.
        /// </summary>
        /// <param name="kelvin">Температура в Кельвинах</param>
        /// <returns>Температура в Фаренгейтах</returns>
        /// <exception cref="ArgumentOutOfRangeException">Выбрасывается, если температура ниже абсолютного нуля</exception>
        public double KelvinToFahrenheit(double kelvin)
        {
            if (kelvin < AbsoluteZeroKelvin)
                throw new ArgumentOutOfRangeException(nameof(kelvin),
                    $"Температура не может быть ниже абсолютного нуля ({AbsoluteZeroKelvin} K)");

            return (kelvin * 9 / 5) - 459.67;
        }
    }
}
