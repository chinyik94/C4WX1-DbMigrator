﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
#nullable disable
using System;
using System.Collections.Generic;

namespace C4WX1_DbMigrator.Models;

public partial class vw_CarePlanSetup
{
    public int PatientID { get; set; }

    public string Lastname { get; set; }

    public string Firstname { get; set; }

    public int InitialCareAssessmentID { get; set; }

    public int DiseaseID { get; set; }

    public string DiseaseName { get; set; }

    public int SystemID_FK { get; set; }

    public string System { get; set; }

    public string Status { get; set; }

    public bool IsDeleted { get; set; }

    public int? DiseaseSubInfoID { get; set; }

    public string DiseaseSubInfo { get; set; }
}