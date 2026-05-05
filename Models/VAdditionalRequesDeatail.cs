using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace PharmacyExtra.Web.Models;

[Keyless]
public partial class VAdditionalRequesDeatail
{
    [Column("AOID")]
    public int Aoid { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? RequestDate { get; set; }

    [Column("MOS_Need")]
    public short? MosNeed { get; set; }

    [Column("CommodityID")]
    [StringLength(15)]
    public string? CommodityId { get; set; }

    [StringLength(100)]
    public string CommodityName { get; set; } = null!;

    [StringLength(10)]
    public string? Form { get; set; }

    [StringLength(30)]
    public string? Strength { get; set; }

    public int? InitialStock { get; set; }

    public int? Incoming { get; set; }

    public int? Total { get; set; }

    public int? Outgoing { get; set; }

    public int? Balance { get; set; }

    [Column("AMC")]
    public int? Amc { get; set; }

    [Column("MOS")]
    public double? Mos { get; set; }

    public int? Request { get; set; }

    [StringLength(100)]
    public string OrderNote { get; set; } = null!;

    [StringLength(60)]
    public string CommTypeName { get; set; } = null!;

    [Column("CommTypeID")]
    [StringLength(5)]
    public string CommTypeId { get; set; } = null!;

    public DateOnly? LastReceivedDate { get; set; }
}
