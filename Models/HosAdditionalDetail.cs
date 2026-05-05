using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace PharmacyExtra.Web.Models;

[Index("Addid", "CommodityId", Name = "IX_HosAdditionalDetails", IsUnique = true)]
public partial class HosAdditionalDetail
{
    [Key]
    [Column("ID")]
    public int Id { get; set; }

    [Column("ADDID")]
    public int? Addid { get; set; }

    [Column("CommodityID")]
    [StringLength(15)]
    public string? CommodityId { get; set; }

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

    [StringLength(10)]
    public string? Pharmacy { get; set; }

    public DateOnly? LastReceivedDate { get; set; }

    public int? StockOutDay { get; set; }

    public bool? IsLock { get; set; }

    [Column("IsOIARV")]
    public bool? IsOiarv { get; set; }

    public bool? IsPrint { get; set; }
}
