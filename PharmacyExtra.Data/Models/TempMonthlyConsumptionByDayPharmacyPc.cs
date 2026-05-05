using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace PharmacyExtra.Web.Models;

[Keyless]
[Table("tempMonthlyConsumption_By_DayPHARMACY-PC")]
public partial class TempMonthlyConsumptionByDayPharmacyPc
{
    [StringLength(15)]
    public string? Code { get; set; }

    [StringLength(100)]
    public string? Description { get; set; }

    [StringLength(10)]
    public string? Form { get; set; }

    [StringLength(30)]
    public string? Dose { get; set; }

    [Column("20/10")]
    public int? _2010 { get; set; }

    public double? Total { get; set; }
}
