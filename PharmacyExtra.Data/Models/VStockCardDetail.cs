using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace PharmacyExtra.Web.Models;

[Keyless]
public partial class VStockCardDetail
{
    [Column("MainTransactionID")]
    public int MainTransactionId { get; set; }

    [Column("CommodityID")]
    [StringLength(15)]
    public string? CommodityId { get; set; }

    [StringLength(100)]
    public string CommodityName { get; set; } = null!;

    [StringLength(10)]
    public string? Form { get; set; }

    [StringLength(30)]
    public string? Strength { get; set; }

    [StringLength(80)]
    public string? LotNo { get; set; }

    [Column(TypeName = "smalldatetime")]
    public DateTime? TransDate { get; set; }

    [Column("InvoiceID")]
    [StringLength(20)]
    public string? InvoiceId { get; set; }

    public int? TransQty { get; set; }

    [StringLength(1)]
    public string? TransGroup { get; set; }

    [StringLength(50)]
    public string TransName { get; set; } = null!;

    [StringLength(100)]
    public string? SourceDestination { get; set; }

    public long? SubBalance { get; set; }

    public long? StockonHand { get; set; }

    [StringLength(200)]
    public string? TransNote { get; set; }

    [Column(TypeName = "smalldatetime")]
    public DateTime? ExpDate { get; set; }

    public int? TransYear { get; set; }

    [Column("TransTypeID")]
    [StringLength(10)]
    public string? TransTypeId { get; set; }

    [StringLength(50)]
    public string? BudgetSource { get; set; }

    [Column("SD")]
    [StringLength(50)]
    public string? Sd { get; set; }
}
