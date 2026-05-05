using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace PharmacyExtra.Web.Models;

[Table("tbl2014_HosReport_Transaction")]
[Index("StartDate", "EndDate", Name = "IX_tbl2014_HosReport_Transaction", IsUnique = true)]
public partial class Tbl2014HosReportTransaction
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

    [StringLength(2)]
    public string? TransactionOption { get; set; }

    [StringLength(2)]
    public string? FilterOption { get; set; }

    [Column("CommGrpID")]
    [StringLength(5)]
    public string? CommGrpId { get; set; }

    [Column("CommTypeID")]
    [StringLength(5)]
    public string? CommTypeId { get; set; }
}
