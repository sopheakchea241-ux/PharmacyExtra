using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace PharmacyExtra.Web.Models;

[Table("SubConsumption")]
[Index("SubPhaId", "ConsumpDate", "Sdid", "WardId", Name = "IX_SubConsumption", IsUnique = true)]
public partial class SubConsumption
{
    /// <summary>
    /// Link to IPDConsumption_Detail
    /// </summary>
    [Key]
    [Column("SubConsID")]
    public long SubConsId { get; set; }

    [Column("UniqueID")]
    [StringLength(50)]
    [Unicode(false)]
    public string? UniqueId { get; set; }

    [Column("SDID")]
    [StringLength(10)]
    [Unicode(false)]
    public string Sdid { get; set; } = null!;

    [Column("WardID")]
    [StringLength(10)]
    [Unicode(false)]
    public string? WardId { get; set; }

    public DateOnly ConsumpDate { get; set; }

    public DateOnly ReportDate { get; set; }

    [StringLength(100)]
    public string? ReportNote { get; set; }

    public int? OutPatient { get; set; }

    public int? Inpatient { get; set; }

    public int? SurgicalPatient { get; set; }

    [Column(TypeName = "smalldatetime")]
    public DateTime? CreatedDate { get; set; }

    [StringLength(50)]
    public string? CreatedBy { get; set; }

    public bool? IsUpdated { get; set; }

    [StringLength(50)]
    public string? Note { get; set; }

    [Column("SubPhaID")]
    [StringLength(10)]
    [Unicode(false)]
    public string SubPhaId { get; set; } = null!;

    public bool? IsImported { get; set; }

    public int? Cycle { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string? UpdatedBy { get; set; }

    [Column(TypeName = "smalldatetime")]
    public DateTime? UpdatedDate { get; set; }

    [InverseProperty("SubCons")]
    public virtual ICollection<SubConsumptionDetail> SubConsumptionDetails { get; set; } = new List<SubConsumptionDetail>();
}
