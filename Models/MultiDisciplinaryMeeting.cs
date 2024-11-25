﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
#nullable disable
using System;
using System.Collections.Generic;

namespace C4WX1_DbMigrator.Models;

public partial class MultiDisciplinaryMeeting
{
    public int MultiDisciplinaryMeetingID { get; set; }

    public int PatientID_FK { get; set; }

    public string IssuesOverall { get; set; }

    public int AssignedToFollowUp { get; set; }

    public string Remarks { get; set; }

    public DateTime CreatedDate { get; set; }

    public int CreatedBy_FK { get; set; }

    public DateTime? ModifiedDate { get; set; }

    public int? ModifiedBy_FK { get; set; }

    public bool IsDeleted { get; set; }

    public virtual ICollection<MultiDisciplinaryMeetingDetail> MultiDisciplinaryMeetingDetails { get; set; } = new List<MultiDisciplinaryMeetingDetail>();

    public virtual Patient PatientID_FKNavigation { get; set; }
}