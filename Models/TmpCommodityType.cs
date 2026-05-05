using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace PharmacyExtra.Web.Models;

[Keyless]
[Table("tmpCommodityType")]
public partial class TmpCommodityType
{
    [Column("CommTypeID")]
    [StringLength(5)]
    public string CommTypeId { get; set; } = null!;

    [StringLength(60)]
    public string CommTypeName { get; set; } = null!;

    [Column("CommTypeNameKH")]
    [StringLength(60)]
    public string? CommTypeNameKh { get; set; }

    [Column("CategoryID")]
    [StringLength(5)]
    public string? CategoryId { get; set; }

    [Column("CommGrpID")]
    [StringLength(5)]
    public string? CommGrpId { get; set; }

    public bool? HaveQuota { get; set; }

    [StringLength(50)]
    public string? Abbr { get; set; }
}
