namespace OdooRpc.CoreCLR.Client.V8.Models;

public partial class ResourceCalendarAttendance
{
    public virtual string name { get; set; }
    public virtual string dayofweek { get; set; }
    public virtual string date_from { get; set; }
    public virtual string date_to { get; set; }
    public virtual double hour_from { get; set; }
    public virtual double hour_to { get; set; }
    public virtual double duration_hours { get; set; }
    public virtual double duration_days { get; set; }
    public virtual object calendar_id { get; set; }
    public virtual string day_period { get; set; }
    public virtual object resource_id { get; set; }
    public virtual string week_type { get; set; }
    public virtual bool two_weeks_calendar { get; set; }
    public virtual string display_type { get; set; }
    public virtual long sequence { get; set; }
    public virtual long id { get; set; }
    public virtual string display_name { get; set; }
    public virtual object create_uid { get; set; }
    public virtual string create_date { get; set; }
    public virtual object write_uid { get; set; }
    public virtual string write_date { get; set; }
}