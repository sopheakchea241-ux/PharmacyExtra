using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace PharmacyExtra.Web.Models;

[Keyless]
public partial class VSubRequestReportSum
{
    [Column("SDID")]
    [StringLength(10)]
    public string? Sdid { get; set; }

    [Column("WardID")]
    [StringLength(10)]
    public string? WardId { get; set; }

    [Column("CommodityID")]
    [StringLength(15)]
    public string CommodityId { get; set; } = null!;

    [StringLength(100)]
    public string CommodityName { get; set; } = null!;

    [StringLength(10)]
    public string? Form { get; set; }

    [StringLength(30)]
    public string? Strength { get; set; }

    public int? Quantity { get; set; }

    [Column("SubPhaID")]
    [StringLength(10)]
    public string? SubPhaId { get; set; }

    public int RequestNº { get; set; }

    [StringLength(100)]
    public string WardName { get; set; } = null!;

    [Column(TypeName = "smalldatetime")]
    public DateTime? IssueDate { get; set; }
}
