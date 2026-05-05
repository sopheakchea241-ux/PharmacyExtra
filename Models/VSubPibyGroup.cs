using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace PharmacyExtra.Web.Models;

[Keyless]
public partial class VSubPibyGroup
{
    [Column("PIID")]
    public int Piid { get; set; }

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

    [Column(TypeName = "smalldatetime")]
    public DateTime? ExpDate { get; set; }

    public long? CurrentStock { get; set; }

    public long? StockCount { get; set; }

    public long? AdjQty { get; set; }

    [StringLength(100)]
    public string? TransNote { get; set; }

    [Column(TypeName = "smalldatetime")]
    public DateTime? UpdatedDate { get; set; }

    [StringLength(100)]
    public string? SubPhaName { get; set; }

    [StringLength(30)]
    public string ProvinceName { get; set; } = null!;

    [Column("ProvinceNameKH")]
    [StringLength(60)]
    public string? ProvinceNameKh { get; set; }

    [StringLength(50)]
    public string? HosName { get; set; }

    [StringLength(100)]
    public string? HosNameKh { get; set; }

    [Column("CommGrpID")]
    [StringLength(5)]
    public string? CommGrpId { get; set; }

    [StringLength(50)]
    public string CommGrpName { get; set; } = null!;

    [StringLength(200)]
    public string? SupervisedBy { get; set; }

    [Column("SupervisedByEN")]
    [StringLength(100)]
    public string? SupervisedByEn { get; set; }
}
