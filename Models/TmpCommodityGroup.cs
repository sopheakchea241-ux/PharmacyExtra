using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace PharmacyExtra.Web.Models;

[Keyless]
[Table("tmpCommodityGroup")]
public partial class TmpCommodityGroup
{
    [Column("CommGrpID")]
    [StringLength(5)]
    public string CommGrpId { get; set; } = null!;

    [StringLength(50)]
    public string CommGrpName { get; set; } = null!;

    [Column("CommGrpNameKH")]
    [StringLength(60)]
    public string? CommGrpNameKh { get; set; }
}
