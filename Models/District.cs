using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace PharmacyExtra.Web.Models;

[Table("District")]
public partial class District
{
    [Key]
    [Column("DistrictID")]
    [StringLength(6)]
    public string DistrictId { get; set; } = null!;

    [StringLength(50)]
    public string DistName { get; set; } = null!;

    [StringLength(100)]
    public string? DistNameKh { get; set; }

    /// <summary>
    /// Link to Province
    /// </summary>
    [Column("ProvinceID")]
    [StringLength(4)]
    public string ProvinceId { get; set; } = null!;

    [InverseProperty("District")]
    public virtual ICollection<Facility> Facilities { get; set; } = new List<Facility>();

    [ForeignKey("ProvinceId")]
    [InverseProperty("Districts")]
    public virtual Province Province { get; set; } = null!;
}
