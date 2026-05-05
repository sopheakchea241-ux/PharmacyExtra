using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace PharmacyExtra.Web.Models;

[Keyless]
[Table("tblNote")]
public partial class TblNote
{
    public int Nid { get; set; }

    [StringLength(15)]
    public string? Noteabbr { get; set; }

    [StringLength(50)]
    public string? Notetype { get; set; }

    [StringLength(2)]
    public string? AdjSign { get; set; }

    public bool? IsActived { get; set; }
}
