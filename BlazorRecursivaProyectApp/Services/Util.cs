using System.Text.RegularExpressions;

namespace BlazorRecursivaProyectApp.Services
{
    public static class Util
    {
        public static string calculateZodiacSign(DateTime birthDate)
        {
            int day = birthDate.Day;
            int month = birthDate.Month;

            // Determinar el signo según el mes y el día
            return month switch
            {
                1 => (day <= 19) ? "Capricorn" : "Aquarius",
                2 => (day <= 18) ? "Aquarius" : "Pisces",
                3 => (day <= 20) ? "Pisces" : "Aries",
                4 => (day <= 19) ? "Aries" : "Taurus",
                5 => (day <= 20) ? "Taurus" : "Gemini",
                6 => (day <= 20) ? "Gemini" : "Cancer",
                7 => (day <= 22) ? "Cancer" : "Leo",
                8 => (day <= 22) ? "Leo" : "Virgo",
                9 => (day <= 22) ? "Virgo" : "Libra",
                10 => (day <= 22) ? "Libra" : "Scorpio",
                11 => (day <= 21) ? "Scorpio" : "Sagittarius",
                12 => (day <= 21) ? "Sagittarius" : "Capricorn",

                _ => throw new ArgumentOutOfRangeException("Fecha inválida")
            };
        }

        public static bool validateEmail(string email) {
            var emailPattern = @"^[^@\s]+@[^@\s]+\.[^@\s]+$";
            return Regex.IsMatch(email ?? "", emailPattern);
        }

        public static int calculateDaysUntilNextBirthday(DateTime birthDate)
        {
            // Obtener la fecha actual
            DateTime today = DateTime.Today;

            // Crear una nueva fecha para el próximo cumpleaños
            DateTime nextBirthday = new DateTime(today.Year, birthDate.Month, birthDate.Day);

            // Si el cumpleaños de este año ya pasó, usar el próximo año
            if (nextBirthday < today)
            {
                nextBirthday = nextBirthday.AddYears(1);
            }

            // Calcular la diferencia en días
            return (nextBirthday - today).Days;
        }

    }
}
