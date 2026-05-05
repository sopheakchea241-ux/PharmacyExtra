using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace PharmacyExtra.Web.Models;

[Keyless]
public partial class Zzzzz
{
    [Column("CommodityID")]
    [StringLength(15)]
    public string? CommodityId { get; set; }

    [Column(TypeName = "smalldatetime")]
    public DateTime? TransDate { get; set; }

    [Column("Initial Balance")]
    public int? InitialBalance { get; set; }

    public int? Incoming { get; set; }

    public int? OutGoing { get; set; }

    [Column("Adjustment(-)")]
    public int? Adjustment { get; set; }

    [Column("Adjustment(+)")]
    public int? Adjustment1 { get; set; }
}
