using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace PharmacyExtra.Web.Models;

[Keyless]
public partial class VHospitalStockOnHandEnd
{
    [Column("CommodityID")]
    [StringLength(15)]
    public string? CommodityId { get; set; }

    [StringLength(100)]
    public string CommodityName { get; set; } = null!;

    [StringLength(10)]
    public string? Form { get; set; }

    [StringLength(30)]
    public string? Strength { get; set; }

    public long? Main { get; set; }

    [Column("SPH01")]
    public int? Sph01 { get; set; }

    [Column("SPH02")]
    public int? Sph02 { get; set; }

    [Column("SPH03")]
    public int? Sph03 { get; set; }

    [Column("SPH04")]
    public int? Sph04 { get; set; }

    public long? StockOnHand { get; set; }
}
