using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace PharmacyExtra.Web.Models;

[Table("HosAdditional")]
[Index("LastTransDate", Name = "IX_HosAdditional", IsUnique = true)]
public partial class HosAdditional
{
    [Key]
    [Column("ADDID")]
    public int Addid { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? RequestDate { get; set; }

    [Column("MOS_Need")]
    public double? MosNeed { get; set; }

    public bool IsUpdated { get; set; }

    public DateOnly? LastTransDate { get; set; }

    [StringLength(128)]
    [Unicode(false)]
    public string? CreatedBy { get; set; }

    [StringLength(128)]
    [Unicode(false)]
    public string? ApprovedBy { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? CratedDate { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? ApprovedDate { get; set; }
}
