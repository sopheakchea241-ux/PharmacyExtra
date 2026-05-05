using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace PharmacyExtra.Web.Models;

[Table("SubTransferOut")]
public partial class SubTransferOut
{
    [Key]
    [Column("SubTransOutID")]
    public int SubTransOutId { get; set; }

    [Column("UniqueID")]
    [StringLength(20)]
    public string? UniqueId { get; set; }

    [Column(TypeName = "smalldatetime")]
    public DateTime TransferDate { get; set; }

    public bool? IsSaved { get; set; }

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

    [Column("SubPhaID")]
    [StringLength(5)]
    public string? SubPhaId { get; set; }

    [InverseProperty("SubTransOut")]
    public virtual ICollection<SubTransferOutDetail> SubTransferOutDetails { get; set; } = new List<SubTransferOutDetail>();
}
