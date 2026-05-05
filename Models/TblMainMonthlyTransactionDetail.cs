using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace PharmacyExtra.Web.Models;

[Table("tblMainMonthlyTransactionDetail")]
public partial class TblMainMonthlyTransactionDetail
{
    [Column("ReportID")]
    public int? ReportId { get; set; }

    [Key]
    [Column("ReportDetailID")]
    public int ReportDetailId { get; set; }

    [Column("CommodityID")]
    [StringLength(15)]
    public string CommodityId { get; set; } = null!;

    public int? InitialStock { get; set; }

    public int? Incoming { get; set; }

    public int? Total { get; set; }

    public int? Outgoing { get; set; }

    public int? Adjustment { get; set; }

    public int? Balance { get; set; }

    [StringLength(50)]
    public string? Note { get; set; }

    [ForeignKey("CommodityId")]
    [InverseProperty("TblMainMonthlyTransactionDetails")]
    public virtual Commodity Commodity { get; set; } = null!;

    [ForeignKey("ReportId")]
    [InverseProperty("TblMainMonthlyTransactionDetails")]
    public virtual TblMainMonthlyTransaction? Report { get; set; }
}
