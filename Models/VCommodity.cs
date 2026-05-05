using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace PharmacyExtra.Web.Models;

[Keyless]
public partial class VCommodity
{
    [Column("CommodityID")]
    [StringLength(15)]
    public string CommodityId { get; set; } = null!;

    [StringLength(100)]
    public string CommodityName { get; set; } = null!;

    [StringLength(10)]
    public string? Form { get; set; }

    [StringLength(30)]
    public string? Strength { get; set; }

    [StringLength(60)]
    public string CommTypeName { get; set; } = null!;
}
