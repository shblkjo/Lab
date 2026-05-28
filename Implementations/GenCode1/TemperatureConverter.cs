using Lab.Interfaces;
// AliceAI

namespace Lab.Implementations.GenCode1
{
    public class TemperatureConverter : ITemperatureConverter
    {
        // Êîíñòàíòû äëÿ àáñîëþòíîãî íóëÿ â ðàçíûõ åäèíèöàõ èçìåðåíèÿ
        private const double AbsoluteZeroCelsius = -273.15;
        private const double AbsoluteZeroFahrenheit = -459.67;
        private const double AbsoluteZeroKelvin = 0.0;

        /// <summary>
        /// Ïðåîáðàçóåò Êåëüâèíû â Öåëüñèè.
        /// </summary>
        /// <param name="kelvin">Òåìïåðàòóðà â Êåëüâèíàõ</param>
        /// <returns>Òåìïåðàòóðà â Öåëüñèÿõ</returns>
        /// <exception cref="ArgumentOutOfRangeException">Âûáðàñûâàåòñÿ, åñëè òåìïåðàòóðà íèæå àáñîëþòíîãî íóëÿ</exception>
        public double KelvinToCelsius(double kelvin)
        {
            if (kelvin < AbsoluteZeroKelvin)
                throw new ArgumentOutOfRangeException(nameof(kelvin),
                    $"Òåìïåðàòóðà íå ìîæåò áûòü íèæå àáñîëþòíîãî íóëÿ ({AbsoluteZeroKelvin} K)");

            return kelvin - 273.15;
        }

        /// <summary>
        /// Ïðåîáðàçóåò Ôàðåíãåéòû â Öåëüñèè.
        /// </summary>
        /// <param name="fahrenheit">Òåìïåðàòóðà â Ôàðåíãåéòàõ</param>
        /// <returns>Òåìïåðàòóðà â Öåëüñèÿõ</returns>
        /// <exception cref="ArgumentOutOfRangeException">Âûáðàñûâàåòñÿ, åñëè òåìïåðàòóðà íèæå àáñîëþòíîãî íóëÿ</exception>
        public double FahrenheitToCelsius(double fahrenheit)
        {
            if (fahrenheit < AbsoluteZeroFahrenheit)
                throw new ArgumentOutOfRangeException(nameof(fahrenheit),
                    $"Òåìïåðàòóðà íå ìîæåò áûòü íèæå àáñîëþòíîãî íóëÿ ({AbsoluteZeroFahrenheit} °F)");

            return (fahrenheit - 32) * 5 / 9;
        }

        /// <summary>
        /// Ïðåîáðàçóåò Öåëüñèè â Êåëüâèíû.
        /// </summary>
        /// <param name="celsius">Òåìïåðàòóðà â Öåëüñèÿõ</param>
        /// <returns>Òåìïåðàòóðà â Êåëüâèíàõ</returns>
        /// <exception cref="ArgumentOutOfRangeException">Âûáðàñûâàåòñÿ, åñëè òåìïåðàòóðà íèæå àáñîëþòíîãî íóëÿ</exception>
        public double CelsiusToKelvin(double celsius)
        {
            if (celsius < AbsoluteZeroCelsius)
                throw new ArgumentOutOfRangeException(nameof(celsius),
                    $"Òåìïåðàòóðà íå ìîæåò áûòü íèæå àáñîëþòíîãî íóëÿ ({AbsoluteZeroCelsius} °C)");

            return celsius + 273.15;
        }

        /// <summary>
        /// Ïðåîáðàçóåò Ôàðåíãåéòû â Êåëüâèíû.
        /// </summary>
        /// <param name="fahrenheit">Òåìïåðàòóðà â Ôàðåíãåéòàõ</param>
        /// <returns>Òåìïåðàòóðà â Êåëüâèíàõ</returns>
        /// <exception cref="ArgumentOutOfRangeException">Âûáðàñûâàåòñÿ, åñëè òåìïåðàòóðà íèæå àáñîëþòíîãî íóëÿ</exception>
        public double FahrenheitToKelvin(double fahrenheit)
        {
            if (fahrenheit < AbsoluteZeroFahrenheit)
                throw new ArgumentOutOfRangeException(nameof(fahrenheit),
                    $"Òåìïåðàòóðà íå ìîæåò áûòü íèæå àáñîëþòíîãî íóëÿ ({AbsoluteZeroFahrenheit} °F)");

            return (fahrenheit + 459.67) * 5 / 9;
        }

        /// <summary>
        /// Ïðåîáðàçóåò Öåëüñèè â Ôàðåíãåéòû.
        /// </summary>
        /// <param name="celsius">Òåìïåðàòóðà â Öåëüñèÿõ</param>
        /// <returns>Òåìïåðàòóðà â Ôàðåíãåéòàõ</returns>
        /// <exception cref="ArgumentOutOfRangeException">Âûáðàñûâàåòñÿ, åñëè òåìïåðàòóðà íèæå àáñîëþòíîãî íóëÿ</exception>
        public double CelsiusToFahrenheit(double celsius)
        {
            if (celsius < AbsoluteZeroCelsius)
                throw new ArgumentOutOfRangeException(nameof(celsius),
                    $"Òåìïåðàòóðà íå ìîæåò áûòü íèæå àáñîëþòíîãî íóëÿ ({AbsoluteZeroCelsius} °C)");

            return (celsius * 9 / 5) + 32;
        }

        /// <summary>
        /// Ïðåîáðàçóåò Êåëüâèíû â Ôàðåíãåéòû.
        /// </summary>
        /// <param name="kelvin">Òåìïåðàòóðà â Êåëüâèíàõ</param>
        /// <returns>Òåìïåðàòóðà â Ôàðåíãåéòàõ</returns>
        /// <exception cref="ArgumentOutOfRangeException">Âûáðàñûâàåòñÿ, åñëè òåìïåðàòóðà íèæå àáñîëþòíîãî íóëÿ</exception>
        public double KelvinToFahrenheit(double kelvin)
        {
            if (kelvin < AbsoluteZeroKelvin)
                throw new ArgumentOutOfRangeException(nameof(kelvin),
                    $"Òåìïåðàòóðà íå ìîæåò áûòü íèæå àáñîëþòíîãî íóëÿ ({AbsoluteZeroKelvin} K)");

            return (kelvin * 9 / 5) - 459.67;
        }
    }
}
