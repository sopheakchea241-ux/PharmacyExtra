using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace PharmacyExtra.Web.Models;

[Keyless]
[Table("tmpSubRequest")]
public partial class TmpSubRequest
{
    public int RequestNº { get; set; }

    [Column(TypeName = "smalldatetime")]
    public DateTime? IssueDate { get; set; }

    [Column("SDID")]
    [StringLength(10)]
    public string? Sdid { get; set; }

    [Column("WardID")]
    [StringLength(10)]
    public string? WardId { get; set; }

    public bool? IsImported { get; set; }

    public bool? IsUpdated { get; set; }

    [Column("SubPhaID")]
    [StringLength(10)]
    public string? SubPhaId { get; set; }

    public bool? IsSaved { get; set; }

    public bool? IsExported { get; set; }
}
