using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace PharmacyExtra.Web.Models;

[Keyless]
public partial class VYearlyEstimate
{
    [StringLength(15)]
    public string Code { get; set; } = null!;

    [StringLength(100)]
    public string Name { get; set; } = null!;

    [StringLength(10)]
    public string? Form { get; set; }

    [StringLength(30)]
    public string? Strength { get; set; }

    [Column("SOH")]
    public long? Soh { get; set; }

    [Column("AMC")]
    public double? Amc { get; set; }

    public long? Needs { get; set; }

    public long? Recommended { get; set; }

    [StringLength(60)]
    public string Type { get; set; } = null!;

    [Column("CommTypeID")]
    [StringLength(5)]
    public string CommTypeId { get; set; } = null!;

    [Column("ID")]
    public long Id { get; set; }

    public long? Incoming { get; set; }

    public long? Outgoing { get; set; }
}
