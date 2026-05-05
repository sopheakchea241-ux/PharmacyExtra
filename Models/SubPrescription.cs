using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace PharmacyExtra.Web.Models;

[Table("SubPrescription")]
[Index("RequestNº", "PrescriptionNº", Name = "IX_SubPrescription", IsUnique = true)]
public partial class SubPrescription
{
    [Key]
    public int ReqPresNº { get; set; }

    public int? RequestNº { get; set; }

    public int PrescriptionNº { get; set; }

    [ForeignKey("RequestNº")]
    [InverseProperty("SubPrescriptions")]
    public virtual SubRequest? RequestNºNavigation { get; set; }

    [InverseProperty("ReqPresNºNavigation")]
    public virtual ICollection<SubRequestDetail> SubRequestDetails { get; set; } = new List<SubRequestDetail>();
}
