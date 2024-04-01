using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace ASP.NET_Core_WEBAPI.Models;

public partial class Student
{
    [Key]
    public int Id { get; set; }

    public string? StudentName { get; set; }

    public int? Age { get; set; }

    public string? Gender { get; set; }
}
