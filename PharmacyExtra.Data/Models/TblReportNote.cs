using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace PharmacyExtra.Web.Models;

[Keyless]
[Table("tblReportNote")]
public partial class TblReportNote
{
    [Column("ID")]
    public int Id { get; set; }

    [StringLength(100)]
    public string? ReportNote { get; set; }
}
