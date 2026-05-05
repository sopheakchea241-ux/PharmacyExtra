using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace PharmacyExtra.Web.Models;

[Keyless]
[Table("tblTemp_Invoice_Inventory")]
public partial class TblTempInvoiceInventory
{
    [Column("InventoryID")]
    [StringLength(10)]
    [Unicode(false)]
    public string? InventoryId { get; set; }

    [StringLength(100)]
    [Unicode(false)]
    public string? InvName { get; set; }

    [StringLength(100)]
    [Unicode(false)]
    public string? AddName { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string? InvAbbrev { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string? Strength { get; set; }

    [Column("FormID")]
    [StringLength(50)]
    [Unicode(false)]
    public string? FormId { get; set; }

    [Column("RouteID")]
    [StringLength(50)]
    [Unicode(false)]
    public string? RouteId { get; set; }

    [Column("InvTypeID")]
    [StringLength(50)]
    [Unicode(false)]
    public string? InvTypeId { get; set; }

    [Column("InvStandardTypeID")]
    [StringLength(50)]
    [Unicode(false)]
    public string? InvStandardTypeId { get; set; }

    [Column("CategoryID")]
    [StringLength(50)]
    [Unicode(false)]
    public string? CategoryId { get; set; }

    [StringLength(200)]
    [Unicode(false)]
    public string? Memo { get; set; }

    [StringLength(200)]
    [Unicode(false)]
    public string? Memo1 { get; set; }

    [Column("IUID")]
    [StringLength(50)]
    [Unicode(false)]
    public string? Iuid { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string? IssueSize { get; set; }

    [StringLength(10)]
    [Unicode(false)]
    public string? MinStockE { get; set; }

    [StringLength(10)]
    [Unicode(false)]
    public string? MaxStockE { get; set; }

    [StringLength(10)]
    [Unicode(false)]
    public string? ForPer { get; set; }

    [StringLength(10)]
    [Unicode(false)]
    public string? ProPer { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string? CatalogRef { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string? StrTemp { get; set; }

    [Column("WHO")]
    [StringLength(50)]
    [Unicode(false)]
    public string? Who { get; set; }

    [Column("LevUseID")]
    [StringLength(50)]
    [Unicode(false)]
    public string? LevUseId { get; set; }

    [Column("VitalID")]
    [StringLength(50)]
    [Unicode(false)]
    public string? VitalId { get; set; }

    [Column("ABCClass")]
    [StringLength(50)]
    [Unicode(false)]
    public string? Abcclass { get; set; }

    [Column("TheraClassID")]
    [StringLength(10)]
    [Unicode(false)]
    public string? TheraClassId { get; set; }

    [Column("ATCClass")]
    [StringLength(50)]
    [Unicode(false)]
    public string? Atcclass { get; set; }

    [Column("DDD")]
    [StringLength(10)]
    [Unicode(false)]
    public string? Ddd { get; set; }

    [Column("DDDUnit")]
    [StringLength(50)]
    [Unicode(false)]
    public string? Dddunit { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string? NatFormul { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string? RegFormul { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string? DutyRate { get; set; }

    [StringLength(100)]
    [Unicode(false)]
    public string? ColCont { get; set; }

    [StringLength(100)]
    [Unicode(false)]
    public string? Controlled { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string? Schedule { get; set; }

    [Column("FacOFr")]
    [StringLength(50)]
    [Unicode(false)]
    public string? FacOfr { get; set; }

    [Column("StoOFr")]
    [StringLength(50)]
    [Unicode(false)]
    public string? StoOfr { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string? Forex { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string? Nature { get; set; }

    [Column("StatusID")]
    [StringLength(50)]
    [Unicode(false)]
    public string? StatusId { get; set; }

    [StringLength(100)]
    [Unicode(false)]
    public string? Active { get; set; }

    [StringLength(100)]
    [Unicode(false)]
    public string? ExcStockOut { get; set; }

    [StringLength(10)]
    [Unicode(false)]
    public string? AdjFactor { get; set; }

    [Column("UsedInMPA")]
    public bool? UsedInMpa { get; set; }

    [Column("MPAMulti", TypeName = "decimal(18, 4)")]
    public decimal? Mpamulti { get; set; }

    [Column("UsedInCPA")]
    public bool? UsedInCpa { get; set; }

    [Column("CPAMulti", TypeName = "decimal(18, 4)")]
    public decimal? Cpamulti { get; set; }

    [Column("UsedInCPAS")]
    public bool? UsedInCpas { get; set; }

    [Column("CPASMulti", TypeName = "decimal(18, 4)")]
    public decimal? Cpasmulti { get; set; }

    [Column("NonHCOrder")]
    [StringLength(10)]
    [Unicode(false)]
    public string? NonHcorder { get; set; }

    [Column("HCOrder")]
    [StringLength(10)]
    [Unicode(false)]
    public string? Hcorder { get; set; }

    public bool? ExpDate { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? InsertedDate { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string? InsertedBy { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? ModifiedDate { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string? ModifiedBy { get; set; }
}
