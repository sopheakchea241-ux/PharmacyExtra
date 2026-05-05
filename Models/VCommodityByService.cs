using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace PharmacyExtra.Web.Models;

[Keyless]
public partial class VCommodityByService
{
    [Column("SDID")]
    [StringLength(10)]
    public string Sdid { get; set; } = null!;

    [Column("CommodityID")]
    [StringLength(15)]
    public string? CommodityId { get; set; }
}
