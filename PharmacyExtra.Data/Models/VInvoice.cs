using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace PharmacyExtra.Web.Models;

[Keyless]
public partial class VInvoice
{
    [Column("InvoiceID")]
    [StringLength(20)]
    public string InvoiceId { get; set; } = null!;

    [Column("BudgetSourceID")]
    [StringLength(10)]
    public string? BudgetSourceId { get; set; }

    [StringLength(50)]
    public string? BudgetSource { get; set; }

    [Column("CommodityID")]
    [StringLength(15)]
    public string? CommodityId { get; set; }

    [StringLength(100)]
    public string CommodityName { get; set; } = null!;

    [StringLength(10)]
    public string? Form { get; set; }

    [StringLength(30)]
    public string? Strength { get; set; }

    public long? Amount { get; set; }

    [StringLength(80)]
    public string? LotNo { get; set; }

    [Column(TypeName = "smalldatetime")]
    public DateTime? ExpDate { get; set; }

    [Column(TypeName = "smalldatetime")]
    public DateTime? IssueDate { get; set; }

    [Column(TypeName = "smalldatetime")]
    public DateTime? ArriveDate { get; set; }

    [Column("SysID")]
    [StringLength(10)]
    public string? SysId { get; set; }

    [StringLength(100)]
    public string? SysName { get; set; }

    [StringLength(50)]
    public string? SysNameKh { get; set; }

    [StringLength(50)]
    public string? HosName { get; set; }

    [StringLength(100)]
    public string? HosNameKh { get; set; }

    [StringLength(30)]
    public string ProvinceName { get; set; } = null!;

    [Column("ProvinceNameKH")]
    [StringLength(60)]
    public string? ProvinceNameKh { get; set; }
}
