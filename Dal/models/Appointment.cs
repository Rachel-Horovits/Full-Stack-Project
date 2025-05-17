using System;
using System.Collections.Generic;

namespace Dal.models;

public partial class Appointment
{
    public int Id { get; set; }

    public DateTime Date { get; set; }

    public TimeSpan Hour { get; set; }
    public int TreatmentDuration { get; set; } 
    
    public string DoctorId { get; set; }

    public string ClientId { get; set; } = null!;

    public virtual Client Client { get; set; } = null!;

    public virtual Doctor Doctor { get; set; } = null!;

    public Appointment FirstOrDefault(Func<object, bool> value)
    {
        throw new NotImplementedException();
    }
}

