namespace OdooRpc.CoreCLR.Client.V8.Models;

public partial class AppointmentSlot
{
    public virtual object appointment_type_id { get; set; }
    public virtual string schedule_based_on { get; set; }
    public virtual string slot_type { get; set; }
    public virtual bool allday { get; set; }
    public virtual long[] restrict_to_user_ids { get; set; }
    public virtual long[] restrict_to_resource_ids { get; set; }
    public virtual string weekday { get; set; }
    public virtual double start_hour { get; set; }
    public virtual double end_hour { get; set; }
    public virtual string start_datetime { get; set; }
    public virtual string end_datetime { get; set; }
    public virtual double duration { get; set; }
    public virtual long id { get; set; }
    public virtual string display_name { get; set; }
    public virtual object create_uid { get; set; }
    public virtual string create_date { get; set; }
    public virtual object write_uid { get; set; }
    public virtual string write_date { get; set; }
}