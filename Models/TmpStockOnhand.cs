using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace PharmacyExtra.Web.Models;

[Keyless]
[Table("tmpStockOnhand")]
public partial class TmpStockOnhand
{
    [Column("CommodityID")]
    [StringLength(50)]
    public string? CommodityId { get; set; }

    [StringLength(200)]
    public string? CommodityName { get; set; }

    [StringLength(50)]
    public string? CommForm { get; set; }

    [StringLength(50)]
    public string? MedicineStrength { get; set; }

    public double? StockOnhand { get; set; }

    [Column(TypeName = "smalldatetime")]
    public DateTime? ExpDate { get; set; }

    [Column(TypeName = "smalldatetime")]
    public DateTime? LastTranDate { get; set; }
}
