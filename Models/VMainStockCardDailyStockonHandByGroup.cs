using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace PharmacyExtra.Web.Models;

[Keyless]
public partial class VMainStockCardDailyStockonHandByGroup
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

    public long? StockOnHand { get; set; }

    [Column(TypeName = "smalldatetime")]
    public DateTime? ExpiredDate { get; set; }

    [Column(TypeName = "smalldatetime")]
    public DateTime? TransDate { get; set; }

    [StringLength(50)]
    public string CommGrpName { get; set; } = null!;

    [StringLength(60)]
    public string CommTypeName { get; set; } = null!;
}
