using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace PharmacyExtra.Web.Models;

[Keyless]
[Table("tmpCommodity")]
public partial class TmpCommodity
{
    [Column("CommodityID")]
    [StringLength(15)]
    public string CommodityId { get; set; } = null!;

    [StringLength(100)]
    public string CommodityName { get; set; } = null!;

    [Column("CommTypeID")]
    [StringLength(5)]
    public string? CommTypeId { get; set; }

    [StringLength(30)]
    public string? CommAbbrev { get; set; }

    [StringLength(10)]
    public string? Form { get; set; }

    [StringLength(30)]
    public string? Strength { get; set; }

    [Column("CommCateID")]
    [StringLength(5)]
    public string? CommCateId { get; set; }

    [Column("UsedInMPA")]
    public bool? UsedInMpa { get; set; }

    [Column("UsedInCPA1")]
    public bool? UsedInCpa1 { get; set; }

    [Column("UsedInCPA2")]
    public bool? UsedInCpa2 { get; set; }

    [Column("UsedInCPA3")]
    public bool? UsedInCpa3 { get; set; }

    [Column("UsedInCPAS")]
    public bool? UsedInCpas { get; set; }

    [Column("MPAMultiplier")]
    public float? Mpamultiplier { get; set; }

    [Column("CPA1Multiplier")]
    public float? Cpa1multiplier { get; set; }

    [Column("CPA2Multiplier")]
    public float? Cpa2multiplier { get; set; }

    [Column("CPA3Multiplier")]
    public float? Cpa3multiplier { get; set; }

    [Column("CPASMultiplier")]
    public float? Cpasmultiplier { get; set; }

    public bool? ExpDate { get; set; }

    [Column(TypeName = "smalldatetime")]
    public DateTime? InsertedDate { get; set; }

    [StringLength(15)]
    public string? InsertedBy { get; set; }

    [Column(TypeName = "smalldatetime")]
    public DateTime? ModifiedDate { get; set; }

    [StringLength(15)]
    public string? ModifiedBy { get; set; }

    [Column("AnnDisp_Order")]
    public int? AnnDispOrder { get; set; }

    [Column("Upsize_ts")]
    [StringLength(50)]
    public string? UpsizeTs { get; set; }

    public bool? ExpRequire { get; set; }

    public bool? IsActive { get; set; }
}
