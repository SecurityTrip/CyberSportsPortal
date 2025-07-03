using CyberSportsPortal.Data.Model.Enums;
using System.Collections.Generic;

namespace CyberSportsPortal.Services;

public class CountryFlagService
{
    private Dictionary<Country, string> Flags = new Dictionary<Country, string>
    {
        { Country.Белоруссия, "flag-icon-blr" },
        { Country.Болгария, "flag-icon-bgr" },
        { Country.Канада, "flag-icon-can" },
        { Country.Китай, "flag-icon-chn" },
        { Country.Дания, "flag-icon-dnk" },
        { Country.Эстония, "flag-icon-est" },
        { Country.Финляндия, "flag-icon-fin" },
        { Country.Франция, "flag-icon-fra" },
        { Country.Германия, "flag-icon-deu" },
        { Country.Индонезия, "flag-icon-idn" },
        { Country.Израиль, "flag-icon-isr" },
        { Country.Иордания, "flag-icon-jor" },
        { Country.Ливан, "flag-icon-lbn" },
        { Country.Македония, "flag-icon-mkd" },
        { Country.Малайзия, "flag-icon-mys" },
        { Country.Молдавия, "flag-icon-mda" },
        { Country.Норвегия, "flag-icon-nor" },
        { Country.Пакистан, "flag-icon-pak" },
        { Country.Филиппины, "flag-icon-phl" },
        { Country.Польша, "flag-icon-pol" },
        { Country.Россия, "flag-icon-rus" },
        { Country.Сингапур, "flag-icon-sgp" },
        { Country.Словакия, "flag-icon-svk" },
        { Country.Швеция, "flag-icon-swe" },
        { Country.Тайланд, "flag-icon-tha" },
        { Country.Сша, "flag-icon-usa" }
    };

    public string GetFlagClassName(Country country)
    {
        return Flags.TryGetValue(country, out var result) ? result : string.Empty;
    }
}