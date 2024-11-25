﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
#nullable disable
using System;
using System.Collections.Generic;

namespace C4WX1_DbMigrator.Models;

public partial class BillingPackageRequest
{
    public int PackageRequestID { get; set; }

    public string PackageRequestNo { get; set; }

    public int PatientID_FK { get; set; }

    public string PatientName { get; set; }

    public string SendBillTo { get; set; }

    public DateOnly? StartDate { get; set; }

    public DateOnly? EndDate { get; set; }

    public bool Discount { get; set; }

    public string DiscountType { get; set; }

    public decimal DiscountAmt { get; set; }

    public decimal DiscountPercentage { get; set; }

    public string Remarks { get; set; }

    public DateTime CreatedDate { get; set; }

    public int CreatedBy_FK { get; set; }

    public DateTime? ModifiedDate { get; set; }

    public int? ModifiedBy_FK { get; set; }

    public bool IsDeleted { get; set; }

    public string BillingAddress1 { get; set; }

    public string BillingAddress2 { get; set; }

    public string BillingAddress3 { get; set; }

    public string BillingPostalCode { get; set; }

    public decimal TotalPackageAmount { get; set; }

    public string Email { get; set; }

    public string PackageList { get; set; }
}