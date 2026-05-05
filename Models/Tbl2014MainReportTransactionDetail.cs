using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace PharmacyExtra.Web.Models;

[Table("tbl2014_MainReport_TransactionDetail")]
public partial class Tbl2014MainReportTransactionDetail
{
    [Key]
    [Column("DetailID")]
    public int DetailId { get; set; }

    [Column("ID")]
    public int Id { get; set; }

    [Column("CommodityID")]
    [StringLength(50)]
    [Unicode(false)]
    public string CommodityId { get; set; } = null!;

    public int BeginStock { get; set; }

    public int Incoming { get; set; }

    public int Total { get; set; }

    public int Outgoing { get; set; }

    public int Adjustment { get; set; }

    public int EndStock { get; set; }

    [StringLength(50)]
    public string? OrderNote { get; set; }
}
