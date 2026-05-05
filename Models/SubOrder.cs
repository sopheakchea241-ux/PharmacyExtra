using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace PharmacyExtra.Web.Models;

[Table("SubOrder")]
public partial class SubOrder
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

    public DateOnly? CreatedDate { get; set; }

    [StringLength(30)]
    public string? CreatedBy { get; set; }

    public DateOnly? ModifiedDate { get; set; }

    [StringLength(30)]
    public string? ModifiedBy { get; set; }

    public double? Inpatient { get; set; }

    public double? OutPatient { get; set; }

    public double? SurgicalPatient { get; set; }

    public bool? IsUpdated { get; set; }

    [Column("SPiID")]
    public double? SpiId { get; set; }

    [Column("EPiID")]
    public double? EpiId { get; set; }

    public int? Cycle { get; set; }

    public bool? IsImported { get; set; }

    [Column("SubPhaID")]
    [StringLength(10)]
    public string? SubPhaId { get; set; }

    public bool? IsExported { get; set; }

    [InverseProperty("HosOrder")]
    public virtual ICollection<SubOrderDetail> SubOrderDetails { get; set; } = new List<SubOrderDetail>();
}
