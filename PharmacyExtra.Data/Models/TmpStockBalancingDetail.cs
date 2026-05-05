using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace PharmacyExtra.Web.Models;

[Keyless]
[Table("tmpStockBalancingDetail")]
public partial class TmpStockBalancingDetail
{
    [Column(TypeName = "smalldatetime")]
    public DateTime? LastStockDate { get; set; }

    [Column("CommodityID")]
    [StringLength(7)]
    public string? CommodityId { get; set; }

    [StringLength(15)]
    public string? Source { get; set; }

    [Column(TypeName = "smalldatetime")]
    public DateTime? ExpDate { get; set; }

    [StringLength(250)]
    public string? LotNo { get; set; }

    [StringLength(50)]
    public string? LotNum { get; set; }

    [Column("SOH")]
    public int? Soh { get; set; }
}
