namespace OdooRpc.CoreCLR.Client.V8.Models;

public partial class CalendarAttendee
{
    public virtual object event_id { get; set; }
    public virtual object recurrence_id { get; set; }
    public virtual object partner_id { get; set; }
    public virtual string email { get; set; }
    public virtual string phone { get; set; }
    public virtual string common_name { get; set; }
    public virtual string access_token { get; set; }
    public virtual string mail_tz { get; set; }
    public virtual string state { get; set; }
    public virtual string availability { get; set; }
    public virtual long id { get; set; }
    public virtual string display_name { get; set; }
    public virtual object create_uid { get; set; }
    public virtual string create_date { get; set; }
    public virtual object write_uid { get; set; }
    public virtual string write_date { get; set; }
}