using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace PharmacyExtra.Web.Models;

[Keyless]
[Table("tmpStockStatus")]
public partial class TmpStockStatus
{
    [Column("CommodityID")]
    [StringLength(15)]
    public string? CommodityId { get; set; }

    [StringLength(100)]
    public string? CommName { get; set; }

    [StringLength(10)]
    public string? Form { get; set; }

    [StringLength(30)]
    public string? Strength { get; set; }

    public long? Balance { get; set; }

    [Column("AMC")]
    public long? Amc { get; set; }

    [Column("MOS")]
    public double? Mos { get; set; }

    [StringLength(50)]
    public string? StockStatus { get; set; }

    [StringLength(50)]
    public string? CommGroup { get; set; }

    [StringLength(50)]
    public string? CommType { get; set; }

    public int? Nº { get; set; }
}
