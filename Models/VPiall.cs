using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace PharmacyExtra.Web.Models;

[Keyless]
public partial class VPiall
{
    [Column("PIID")]
    public int? Piid { get; set; }

    [Column(TypeName = "smalldatetime")]
    public DateTime? LastStockDate { get; set; }

    [Column("CommodityID")]
    [StringLength(15)]
    public string? CommodityId { get; set; }

    [StringLength(100)]
    public string CommodityName { get; set; } = null!;

    [StringLength(10)]
    public string? Form { get; set; }

    [StringLength(30)]
    public string? Strength { get; set; }

    public long? CurrentStock { get; set; }

    public long? StockCount { get; set; }

    public double? AdjQty { get; set; }

    [StringLength(100)]
    public string? TransNote { get; set; }

    [Column(TypeName = "smalldatetime")]
    public DateTime? ExpDate { get; set; }

    [Column(TypeName = "smalldatetime")]
    public DateTime UpdatedDate { get; set; }

    [Column("PIType")]
    public bool? Pitype { get; set; }

    [Column(TypeName = "smalldatetime")]
    public DateTime? CreatedDate { get; set; }

    [StringLength(20)]
    public string? CreatedBy { get; set; }

    [Column(TypeName = "smalldatetime")]
    public DateTime? ModifiedDate { get; set; }

    [StringLength(20)]
    public string? ModifiedBy { get; set; }

    [StringLength(50)]
    public string? HosName { get; set; }

    [StringLength(100)]
    public string? HosNameKh { get; set; }

    [StringLength(30)]
    public string ProvinceName { get; set; } = null!;

    [Column("ProvinceNameKH")]
    [StringLength(60)]
    public string? ProvinceNameKh { get; set; }

    [StringLength(80)]
    public string? LotNo { get; set; }

    [Column("BudgetSourceID")]
    [StringLength(20)]
    public string BudgetSourceId { get; set; } = null!;

    [StringLength(10)]
    public string? Expr1 { get; set; }

    [StringLength(50)]
    public string? BudgetSource { get; set; }

    [StringLength(200)]
    public string? FacilityType { get; set; }

    [StringLength(200)]
    public string? SupervisedBy { get; set; }

    [Column("FacilityTypeEN")]
    [StringLength(100)]
    public string? FacilityTypeEn { get; set; }

    [Column("SupervisedByEN")]
    [StringLength(100)]
    public string? SupervisedByEn { get; set; }
}
