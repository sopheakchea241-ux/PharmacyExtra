using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace PharmacyExtra.Web.Models;

[Keyless]
public partial class VQuaterlyRequestReport
{
    [Column("HosOrderID")]
    public int HosOrderId { get; set; }

    [Column(TypeName = "smalldatetime")]
    public DateTime PrevOrdDate { get; set; }

    [Column(TypeName = "smalldatetime")]
    public DateTime HosOrderDate { get; set; }

    [Column("ProvinceID")]
    [StringLength(10)]
    public string ProvinceId { get; set; } = null!;

    [Column("HosID")]
    [StringLength(50)]
    public string? HosId { get; set; }

    [Column(TypeName = "smalldatetime")]
    public DateTime? CreatedDate { get; set; }

    [StringLength(30)]
    public string? CreatedBy { get; set; }

    [Column(TypeName = "smalldatetime")]
    public DateTime? ModifiedDate { get; set; }

    [StringLength(30)]
    public string? ModifiedBy { get; set; }

    public double Inpatient { get; set; }

    public double OutPatient { get; set; }

    public double SurgicalPatient { get; set; }

    public bool IsUpdated { get; set; }

    [Column("SPiID")]
    public double? SpiId { get; set; }

    [Column("EPiID")]
    public double? EpiId { get; set; }

    [Column("HosOrderDetailID")]
    public int HosOrderDetailId { get; set; }

    [Column("CommodityID")]
    [StringLength(10)]
    public string? CommodityId { get; set; }

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
    public string? Form { get; set; }

    [StringLength(100)]
    public string CommodityName { get; set; } = null!;

    [StringLength(30)]
    public string? Strength { get; set; }

    [Column("CommTypeID")]
    [StringLength(5)]
    public string? CommTypeId { get; set; }

    [StringLength(60)]
    public string? CommTypeName { get; set; }

    [Column("CommGrpID")]
    [StringLength(5)]
    public string? CommGrpId { get; set; }

    [StringLength(50)]
    public string? CommGrpName { get; set; }

    [Column("ORDERID")]
    public int Orderid { get; set; }
}
