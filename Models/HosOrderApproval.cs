using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace PharmacyExtra.Web.Models;

[Keyless]
[Table("HosOrderApproval")]
[Index("HosOrderId", "Id", "ReportType", Name = "IX_HosOrderApproval", IsUnique = true)]
public partial class HosOrderApproval
{
    [Column("HosOrderID")]
    public double? HosOrderId { get; set; }

    [Column("ID")]
    [StringLength(50)]
    public string? Id { get; set; }

    public DateOnly? ApproveDate { get; set; }

    public int? ReportType { get; set; }

    [Column("ApprovedID")]
    public int ApprovedId { get; set; }
}
