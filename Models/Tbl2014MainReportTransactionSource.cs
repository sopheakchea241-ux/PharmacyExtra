using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace PharmacyExtra.Web.Models;

[Table("tbl2014_MainReport_Transaction_Source")]
[Index("StartDate", "EndDate", Name = "IX_tbl2014_MainReport_Transaction_Source", IsUnique = true)]
public partial class Tbl2014MainReportTransactionSource
{
    [Key]
    [Column("ID")]
    public int Id { get; set; }

    public DateOnly StartDate { get; set; }

    public DateOnly EndDate { get; set; }

    [StringLength(125)]
    public string? CreatedBy { get; set; }

    [Column(TypeName = "smalldatetime")]
    public DateTime? CreatedDate { get; set; }
}
