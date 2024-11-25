﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
#nullable disable
using System;
using System.Collections.Generic;

namespace C4WX1_DbMigrator.Models;

public partial class VitalSignType
{
    public int id { get; set; }

    public string name { get; set; }

    public bool isDeleted { get; set; }

    public int? createdBy { get; set; }

    public DateTime createdDate { get; set; }

    public int? updatedBy { get; set; }

    public DateTime? updatedDate { get; set; }

    public virtual ICollection<DiseaseVitalSignType> DiseaseVitalSignTypes { get; set; } = new List<DiseaseVitalSignType>();

    public virtual ICollection<MedicationVitalSignType> MedicationVitalSignTypes { get; set; } = new List<MedicationVitalSignType>();

    public virtual ICollection<VitalSignDetail> VitalSignDetails { get; set; } = new List<VitalSignDetail>();

    public virtual ICollection<VitalSignRelationship> VitalSignRelationships { get; set; } = new List<VitalSignRelationship>();

    public virtual VitalSignTypeThreshold VitalSignTypeThreshold { get; set; }
}