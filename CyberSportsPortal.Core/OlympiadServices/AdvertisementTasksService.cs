using CyberSportsPortal.Data.Entities;
using System;
using System.Collections.Generic;
using System.Linq;

namespace CyberSportsPortal.Core.OlympiadServices;

public class AdvertisementTasksService
{
    public List<KeyValuePair<int, int>> GetProbabilities(List<AdvertisingCompany> companies)
    {
        var weights = new List<KeyValuePair<int, int>>();

        if (companies == null || companies.Count == 0)
            return weights;

        decimal total = 0;
        int currentYear = DateTime.UtcNow.Year;
        var companyPayments = new Dictionary<int, decimal>();

        foreach (var company in companies)
        {
            decimal yearlySum = 0;

            if (company?.AdvertisementPaymentInfos != null)
            {
                foreach (var payment in company.AdvertisementPaymentInfos)
                {
                    if (payment?.PaymentDate.Year == currentYear)
                    {
                        yearlySum += payment.PaymentSum;
                    }
                }
            }

            companyPayments[company.Id] = yearlySum;
            total += yearlySum;
        }

        foreach (var company in companies)
        {
            if (company == null)
                continue;

            decimal payments = companyPayments.GetValueOrDefault(company.Id);
            int probability = 0;

            if (total > 0)
            {
                probability = (int)Math.Floor(payments / total) == 0 ? 1 : (int)Math.Floor(payments / total);
            }

            weights.Add(new KeyValuePair<int, int>(company.Id, probability));
        }

        return weights;
    }
}