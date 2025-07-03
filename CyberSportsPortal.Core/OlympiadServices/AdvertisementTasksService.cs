using CyberSportsPortal.Data.Entities;
using System.Collections.Generic;

namespace CyberSportsPortal.Core.OlympiadServices;

public class AdvertisementTasksService
{
    public List<KeyValuePair<int, int>> GetProbabilities(List<AdvertisingCompany> companies)
    {
        return new List<KeyValuePair<int, int>>
        {
            new KeyValuePair<int, int>(1,50),
            new KeyValuePair<int, int>(2,50)
        };
    }
}