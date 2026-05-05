using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace PharmacyExtra.Web.Models;

[PrimaryKey("Addid", "CommodityId")]
public partial class SubAdditionalDetail
{
    [Column("ID")]
    public int Id { get; set; }

    [Key]
    [Column("ADDID")]
    public int Addid { get; set; }

    [Key]
    [Column("CommodityID")]
    [StringLength(15)]
    public string CommodityId { get; set; } = null!;

    public int? InitialStock { get; set; }

    public int? Incoming { get; set; }

    public int? Total { get; set; }

    public int? Outgoing { get; set; }

    public int? Balance { get; set; }

    [Column("AMC")]
    public int? Amc { get; set; }

    public int? Request { get; set; }

    [Column("MOS")]
    public double? Mos { get; set; }

    [StringLength(100)]
    public string? OrderNote { get; set; }

    [ForeignKey("Addid")]
    [InverseProperty("SubAdditionalDetails")]
    public virtual SubAdditional Add { get; set; } = null!;
}
