using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace PharmacyExtra.Web.Models;

[Keyless]
public partial class VMainStockCardDaily
{
    [Column("MainTransactionID")]
    public int MainTransactionId { get; set; }

    [Column("CommodityID")]
    [StringLength(15)]
    public string? CommodityId { get; set; }

    [StringLength(50)]
    public string CommodityName { get; set; } = null!;

    [StringLength(80)]
    public string? LotNo { get; set; }

    [Column(TypeName = "smalldatetime")]
    public DateTime? TransDate { get; set; }

    [Column("InvoiceID")]
    [StringLength(20)]
    public string? InvoiceId { get; set; }

    [StringLength(50)]
    public string TransName { get; set; } = null!;

    [StringLength(50)]
    public string? SourceDestination { get; set; }

    public int? TransQty { get; set; }

    public long? SubBalance { get; set; }

    public long? StockonHand { get; set; }

    [StringLength(50)]
    public string? TransNote { get; set; }

    [Column(TypeName = "smalldatetime")]
    public DateTime? ExpDate { get; set; }

    [StringLength(10)]
    public string? Form { get; set; }

    [StringLength(30)]
    public string? Strength { get; set; }
}
