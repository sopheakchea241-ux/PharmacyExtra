using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace PharmacyExtra.Web.Models;

[Keyless]
[Table("tmpMainStockCardEveryDay")]
public partial class TmpMainStockCardEveryDay
{
    [Column("CommodityID")]
    [StringLength(15)]
    public string? CommodityId { get; set; }

    [StringLength(100)]
    public string? CommodityName { get; set; }

    [StringLength(50)]
    public string? Form { get; set; }

    [StringLength(50)]
    public string? Strength { get; set; }

    [StringLength(50)]
    public string? LotNo { get; set; }

    [Column(TypeName = "smalldatetime")]
    public DateTime? TransDate { get; set; }

    [Column("InvoiceID")]
    [StringLength(20)]
    public string? InvoiceId { get; set; }

    public int? TransQty { get; set; }

    [StringLength(5)]
    public string? TransGroup { get; set; }

    [StringLength(100)]
    public string? TransName { get; set; }

    [StringLength(100)]
    public string? SourceDestination { get; set; }

    public int? SubBalance { get; set; }

    public int? StockOnHand { get; set; }

    [StringLength(100)]
    public string? TransNote { get; set; }

    [Column(TypeName = "smalldatetime")]
    public DateTime? ExpDate { get; set; }

    [StringLength(100)]
    public string? TransDes { get; set; }

    [StringLength(5)]
    public string? TransYear { get; set; }

    [Column("TransTypeID")]
    [StringLength(10)]
    public string? TransTypeId { get; set; }

    [Column("MainTransactionID")]
    public int? MainTransactionId { get; set; }

    [StringLength(100)]
    public string? BudgetSource { get; set; }
}
