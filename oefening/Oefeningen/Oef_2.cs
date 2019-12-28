using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace First
{
    class Oef_2
    {
        /* In enums.cs vind je een enumeratie Priority. Laat de functie GeefAlarm(), afhankelijk van de priority
         * een gepaste melding als resultaat geven.
         * Zero -> "Geen actie vereist."
         * Low -> "Stand by.".
         * Medium -> "Activeer basisprotocol."
         * Important -> "Activeer uitgebreid protocol."
         * Critical -> "Evacueer het gebouw."
         */
        static public string GeefAlarm(Priority prioriteit)
        {
            return string.Empty;
        }

        /* De functie WijzigVolume() zal via een variabele volume een speaker aansturen. Afhankelijk van de waarde van volume
         * zal de speaker stiller of luider spelen.
         * Wijzig de waarde van de variabele volume als volgt a.h.v. de drie opties voorzien in de enum Volume:
         * - Low: geef de variabele volume de waarde 3
         * - Medium: geef de variabele volume de waarde 5
         * - High: geef de variabele volume de waarde 7
         * Geef de variabele volume als returnwaarde van de functie.
         */
        public static int WijzigVolume(Volume vol)
        {
            int volume = 0;

            return volume;
        }
    }
}
