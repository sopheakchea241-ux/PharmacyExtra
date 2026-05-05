using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace PharmacyExtra.Web.Models;

[Table("TransactionType")]
public partial class TransactionType
{
    [Key]
    [Column("TransTypeID")]
    [StringLength(10)]
    public string TransTypeId { get; set; } = null!;

    [StringLength(100)]
    [Unicode(false)]
    public string? TransName { get; set; }

    public bool IsActive { get; set; }

    [StringLength(1000)]
    [Unicode(false)]
    public string? Note { get; set; }
}
