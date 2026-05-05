using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace PharmacyExtra.Web.Models;

[Keyless]
public partial class VSohofSubPhamacy
{
    [Column("SubPhaID")]
    [StringLength(10)]
    public string? SubPhaId { get; set; }

    [Column("CommodityID")]
    [StringLength(15)]
    public string? CommodityId { get; set; }

    [Column("SOH")]
    public int? Soh { get; set; }
}
