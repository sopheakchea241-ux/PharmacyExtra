using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace PharmacyExtra.Web.Models;

[Keyless]
[Table("NoteLookUp")]
public partial class NoteLookUp
{
    [Column("NoteID")]
    [StringLength(10)]
    public string NoteId { get; set; } = null!;

    [StringLength(10)]
    public string? NoteAbbr { get; set; }

    [StringLength(100)]
    public string? Note { get; set; }

    [Column("TransTypeID")]
    [StringLength(10)]
    public string? TransTypeId { get; set; }
}
