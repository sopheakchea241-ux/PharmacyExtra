using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace PharmacyExtra.Web.Models;

[Keyless]
public partial class VCommodityByServiceSub
{
    [Column("SDID")]
    [StringLength(10)]
    public string Sdid { get; set; } = null!;

    [Column("WardID")]
    [StringLength(10)]
    public string? WardId { get; set; }

    [Column("CommodityID")]
    [StringLength(15)]
    public string? CommodityId { get; set; }

    [Column("SubPhaID")]
    [StringLength(10)]
    public string? SubPhaId { get; set; }
}
