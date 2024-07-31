namespace OdooRpc.CoreCLR.Client.V8.Models;

public partial class CalendarAlarm
{
    public virtual string name { get; set; }
    public virtual string alarm_type { get; set; }
    public virtual long duration { get; set; }
    public virtual string interval { get; set; }
    public virtual long duration_minutes { get; set; }
    public virtual object mail_template_id { get; set; }
    public virtual string body { get; set; }
    public virtual long id { get; set; }
    public virtual string display_name { get; set; }
    public virtual object create_uid { get; set; }
    public virtual string create_date { get; set; }
    public virtual object write_uid { get; set; }
    public virtual string write_date { get; set; }
    public virtual bool default_for_new_appointment_type { get; set; }
    public virtual object sms_template_id { get; set; }
    public virtual bool sms_notify_responsible { get; set; }
}