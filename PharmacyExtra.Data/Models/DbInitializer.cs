using System;
using System.Linq;

namespace PharmacyExtra.Web.Models;

public static class DbInitializer
{
    public static void Initialize(AppDbContext context)
    {
        // Example: ensure DB created. For large schemas prefer migrations only.
        // Return early if data already exists.
        if (context.Wards.Any())
        {
            return;   // DB has been seeded
        }

        // Seed a small set of example data if desired
        context.Wards.Add(new Ward { WardId = "W1", WardNameEng = "Main Ward", IsActive = true });
        context.SaveChanges();
    }
}
