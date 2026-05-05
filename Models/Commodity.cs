using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace PharmacyExtra.Web.Models;

[Table("Commodity")]
public partial class Commodity
{
    [Key]
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
    public bool UsedInMpa { get; set; }

    [Column("UsedInCPA1")]
    public bool UsedInCpa1 { get; set; }

    [Column("UsedInCPA2")]
    public bool UsedInCpa2 { get; set; }

    [Column("UsedInCPA3")]
    public bool UsedInCpa3 { get; set; }

    [Column("UsedInCPAS")]
    public bool UsedInCpas { get; set; }

    [Column("MPAMultiplier", TypeName = "decimal(10, 3)")]
    public decimal Mpamultiplier { get; set; }

    [Column("CPA1Multiplier", TypeName = "decimal(10, 3)")]
    public decimal Cpa1multiplier { get; set; }

    [Column("CPA2Multiplier", TypeName = "decimal(10, 3)")]
    public decimal Cpa2multiplier { get; set; }

    [Column("CPA3Multiplier", TypeName = "decimal(10, 3)")]
    public decimal Cpa3multiplier { get; set; }

    [Column("CPASMultiplier", TypeName = "decimal(10, 3)")]
    public decimal Cpasmultiplier { get; set; }

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

    public bool ExpRequire { get; set; }

    public bool IsActive { get; set; }

    [Column("IsOIARV")]
    public bool IsOiarv { get; set; }

    [ForeignKey("CommTypeId")]
    [InverseProperty("Commodities")]
    public virtual CommodityType? CommType { get; set; }

    [InverseProperty("Comm")]
    public virtual ICollection<CommodityTransactionDetail> CommodityTransactionDetails { get; set; } = new List<CommodityTransactionDetail>();

    [InverseProperty("Commodity")]
    public virtual ManualSelectCommodity? ManualSelectCommodity { get; set; }

    [InverseProperty("Commodity")]
    public virtual ICollection<SubReceiveDetail> SubReceiveDetails { get; set; } = new List<SubReceiveDetail>();

    [InverseProperty("Commodity")]
    public virtual ICollection<TblHosRequestDetail> TblHosRequestDetails { get; set; } = new List<TblHosRequestDetail>();

    [InverseProperty("Commodity")]
    public virtual ICollection<TblMainMonthlyTransactionDetail> TblMainMonthlyTransactionDetails { get; set; } = new List<TblMainMonthlyTransactionDetail>();

    [InverseProperty("Commodity")]
    public virtual ICollection<TblMainTransferInDetail> TblMainTransferInDetails { get; set; } = new List<TblMainTransferInDetail>();
}
