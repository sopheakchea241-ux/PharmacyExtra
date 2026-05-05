using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace PharmacyExtra.Web.Models;

[Keyless]
[Table("tmpSubPrescription")]
public partial class TmpSubPrescription
{
    public int ReqPresNº { get; set; }

    public int? RequestNº { get; set; }

    public int PrescriptionNº { get; set; }
}
