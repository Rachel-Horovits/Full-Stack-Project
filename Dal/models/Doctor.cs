using System;
using System.Collections.Generic;

namespace Dal.models;

public partial class Doctor
{
    public string Id { get; set; }

    public string Name { get; set; } = null!;

    public int AddressId { get; set; }

    public string Specialization { get; set; } = null!;

    public virtual Address Address { get; set; } = null!;

    public virtual ICollection<Appointment> Appointments { get; set; } = new List<Appointment>();
}
