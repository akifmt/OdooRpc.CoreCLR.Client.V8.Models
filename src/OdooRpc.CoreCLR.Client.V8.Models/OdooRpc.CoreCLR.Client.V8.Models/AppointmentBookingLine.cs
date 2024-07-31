namespace OdooRpc.CoreCLR.Client.V8.Models;

public partial class AppointmentBookingLine
{
    public virtual bool active { get; set; }
    public virtual object appointment_resource_id { get; set; }
    public virtual object appointment_type_id { get; set; }
    public virtual long capacity_reserved { get; set; }
    public virtual long capacity_used { get; set; }
    public virtual object calendar_event_id { get; set; }
    public virtual string event_start { get; set; }
    public virtual string event_stop { get; set; }
    public virtual long id { get; set; }
    public virtual string display_name { get; set; }
    public virtual object create_uid { get; set; }
    public virtual string create_date { get; set; }
    public virtual object write_uid { get; set; }
    public virtual string write_date { get; set; }
}