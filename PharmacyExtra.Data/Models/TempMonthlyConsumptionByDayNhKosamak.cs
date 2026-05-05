using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace PharmacyExtra.Web.Models;

[Keyless]
[Table("tempMonthlyConsumption_By_DayNH-KOSAMAK")]
public partial class TempMonthlyConsumptionByDayNhKosamak
{
    [StringLength(15)]
    public string? Code { get; set; }

    [StringLength(100)]
    public string? Description { get; set; }

    [StringLength(10)]
    public string? Form { get; set; }

    [StringLength(30)]
    public string? Dose { get; set; }

    [Column("1/09")]
    public int? _109 { get; set; }

    [Column("2/09")]
    public int? _209 { get; set; }

    [Column("3/09")]
    public int? _309 { get; set; }

    [Column("4/09")]
    public int? _409 { get; set; }

    [Column("5/09")]
    public int? _509 { get; set; }

    [Column("6/09")]
    public int? _609 { get; set; }

    [Column("7/09")]
    public int? _709 { get; set; }

    [Column("8/09")]
    public int? _809 { get; set; }

    [Column("9/09")]
    public int? _909 { get; set; }

    [Column("10/09")]
    public int? _1009 { get; set; }

    [Column("11/09")]
    public int? _1109 { get; set; }

    [Column("12/09")]
    public int? _1209 { get; set; }

    [Column("13/09")]
    public int? _1309 { get; set; }

    [Column("14/09")]
    public int? _1409 { get; set; }

    [Column("15/09")]
    public int? _1509 { get; set; }

    [Column("16/09")]
    public int? _1609 { get; set; }

    [Column("17/09")]
    public int? _1709 { get; set; }

    [Column("18/09")]
    public int? _1809 { get; set; }

    [Column("19/09")]
    public int? _1909 { get; set; }

    [Column("20/09")]
    public int? _2009 { get; set; }

    [Column("21/09")]
    public int? _2109 { get; set; }

    [Column("22/09")]
    public int? _2209 { get; set; }

    [Column("23/09")]
    public int? _2309 { get; set; }

    [Column("24/09")]
    public int? _2409 { get; set; }

    [Column("25/09")]
    public int? _2509 { get; set; }

    [Column("26/09")]
    public int? _2609 { get; set; }

    [Column("27/09")]
    public int? _2709 { get; set; }

    [Column("28/09")]
    public int? _2809 { get; set; }

    [Column("29/09")]
    public int? _2909 { get; set; }

    [Column("30/09")]
    public int? _3009 { get; set; }

    public double? Total { get; set; }
}
