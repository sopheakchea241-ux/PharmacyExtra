using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace PharmacyExtra.Web.Models;

[Table("SubAdditional")]
public partial class SubAdditional
{
    [Key]
    [Column("ADDID")]
    public int Addid { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? RequestDate { get; set; }

    [Column("MOS_Need")]
    public short? MosNeed { get; set; }

    public bool IsUpdated { get; set; }

    [StringLength(50)]
    public string? CreatedBy { get; set; }

    [Column(TypeName = "smalldatetime")]
    public DateTime? CreatedDate { get; set; }

    [StringLength(50)]
    public string? UpdatedBy { get; set; }

    [Column(TypeName = "smalldatetime")]
    public DateTime? UpdatedDate { get; set; }

    public bool? IsImported { get; set; }

    [Column("SubPhaID")]
    [StringLength(10)]
    public string? SubPhaId { get; set; }

    [InverseProperty("Add")]
    public virtual ICollection<SubAdditionalDetail> SubAdditionalDetails { get; set; } = new List<SubAdditionalDetail>();
}
