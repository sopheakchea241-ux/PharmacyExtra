using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace PharmacyExtra.Web.Models;

[Keyless]
[Table("tempMonthlyConsumption_By_DayADMIN-1C24D7503")]
public partial class TempMonthlyConsumptionByDayAdmin1c24d7503
{
    [StringLength(15)]
    public string? Code { get; set; }

    [StringLength(100)]
    public string? Description { get; set; }

    [StringLength(10)]
    public string? Form { get; set; }

    [StringLength(30)]
    public string? Dose { get; set; }

    [Column("1/01")]
    public int? _101 { get; set; }

    [Column("2/01")]
    public int? _201 { get; set; }

    [Column("3/01")]
    public int? _301 { get; set; }

    [Column("4/01")]
    public int? _401 { get; set; }

    [Column("5/01")]
    public int? _501 { get; set; }

    [Column("6/01")]
    public int? _601 { get; set; }

    [Column("7/01")]
    public int? _701 { get; set; }

    [Column("8/01")]
    public int? _801 { get; set; }

    [Column("9/01")]
    public int? _901 { get; set; }

    [Column("10/01")]
    public int? _1001 { get; set; }

    [Column("11/01")]
    public int? _1101 { get; set; }

    [Column("12/01")]
    public int? _1201 { get; set; }

    [Column("13/01")]
    public int? _1301 { get; set; }

    [Column("14/01")]
    public int? _1401 { get; set; }

    [Column("15/01")]
    public int? _1501 { get; set; }

    [Column("16/01")]
    public int? _1601 { get; set; }

    [Column("17/01")]
    public int? _1701 { get; set; }

    public double? Total { get; set; }
}
