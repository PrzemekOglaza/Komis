using System.Collections.Generic;

namespace Komis.Models
{
    interface ISamochodRepository
    {
        IEnumerable<Samochod> PobierzWszystkieSamochody();
        Samochod PobierzSamochodId(int SamochodId);
    }
}
