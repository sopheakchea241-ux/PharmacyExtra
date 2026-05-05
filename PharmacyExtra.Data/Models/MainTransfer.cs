using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace PharmacyExtra.Web.Models;

[Table("MainTransfer")]
[Index("TransferDate", "Sdid", Name = "IX_MainTransfer", IsUnique = true)]
public partial class MainTransfer
{
    [Key]
    [Column("TransferID")]
    public int TransferId { get; set; }

    [Column("SDID")]
    [StringLength(10)]
    [Unicode(false)]
    public string? Sdid { get; set; }

    [Column(TypeName = "smalldatetime")]
    public DateTime TransferDate { get; set; }

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

    [InverseProperty("Transfer")]
    public virtual ICollection<MainTransferDetail> MainTransferDetails { get; set; } = new List<MainTransferDetail>();
}
