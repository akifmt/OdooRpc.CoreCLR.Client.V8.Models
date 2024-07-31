namespace OdooRpc.CoreCLR.Client.V8.Models;

public partial class CalendarBookingLine
{
    public virtual object appointment_resource_id { get; set; }
    public virtual object calendar_booking_id { get; set; }
    public virtual long capacity_reserved { get; set; }
    public virtual long capacity_used { get; set; }
    public virtual long id { get; set; }
    public virtual string display_name { get; set; }
    public virtual object create_uid { get; set; }
    public virtual string create_date { get; set; }
    public virtual object write_uid { get; set; }
    public virtual string write_date { get; set; }
}