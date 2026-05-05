using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace PharmacyExtra.Web.Models;

[Keyless]
[Table("ProcessLog")]
public partial class ProcessLog
{
    [Column("RecordID")]
    public long RecordId { get; set; }

    [StringLength(100)]
    public string? FormName { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? ProcessDate { get; set; }

    public string? Description { get; set; }

    [StringLength(50)]
    public string? UserName { get; set; }

    [Column("ID")]
    [StringLength(50)]
    public string? Id { get; set; }
}
