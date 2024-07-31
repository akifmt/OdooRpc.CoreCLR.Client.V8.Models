namespace OdooRpc.CoreCLR.Client.V8.Models;

public partial class ResourceCalendar
{
    public virtual string name { get; set; }
    public virtual bool active { get; set; }
    public virtual object company_id { get; set; }
    public virtual long[] attendance_ids { get; set; }
    public virtual long[] leave_ids { get; set; }
    public virtual long[] global_leave_ids { get; set; }
    public virtual double hours_per_day { get; set; }
    public virtual string tz { get; set; }
    public virtual string tz_offset { get; set; }
    public virtual bool two_weeks_calendar { get; set; }
    public virtual string two_weeks_explanation { get; set; }
    public virtual long id { get; set; }
    public virtual string display_name { get; set; }
    public virtual object create_uid { get; set; }
    public virtual string create_date { get; set; }
    public virtual object write_uid { get; set; }
    public virtual string write_date { get; set; }
}