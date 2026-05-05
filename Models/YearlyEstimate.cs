using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace PharmacyExtra.Web.Models;

[Keyless]
[Table("YearlyEstimate")]
[Index("ForYear", Name = "IX_YearlyEstimate", IsUnique = true)]
public partial class YearlyEstimate
{
    [Column("ID")]
    public long Id { get; set; }

    [Column("Date_From")]
    public DateOnly DateFrom { get; set; }

    [Column("Date_To")]
    public DateOnly DateTo { get; set; }

    [Column("For_Year")]
    public int ForYear { get; set; }

    public bool? IsUpdated { get; set; }

    [StringLength(128)]
    [Unicode(false)]
    public string? CreatedBy { get; set; }

    [StringLength(128)]
    [Unicode(false)]
    public string? ApprovedBy { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? CratedDate { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? ApprovedDate { get; set; }
}
