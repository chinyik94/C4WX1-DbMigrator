﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
#nullable disable
using System;
using System.Collections.Generic;

namespace C4WX1_DbMigrator.Models;

public partial class TaskUserLogAttachment
{
    public int FileAttachmentID { get; set; }

    public int TaskUserLogID_FK { get; set; }

    public string FileName { get; set; }

    public DateTime? CreatedDate { get; set; }

    public int? CreatedBy_FK { get; set; }

    public DateTime? ModifiedDate { get; set; }

    public int? ModifiedBy_FK { get; set; }

    public bool IsDeleted { get; set; }

    public virtual TaskUserLog TaskUserLogID_FKNavigation { get; set; }
}