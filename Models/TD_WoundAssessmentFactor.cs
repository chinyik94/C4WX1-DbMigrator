﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
#nullable disable
using System;
using System.Collections.Generic;

namespace C4WX1_DbMigrator.Models;

public partial class TD_WoundAssessmentFactor
{
    public int TD_WoundAssessmentID_FK { get; set; }

    public int CodeID_FK { get; set; }

    public virtual Code CodeID_FKNavigation { get; set; }
}