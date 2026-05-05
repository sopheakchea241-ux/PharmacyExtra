using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace PharmacyExtra.Web.Models;

[Table("tblHosRequestDetail")]
public partial class TblHosRequestDetail
{
    [Column("RequestID")]
    public int? RequestId { get; set; }

    [Key]
    [Column("RequestDetailID")]
    public int RequestDetailId { get; set; }

    [Column("CommodityID")]
    [StringLength(15)]
    public string CommodityId { get; set; } = null!;

    public int? InitialStock { get; set; }

    public int? Incoming { get; set; }

    public int? Total { get; set; }

    public int? Outgoing { get; set; }

    public int? Adjustment { get; set; }

    public int? Balance { get; set; }

    public int? Request { get; set; }

    [StringLength(50)]
    public string? Note { get; set; }

    [Column("AMCReal")]
    public long? Amcreal { get; set; }

    [Column("AMCStandard")]
    public long? Amcstandard { get; set; }

    [Column("SOD")]
    public int? Sod { get; set; }

    [ForeignKey("CommodityId")]
    [InverseProperty("TblHosRequestDetails")]
    public virtual Commodity Commodity { get; set; } = null!;

    [ForeignKey("RequestId")]
    [InverseProperty("TblHosRequestDetails")]
    public virtual TblHosRequest? RequestNavigation { get; set; }
}
