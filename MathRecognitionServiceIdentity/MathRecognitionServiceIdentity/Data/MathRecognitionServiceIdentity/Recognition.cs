﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
#nullable disable
using System;
using System.Collections.Generic;

namespace MathRecognitionServiceIdentityDB.Data.MathRecognitionServiceIdentity;

public partial class Recognition
{
    public long Id { get; set; }

    public string Json { get; set; }

    public string ImagePath { get; set; }

    public string UserName { get; set; }
    public DateTime? DateTime { get; set; }
}