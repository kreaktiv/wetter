using System;

namespace Vertraege
{
    public class TaeglicheVorhersage
    {
        public DateTime Datum { get; set; }
        public int TemperaturMax { get; set; }
        public int TemperaturMin { get; set; }
        public string Bedingung { get; set; }
        public int Regenrisiko { get; set; }
    }
}
