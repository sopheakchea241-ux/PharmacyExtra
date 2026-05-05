using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace PharmacyExtra.Web.Models;

[Keyless]
public partial class VMainStockNotYetUpdateAvailable
{
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

    public long? StockAvailable { get; set; }

    [Column(TypeName = "smalldatetime")]
    public DateTime? ExpiredDate { get; set; }

    [Column("SDID")]
    [StringLength(10)]
    public string? Sdid { get; set; }

    [Column("MainTransactionID")]
    public int MainTransactionId { get; set; }
}
