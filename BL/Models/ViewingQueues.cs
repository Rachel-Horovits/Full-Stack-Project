using Dal.models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BL.Models;
public class ViewingQueues
{
    public int Id { get; set; }
    public DateTime Date { get; set; }
    public TimeSpan Hour { get; set; }
    public int TreatmentDuration { get; set; }
    public string DoctorName { get; set; }
}
