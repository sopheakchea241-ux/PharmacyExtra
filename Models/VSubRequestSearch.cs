using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace PharmacyExtra.Web.Models;

[Keyless]
public partial class VSubRequestSearch
{
    public int RequestNº { get; set; }

    [StringLength(100)]
    public string WardName { get; set; } = null!;

    [Column(TypeName = "smalldatetime")]
    public DateTime? IssueDate { get; set; }
}
