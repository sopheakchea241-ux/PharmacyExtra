using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace PharmacyExtra.Web.Models;

[Keyless]
public partial class VHosOrderDetail
{
    [Column("HosOrderID")]
    public int? HosOrderId { get; set; }

    [Column("HosOrderDetailID")]
    public int HosOrderDetailId { get; set; }

    [StringLength(10)]
    public string? Code { get; set; }

    [StringLength(100)]
    public string CommodityName { get; set; } = null!;

    [StringLength(10)]
    public string? Form { get; set; }

    [StringLength(30)]
    public string? Strength { get; set; }

    public double? InitStock { get; set; }

    public double? Incoming { get; set; }

    public double? Total { get; set; }

    public double? Outgoing { get; set; }

    [Column("Adjust +/-")]
    [StringLength(200)]
    public string? Adjust { get; set; }

    public double? Balance { get; set; }

    public double? Request { get; set; }

    [StringLength(255)]
    public string? OrderNote { get; set; }

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
}
