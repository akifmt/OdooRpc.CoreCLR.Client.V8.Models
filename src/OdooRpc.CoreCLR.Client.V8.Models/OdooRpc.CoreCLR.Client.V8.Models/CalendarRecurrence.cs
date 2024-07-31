namespace OdooRpc.CoreCLR.Client.V8.Models;

public partial class CalendarRecurrence
{
    public virtual string name { get; set; }
    public virtual object base_event_id { get; set; }
    public virtual long[] calendar_event_ids { get; set; }
    public virtual string event_tz { get; set; }
    public virtual string rrule { get; set; }
    public virtual string dtstart { get; set; }
    public virtual string rrule_type { get; set; }
    public virtual string end_type { get; set; }
    public virtual long interval { get; set; }
    public virtual long count { get; set; }
    public virtual bool mon { get; set; }
    public virtual bool tue { get; set; }
    public virtual bool wed { get; set; }
    public virtual bool thu { get; set; }
    public virtual bool fri { get; set; }
    public virtual bool sat { get; set; }
    public virtual bool sun { get; set; }
    public virtual string month_by { get; set; }
    public virtual long day { get; set; }
    public virtual string weekday { get; set; }
    public virtual string byday { get; set; }
    public virtual string until { get; set; }
    public virtual object trigger_id { get; set; }
    public virtual long id { get; set; }
    public virtual string display_name { get; set; }
    public virtual object create_uid { get; set; }
    public virtual string create_date { get; set; }
    public virtual object write_uid { get; set; }
    public virtual string write_date { get; set; }
}