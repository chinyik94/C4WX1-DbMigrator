﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
#nullable disable
using System;
using System.Collections.Generic;

namespace C4WX1_DbMigrator.Models;

public partial class RecentView
{
    public int UserID_FK { get; set; }

    public int PatientID_FK { get; set; }

    public DateTime DateView { get; set; }

    public virtual Patient PatientID_FKNavigation { get; set; }

    public virtual User UserID_FKNavigation { get; set; }
}