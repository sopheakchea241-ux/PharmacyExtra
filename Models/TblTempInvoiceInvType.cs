using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace PharmacyExtra.Web.Models;

[Keyless]
[Table("tblTemp_Invoice_InvType")]
public partial class TblTempInvoiceInvType
{
    [Column("InvTypeID")]
    [StringLength(50)]
    [Unicode(false)]
    public string? InvTypeId { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string? InvTypeName { get; set; }

    [Column("InvTypeNameKH")]
    [StringLength(50)]
    [Unicode(false)]
    public string? InvTypeNameKh { get; set; }

    public int? Value { get; set; }

    [Column("InvGroupID")]
    [StringLength(50)]
    [Unicode(false)]
    public string? InvGroupId { get; set; }

    [Column("HCOrder")]
    public int? Hcorder { get; set; }

    [Column("NonHCOrder")]
    public int? NonHcorder { get; set; }
}
