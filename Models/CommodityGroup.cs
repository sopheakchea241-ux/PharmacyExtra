using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace PharmacyExtra.Web.Models;

[Table("CommodityGroup")]
public partial class CommodityGroup
{
    [Key]
    [Column("CommGrpID")]
    [StringLength(5)]
    public string CommGrpId { get; set; } = null!;

    [StringLength(50)]
    public string CommGrpName { get; set; } = null!;

    [Column("CommGrpNameKH")]
    [StringLength(60)]
    public string? CommGrpNameKh { get; set; }

    [InverseProperty("CommGrp")]
    public virtual ICollection<CommodityCategory> CommodityCategories { get; set; } = new List<CommodityCategory>();

    [InverseProperty("CommGrp")]
    public virtual ICollection<CommodityType> CommodityTypes { get; set; } = new List<CommodityType>();
}
