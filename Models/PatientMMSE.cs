﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
#nullable disable
using System;
using System.Collections.Generic;

namespace C4WX1_DbMigrator.Models;

public partial class PatientMMSE
{
    public int PatientMMSEID { get; set; }

    public string Type { get; set; }

    public int? VitalSignDetailID_FK { get; set; }

    public int? Score1 { get; set; }

    public int? Score2 { get; set; }

    public int? Score3 { get; set; }

    public int? Score4 { get; set; }

    public int? Score5 { get; set; }

    public int? Score6 { get; set; }

    public int? Score7 { get; set; }

    public int? Score8 { get; set; }

    public int? Score9 { get; set; }

    public int? Score10 { get; set; }

    public int? Score11 { get; set; }

    public int? Score12 { get; set; }

    public int? Score13 { get; set; }

    public int? Score14 { get; set; }

    public int? Score15 { get; set; }

    public int? Score16 { get; set; }

    public int? Score17 { get; set; }

    public int? Score18 { get; set; }

    public int? Score19 { get; set; }

    public int? Score20 { get; set; }

    public DateTime? CreatedDate { get; set; }

    public int? CreatedBy_FK { get; set; }

    public DateTime? ModifiedDate { get; set; }

    public int? ModifiedBy_FK { get; set; }

    public bool IsDeleted { get; set; }

    public virtual VitalSignDetail VitalSignDetailID_FKNavigation { get; set; }
}