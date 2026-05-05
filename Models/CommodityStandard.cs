using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace PharmacyExtra.Web.Models;

[Keyless]
[Table("Commodity Standard")]
public partial class CommodityStandard
{
    [Column("CommodityID")]
    [StringLength(10)]
    public string? CommodityId { get; set; }

    [StringLength(200)]
    public string? CommodityName { get; set; }

    [Column("CommTypeID")]
    [StringLength(10)]
    public string? CommTypeId { get; set; }

    [StringLength(10)]
    public string? CommAbbrev { get; set; }

    [StringLength(15)]
    public string? CommForm { get; set; }

    [StringLength(15)]
    public string? MedicineStrength { get; set; }

    [Column("UsedINCPASpecial")]
    public bool UsedIncpaspecial { get; set; }

    [Column("UsedINCPA")]
    public bool UsedIncpa { get; set; }

    [Column("UsedINMPA")]
    public bool UsedInmpa { get; set; }

    [Column("UsedINKhum")]
    public bool UsedInkhum { get; set; }

    public bool Active { get; set; }

    public int? Multiplier { get; set; }

    [Column("MPAMultiplier")]
    public double? Mpamultiplier { get; set; }

    [Column("CPAMultiplier")]
    public double? Cpamultiplier { get; set; }

    [Column("CPASMultiplier")]
    public double? Cpasmultiplier { get; set; }

    [StringLength(250)]
    public string? CommodityNote { get; set; }

    [Column("HC_Order")]
    public double? HcOrder { get; set; }

    [Column("NonHC_Order")]
    public double? NonHcOrder { get; set; }

    [Column("AnnDisp_Order")]
    public double? AnnDispOrder { get; set; }

    [Column("upsize_ts")]
    [StringLength(250)]
    public string? UpsizeTs { get; set; }

    public bool ExpRequire { get; set; }

    public int? KhumMult { get; set; }
}
