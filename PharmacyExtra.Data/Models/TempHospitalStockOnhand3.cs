using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace PharmacyExtra.Web.Models;

[Keyless]
[Table("tempHospitalStockOnhand", Schema = "SreypovMain")]
public partial class TempHospitalStockOnhand3
{
    [StringLength(15)]
    public string? Code { get; set; }

    [StringLength(100)]
    public string? CommodityName { get; set; }

    [StringLength(10)]
    public string? Form { get; set; }

    [StringLength(30)]
    public string? Strength { get; set; }

    public double? Main { get; set; }

    [Column("SPH01")]
    public double? Sph01 { get; set; }

    [Column("SPH02")]
    public double? Sph02 { get; set; }

    public double? Total { get; set; }
}
