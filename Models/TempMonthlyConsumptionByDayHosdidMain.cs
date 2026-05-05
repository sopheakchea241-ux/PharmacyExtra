using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace PharmacyExtra.Web.Models;

[Keyless]
[Table("tempMonthlyConsumption_By_DayHOSDID-MAIN")]
public partial class TempMonthlyConsumptionByDayHosdidMain
{
    [StringLength(15)]
    public string? Code { get; set; }

    [StringLength(100)]
    public string? Description { get; set; }

    [StringLength(10)]
    public string? Form { get; set; }

    [StringLength(30)]
    public string? Dose { get; set; }

    [Column("1/06")]
    public int? _106 { get; set; }

    [Column("2/06")]
    public int? _206 { get; set; }

    [Column("3/06")]
    public int? _306 { get; set; }

    [Column("4/06")]
    public int? _406 { get; set; }

    [Column("5/06")]
    public int? _506 { get; set; }

    [Column("6/06")]
    public int? _606 { get; set; }

    [Column("7/06")]
    public int? _706 { get; set; }

    [Column("8/06")]
    public int? _806 { get; set; }

    [Column("9/06")]
    public int? _906 { get; set; }

    [Column("10/06")]
    public int? _1006 { get; set; }

    [Column("11/06")]
    public int? _1106 { get; set; }

    [Column("12/06")]
    public int? _1206 { get; set; }

    [Column("13/06")]
    public int? _1306 { get; set; }

    [Column("14/06")]
    public int? _1406 { get; set; }

    [Column("15/06")]
    public int? _1506 { get; set; }

    [Column("16/06")]
    public int? _1606 { get; set; }

    [Column("17/06")]
    public int? _1706 { get; set; }

    [Column("18/06")]
    public int? _1806 { get; set; }

    [Column("19/06")]
    public int? _1906 { get; set; }

    [Column("20/06")]
    public int? _2006 { get; set; }

    [Column("21/06")]
    public int? _2106 { get; set; }

    [Column("22/06")]
    public int? _2206 { get; set; }

    [Column("23/06")]
    public int? _2306 { get; set; }

    [Column("24/06")]
    public int? _2406 { get; set; }

    [Column("25/06")]
    public int? _2506 { get; set; }

    [Column("26/06")]
    public int? _2606 { get; set; }

    [Column("27/06")]
    public int? _2706 { get; set; }

    [Column("28/06")]
    public int? _2806 { get; set; }

    [Column("29/06")]
    public int? _2906 { get; set; }

    [Column("30/06")]
    public int? _3006 { get; set; }

    public double? Total { get; set; }
}
