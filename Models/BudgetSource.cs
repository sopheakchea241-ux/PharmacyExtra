using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace PharmacyExtra.Web.Models;

[Table("BudgetSource")]
public partial class BudgetSource
{
    [Key]
    [Column("BudgetSourceID")]
    [StringLength(20)]
    public string BudgetSourceId { get; set; } = null!;

    [Column("BudgetSource")]
    [StringLength(50)]
    public string? BudgetSource1 { get; set; }

    [StringLength(50)]
    public string? BudgetSourceType { get; set; }
}
