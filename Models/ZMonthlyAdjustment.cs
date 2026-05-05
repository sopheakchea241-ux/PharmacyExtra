using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace PharmacyExtra.Web.Models;

[Keyless]
public partial class ZMonthlyAdjustment
{
    [Column("CommodityID")]
    [StringLength(15)]
    public string? CommodityId { get; set; }

    [Column(TypeName = "smalldatetime")]
    public DateTime? TransDate { get; set; }

    public int? TransQty { get; set; }

    [StringLength(200)]
    public string? TransNote { get; set; }

    public int? Cycle { get; set; }
}
