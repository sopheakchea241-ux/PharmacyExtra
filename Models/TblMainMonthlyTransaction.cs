using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace PharmacyExtra.Web.Models;

[Table("tblMainMonthlyTransaction")]
public partial class TblMainMonthlyTransaction
{
    [Column("UniqueID")]
    [StringLength(50)]
    public string? UniqueId { get; set; }

    [Key]
    [Column("ReportID")]
    public int ReportId { get; set; }

    [Column(TypeName = "smalldatetime")]
    public DateTime StartDate { get; set; }

    [Column(TypeName = "smalldatetime")]
    public DateTime EndDate { get; set; }

    public int InPatient { get; set; }

    public int OutPatient { get; set; }

    public int SurgicalPatient { get; set; }

    [Column(TypeName = "smalldatetime")]
    public DateTime? CreatedDate { get; set; }

    [StringLength(50)]
    public string? CreatedBy { get; set; }

    public int? DataMode { get; set; }

    [InverseProperty("Report")]
    public virtual ICollection<TblMainMonthlyTransactionDetail> TblMainMonthlyTransactionDetails { get; set; } = new List<TblMainMonthlyTransactionDetail>();
}
