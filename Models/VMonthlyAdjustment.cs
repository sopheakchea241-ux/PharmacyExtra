using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace PharmacyExtra.Web.Models;

[Keyless]
public partial class VMonthlyAdjustment
{
    [Column("CommodityID")]
    [StringLength(15)]
    public string? CommodityId { get; set; }

    [Column(TypeName = "smalldatetime")]
    public DateTime? TransDate { get; set; }

    public int? TransQty { get; set; }

    public long? StockonHand { get; set; }

    [Column("SDID")]
    [StringLength(10)]
    public string? Sdid { get; set; }

    [Column("TransTypeID")]
    [StringLength(10)]
    public string? TransTypeId { get; set; }

    public bool? IsUpdated { get; set; }

    [Column(TypeName = "smalldatetime")]
    public DateTime? ExpDate { get; set; }

    [StringLength(200)]
    public string? TransNote { get; set; }

    [StringLength(50)]
    public string? SourceDestination { get; set; }

    public int? Cycle { get; set; }

    [StringLength(10)]
    public string? TransOf { get; set; }
}
