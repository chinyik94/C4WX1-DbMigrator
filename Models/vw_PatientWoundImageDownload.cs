﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
#nullable disable
using System;
using System.Collections.Generic;

namespace C4WX1_DbMigrator.Models;

public partial class vw_PatientWoundImageDownload
{
    public string NewImageName { get; set; }

    public int PatientID { get; set; }

    public string Firstname { get; set; }

    public string Lastname { get; set; }

    public int PatientWoundID { get; set; }

    public string LocationOfWound { get; set; }

    public string Site { get; set; }

    public int PatientWoundVisitID { get; set; }

    public string ImageDate { get; set; }

    public DateTime? VisitDate { get; set; }

    public string ImageUpload { get; set; }
}