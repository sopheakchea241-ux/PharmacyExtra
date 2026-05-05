using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace PharmacyExtra.Web.Models;

[Keyless]
[Table("tblTemp_Invoice_InvGroup")]
public partial class TblTempInvoiceInvGroup
{
    [Column("InvGroupID")]
    [StringLength(50)]
    [Unicode(false)]
    public string? InvGroupId { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string? InvGroupName { get; set; }

    [Column("InvGroupNameKH")]
    [StringLength(50)]
    [Unicode(false)]
    public string? InvGroupNameKh { get; set; }
}
