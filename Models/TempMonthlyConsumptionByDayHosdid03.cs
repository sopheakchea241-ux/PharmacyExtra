using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace PharmacyExtra.Web.Models;

[Keyless]
[Table("tempMonthlyConsumption_By_DayHOSDID03")]
public partial class TempMonthlyConsumptionByDayHosdid03
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

    [Column("9/07")]
    public int? _907 { get; set; }

    [Column("10/07")]
    public int? _1007 { get; set; }

    [Column("11/07")]
    public int? _1107 { get; set; }

    [Column("12/07")]
    public int? _1207 { get; set; }

    [Column("13/07")]
    public int? _1307 { get; set; }

    [Column("14/07")]
    public int? _1407 { get; set; }

    [Column("15/07")]
    public int? _1507 { get; set; }

    [Column("16/07")]
    public int? _1607 { get; set; }

    [Column("17/07")]
    public int? _1707 { get; set; }

    [Column("18/07")]
    public int? _1807 { get; set; }

    [Column("19/07")]
    public int? _1907 { get; set; }

    [Column("20/07")]
    public int? _2007 { get; set; }

    [Column("21/07")]
    public int? _2107 { get; set; }

    [Column("22/07")]
    public int? _2207 { get; set; }

    [Column("23/07")]
    public int? _2307 { get; set; }

    [Column("24/07")]
    public int? _2407 { get; set; }

    [Column("25/07")]
    public int? _2507 { get; set; }

    [Column("26/07")]
    public int? _2607 { get; set; }

    [Column("27/07")]
    public int? _2707 { get; set; }

    public double? Total { get; set; }
}
