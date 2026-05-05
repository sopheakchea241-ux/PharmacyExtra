using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace PharmacyExtra.Web.Models;

[Keyless]
public partial class VMonthlyStockOnHand
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

    public long? StockonHand { get; set; }

    public int? MonthNº { get; set; }

    public int? Year { get; set; }

    [StringLength(50)]
    public string CommGroup { get; set; } = null!;

    [StringLength(60)]
    public string CommType { get; set; } = null!;
}
