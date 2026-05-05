using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace PharmacyExtra.Web.Models;

[Keyless]
[Table("Consumption_Note")]
public partial class ConsumptionNote
{
    public int Nid { get; set; }

    [StringLength(15)]
    public string? Noteabbr { get; set; }

    [StringLength(50)]
    public string? Notetype { get; set; }

    [Column("TransTypeID")]
    [StringLength(50)]
    public string? TransTypeId { get; set; }
}
