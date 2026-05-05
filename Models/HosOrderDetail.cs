using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace PharmacyExtra.Web.Models;

[PrimaryKey("HosOrderId", "CommodityId")]
[Table("HosOrderDetail")]
public partial class HosOrderDetail
{
    [Column("HosOrderDetailID")]
    public int HosOrderDetailId { get; set; }

    [Key]
    [Column("HosOrderID")]
    public int HosOrderId { get; set; }

    [Key]
    [Column("CommodityID")]
    [StringLength(10)]
    public string CommodityId { get; set; } = null!;

    public double? BeginStock { get; set; }

    public double? ExtReceive { get; set; }

    [Column("CMSReceive")]
    public double? Cmsreceive { get; set; }

    public double? Receive { get; set; }

    public double? AdjIncome { get; set; }

    public double? Available { get; set; }

    public double? ExtIssue { get; set; }

    public double? Issue { get; set; }

    [Column("AdjustTypeID")]
    [StringLength(10)]
    public string? AdjustTypeId { get; set; }

    public double? Adjust { get; set; }

    public double? EndStock { get; set; }

    public double? Request { get; set; }

    [StringLength(255)]
    public string? OrderNote { get; set; }

    public int? StockOutDay { get; set; }

    [StringLength(200)]
    public string? Adjustment { get; set; }

    [Column("RealAMC")]
    public double? RealAmc { get; set; }

    [Column("AMCStandard")]
    public double? Amcstandard { get; set; }

    [StringLength(10)]
    public string? Pharmacy { get; set; }

    public bool? IsLock { get; set; }

    [Column("IsOIARV")]
    public bool? IsOiarv { get; set; }

    public bool? IsPrint { get; set; }
}
