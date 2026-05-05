using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace PharmacyExtra.Web.Models;

[Keyless]
[Table("tempMonthlyConsumption_By_DayHOSDID02")]
public partial class TempMonthlyConsumptionByDayHosdid02
{
    [StringLength(15)]
    public string? Code { get; set; }

    [StringLength(100)]
    public string? Description { get; set; }

    [StringLength(10)]
    public string? Form { get; set; }

    [StringLength(30)]
    public string? Dose { get; set; }

    [Column("1/07")]
    public int? _107 { get; set; }

    [Column("2/07")]
    public int? _207 { get; set; }

    [Column("3/07")]
    public int? _307 { get; set; }

    [Column("4/07")]
    public int? _407 { get; set; }

    [Column("5/07")]
    public int? _507 { get; set; }

    [Column("6/07")]
    public int? _607 { get; set; }

    [Column("7/07")]
    public int? _707 { get; set; }

    [Column("8/07")]
    public int? _807 { get; set; }

    public double? Total { get; set; }
}
