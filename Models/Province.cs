using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace PharmacyExtra.Web.Models;

[Table("Province")]
public partial class Province
{
    [Key]
    [Column("ProvinceID")]
    [StringLength(4)]
    public string ProvinceId { get; set; } = null!;

    [StringLength(30)]
    public string ProvinceName { get; set; } = null!;

    [Column("ProvinceNameKH")]
    [StringLength(60)]
    public string? ProvinceNameKh { get; set; }

    [InverseProperty("Province")]
    public virtual ICollection<District> Districts { get; set; } = new List<District>();
}
