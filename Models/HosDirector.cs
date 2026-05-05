using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace PharmacyExtra.Web.Models;

[Keyless]
[Table("HosDirector")]
public partial class HosDirector
{
    [Column("ID")]
    [StringLength(10)]
    public string Id { get; set; } = null!;

    [Column("HDName")]
    [StringLength(20)]
    public string Hdname { get; set; } = null!;

    [StringLength(20)]
    public string Password { get; set; } = null!;

    [Column(TypeName = "smalldatetime")]
    public DateTime? CreatedDate { get; set; }

    public bool IsActive { get; set; }

    public bool? IsViceChief { get; set; }

    [StringLength(10)]
    [Unicode(false)]
    public string? Title { get; set; }
}
