using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace PharmacyExtra.Web.Models;

[Table("MainConsumption")]
[Index("ConsumpDate", "Sdid", Name = "IX_MainConsumption", IsUnique = true)]
public partial class MainConsumption
{
    /// <summary>
    /// Link to MainConsumption_Detail
    /// </summary>
    [Key]
    [Column("MainConsID")]
    public int MainConsId { get; set; }

    [Column("UniqueID")]
    [StringLength(50)]
    [Unicode(false)]
    public string? UniqueId { get; set; }

    [Column("SDID")]
    [StringLength(10)]
    [Unicode(false)]
    public string Sdid { get; set; } = null!;

    public DateOnly ConsumpDate { get; set; }

    [Column(TypeName = "smalldatetime")]
    public DateTime? CreatedDate { get; set; }

    [StringLength(50)]
    public string? CreatedBy { get; set; }

    public bool? IsUpdated { get; set; }

    [StringLength(50)]
    public string? Note { get; set; }

    [Column(TypeName = "smalldatetime")]
    public DateTime? ModifiedDate { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string? ModifiedBy { get; set; }

    public int? Cycle { get; set; }

    [InverseProperty("MainCons")]
    public virtual ICollection<MainConsumptionDetail> MainConsumptionDetails { get; set; } = new List<MainConsumptionDetail>();
}
