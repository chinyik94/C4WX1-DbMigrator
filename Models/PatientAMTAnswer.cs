﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
#nullable disable
using System;
using System.Collections.Generic;

namespace C4WX1_DbMigrator.Models;

public partial class PatientAMTAnswer
{
    public int PatientAMTID_FK { get; set; }

    public int AMTQuestionID_FK { get; set; }

    public int? Answer { get; set; }

    public virtual AMTQuestion AMTQuestionID_FKNavigation { get; set; }

    public virtual PatientAMT PatientAMTID_FKNavigation { get; set; }
}