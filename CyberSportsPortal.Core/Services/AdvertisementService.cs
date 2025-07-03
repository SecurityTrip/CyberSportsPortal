using CyberSportsPortal.Data;
using CyberSportsPortal.Data.Entities;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace CyberSportsPortal.Core.Services;

public class AdvertisementService
{
    private readonly CyberSportsContext _context;

    public AdvertisementService(CyberSportsContext context)
    {
        _context = context;
    }

    public async Task<List<AdvertisingCompany>> GetAdvertisingCompaniesAsync()
    {
        return await _context.AdvertisingCompanies.ToListAsync();
    }
}