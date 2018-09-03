using System.Collections.Generic;

namespace Vertraege
{
    public class Vorhersage
    {
        public IEnumerable<StuendlicheVorhersage> Heute { get; set; }
        public IEnumerable<TaeglicheVorhersage> Demnaechst { get; set; }
    }
}
