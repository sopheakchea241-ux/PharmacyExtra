using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace PharmacyExtra.Web.Models;

[Keyless]
[Table("tmpCommodityCategory")]
public partial class TmpCommodityCategory
{
    [Column("CommCateID")]
    [StringLength(5)]
    public string CommCateId { get; set; } = null!;

    [StringLength(50)]
    public string? CommCateName { get; set; }

    [Column("CommCateNameKH")]
    [StringLength(60)]
    public string? CommCateNameKh { get; set; }

    [Column(TypeName = "ntext")]
    public string? CommCateDesc { get; set; }

    [Column("CommCateDescKH", TypeName = "ntext")]
    public string? CommCateDescKh { get; set; }

    [Column("CommGrpID")]
    [StringLength(5)]
    public string? CommGrpId { get; set; }
}
