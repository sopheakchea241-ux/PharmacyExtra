using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace PharmacyExtra.Web.Models;

[Keyless]
public partial class VMainStockCardDailyByLotEnd
{
    [Column("CommodityID")]
    [StringLength(15)]
    public string? CommodityId { get; set; }

    [StringLength(50)]
    public string CommodityName { get; set; } = null!;

    [StringLength(10)]
    public string? Form { get; set; }

    [StringLength(30)]
    public string? Strength { get; set; }

    [StringLength(80)]
    public string? LotNo { get; set; }

    [Column(TypeName = "smalldatetime")]
    public DateTime? TransDate { get; set; }

    public int? QtyIn { get; set; }

    public int? QtyOut { get; set; }

    public long? StockOnHand { get; set; }

    [Column("InvoiceID")]
    [StringLength(20)]
    public string? InvoiceId { get; set; }

    [StringLength(50)]
    public string? Note { get; set; }

    [StringLength(50)]
    public string? SourceDes { get; set; }

    [Column(TypeName = "smalldatetime")]
    public DateTime? ExpDate { get; set; }
}
