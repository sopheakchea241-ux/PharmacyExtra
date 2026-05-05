using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace PharmacyExtra.Web.Models;

[Table("tblMainTransferIn")]
[Index("Sdid", "IssueDate", "TransferDate", Name = "IX_tblMainTransferIn", IsUnique = true)]
public partial class TblMainTransferIn
{
    [Key]
    [Column("TransferInID")]
    public int TransferInId { get; set; }

    public DateOnly TransferDate { get; set; }

    [Column("SDID")]
    [StringLength(10)]
    [Unicode(false)]
    public string Sdid { get; set; } = null!;

    public bool? IsUpdated { get; set; }

    [StringLength(100)]
    public string? Notes { get; set; }

    [Column(TypeName = "smalldatetime")]
    public DateTime? CreatedDate { get; set; }

    [StringLength(50)]
    public string? CreatedBy { get; set; }

    [Column(TypeName = "smalldatetime")]
    public DateTime? ModifiedDate { get; set; }

    [StringLength(50)]
    public string? ModifiedBy { get; set; }

    public int? Cycle { get; set; }

    public DateOnly? IssueDate { get; set; }

    [InverseProperty("TransferIn")]
    public virtual ICollection<TblMainTransferInDetail> TblMainTransferInDetails { get; set; } = new List<TblMainTransferInDetail>();
}
