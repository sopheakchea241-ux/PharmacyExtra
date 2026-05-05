using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace PharmacyExtra.Web.Models;

[Table("HosOrder")]
[Index("PrevOrdDate", "HosOrderDate", "ProvinceId", "HosId", Name = "IX_HosOrder", IsUnique = true)]
public partial class HosOrder
{
    [Key]
    [Column("HosOrderID")]
    public int HosOrderId { get; set; }

    [Column(TypeName = "smalldatetime")]
    public DateTime PrevOrdDate { get; set; }

    [Column(TypeName = "smalldatetime")]
    public DateTime HosOrderDate { get; set; }

    [Column("ProvinceID")]
    [StringLength(10)]
    public string ProvinceId { get; set; } = null!;

    [Column("HosID")]
    [StringLength(50)]
    public string? HosId { get; set; }

    [Column(TypeName = "smalldatetime")]
    public DateTime? CreatedDate { get; set; }

    [StringLength(30)]
    public string? CreatedBy { get; set; }

    [Column(TypeName = "smalldatetime")]
    public DateTime? ModifiedDate { get; set; }

    [StringLength(30)]
    public string? ModifiedBy { get; set; }

    public double Inpatient { get; set; }

    public double OutPatient { get; set; }

    public double SurgicalPatient { get; set; }

    public bool IsUpdated { get; set; }

    [Column("SPiID")]
    public double? SpiId { get; set; }

    [Column("EPiID")]
    public double? EpiId { get; set; }

    public int? Cycle { get; set; }
}
