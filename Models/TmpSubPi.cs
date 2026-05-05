using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace PharmacyExtra.Web.Models;

[Keyless]
[Table("tmpSubPI")]
public partial class TmpSubPi
{
    [Column("PIID")]
    public int Piid { get; set; }

    [Column(TypeName = "smalldatetime")]
    public DateTime? UpdatedDate { get; set; }

    public bool? IsUpdated { get; set; }

    [Column("PIType")]
    public bool? Pitype { get; set; }

    [Column(TypeName = "smalldatetime")]
    public DateTime? CreatedDate { get; set; }

    [StringLength(50)]
    public string? CreatedBy { get; set; }

    [Column(TypeName = "smalldatetime")]
    public DateTime? ModifiedDate { get; set; }

    [StringLength(50)]
    public string? ModifiedBy { get; set; }

    public bool? IsSaved { get; set; }

    [Column("SubPhaID")]
    [StringLength(10)]
    public string? SubPhaId { get; set; }

    public int? Cycle { get; set; }

    public bool? IsExported { get; set; }
}
