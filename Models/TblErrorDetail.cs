using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace PharmacyExtra.Web.Models;

[Keyless]
public partial class TblErrorDetail
{
    [Column("ID")]
    public int Id { get; set; }

    [StringLength(225)]
    public string? Descriptions { get; set; }

    [Column(TypeName = "smalldatetime")]
    public DateTime? ErrDate { get; set; }

    public bool Fixed { get; set; }

    public byte? ErrType { get; set; }
}
