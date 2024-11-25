﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
#nullable disable
using System;
using System.Collections.Generic;

namespace C4WX1_DbMigrator.Models;

public partial class Audit_Receipt
{
    public string AuditAction { get; set; }

    public DateTime ActionTime { get; set; }

    public int ReceiptID { get; set; }

    public string ReceiptNumber { get; set; }

    public DateTime ReceiptDate { get; set; }

    public int PatientID_FK { get; set; }

    public int PaymentModeID_FK { get; set; }

    public decimal TotalAmt { get; set; }

    public string ReceivedFrom { get; set; }

    public string Remarks { get; set; }

    public bool? SendEmail { get; set; }

    public bool? EmailPatient { get; set; }

    public string EmailTo { get; set; }

    public string EmailCC { get; set; }

    public string EmailBCC { get; set; }

    public int CurrencyID_FK { get; set; }

    public string Status { get; set; }

    public string GroupNumber { get; set; }

    public DateTime CreatedDate { get; set; }

    public int CreatedBy_FK { get; set; }

    public DateTime? ModifiedDate { get; set; }

    public int? ModifiedBy_FK { get; set; }

    public bool IsDeleted { get; set; }
}