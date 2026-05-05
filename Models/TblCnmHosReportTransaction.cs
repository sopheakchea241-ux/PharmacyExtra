using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace PharmacyExtra.Web.Models;

[Table("tblCNM_HosReport_Transaction")]
public partial class TblCnmHosReportTransaction
{
    [Key]
    [Column("ID")]
    public int Id { get; set; }

    [Column(TypeName = "smalldatetime")]
    public DateTime StartDate { get; set; }

    [Column(TypeName = "smalldatetime")]
    public DateTime EndDate { get; set; }

    public int ForMonth { get; set; }

    public int ForYear { get; set; }
}
