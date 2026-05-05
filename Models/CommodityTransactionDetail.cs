using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace PharmacyExtra.Web.Models;

[Table("CommodityTransaction_Detail")]
public partial class CommodityTransactionDetail
{
    [Key]
    [Column("DTDID")]
    public int Dtdid { get; set; }

    [Column("CommTransID")]
    public int? CommTransId { get; set; }

    [Column("CommID")]
    [StringLength(15)]
    public string? CommId { get; set; }

    public int? InitStock { get; set; }

    public int? Incoming { get; set; }

    public double? Total { get; set; }

    public int? Outgoing { get; set; }

    public double? Adjustment { get; set; }

    public double? Balance { get; set; }

    [StringLength(255)]
    public string? TransNote { get; set; }

    [StringLength(10)]
    public string? BudgetSource { get; set; }

    [ForeignKey("CommId")]
    [InverseProperty("CommodityTransactionDetails")]
    public virtual Commodity? Comm { get; set; }

    [ForeignKey("CommTransId")]
    [InverseProperty("CommodityTransactionDetails")]
    public virtual CommodityTransaction? CommTrans { get; set; }
}
