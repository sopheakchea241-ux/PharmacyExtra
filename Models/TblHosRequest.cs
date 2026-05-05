using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace PharmacyExtra.Web.Models;

[Table("tblHosRequest")]
public partial class TblHosRequest
{
    [Key]
    [Column("RequestID")]
    public int RequestId { get; set; }

    [Column(TypeName = "smalldatetime")]
    public DateTime StartDate { get; set; }

    [Column(TypeName = "smalldatetime")]
    public DateTime EndDate { get; set; }

    public int InPatient { get; set; }

    public int OutPatient { get; set; }

    public int SurgicalPatient { get; set; }

    [Column(TypeName = "smalldatetime")]
    public DateTime? CreatedDate { get; set; }

    [StringLength(50)]
    public string? CreatedBy { get; set; }

    public bool? IsUpdated { get; set; }

    public int? Cycle { get; set; }

    [InverseProperty("RequestNavigation")]
    public virtual ICollection<TblHosRequestDetail> TblHosRequestDetails { get; set; } = new List<TblHosRequestDetail>();
}
