﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
#nullable disable
using System;
using System.Collections.Generic;

namespace C4WX1_DbMigrator.Models;

public partial class Audit_MailSetting
{
    public string AuditAction { get; set; }

    public DateTime ActionTime { get; set; }

    public int id { get; set; }

    public string description { get; set; }

    public string msgBCC { get; set; }

    public string msgCC { get; set; }

    public string msgTo { get; set; }

    public string msgSubj { get; set; }

    public string msgBody { get; set; }

    public bool? displayMsgTo { get; set; }

    public bool? displayMsgCC { get; set; }

    public bool? displayMsgBCC { get; set; }

    public DateTime? ModifiedDate { get; set; }

    public int? ModifiedBy_FK { get; set; }

    public bool IsDeleted { get; set; }
}