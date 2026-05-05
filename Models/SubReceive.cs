using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace PharmacyExtra.Web.Models;

[Table("SubReceive")]
[Index("SubPhaId", "Sdid", "ConsumpDate", Name = "IX_SubReceive", IsUnique = true)]
public partial class SubReceive
{
    [Key]
    [Column("MainConsID")]
    public long MainConsId { get; set; }

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
    public string? ModifiedBy { get; set; }

    public int? Cycle { get; set; }

    [Column("SubPhaID")]
    [StringLength(10)]
    [Unicode(false)]
    public string SubPhaId { get; set; } = null!;

    [Column("InvoiceID")]
    public long? InvoiceId { get; set; }

    public DateOnly? ReceivedDate { get; set; }

    [InverseProperty("MainCons")]
    public virtual ICollection<SubReceiveDetail> SubReceiveDetails { get; set; } = new List<SubReceiveDetail>();
}
