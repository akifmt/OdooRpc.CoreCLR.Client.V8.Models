namespace OdooRpc.CoreCLR.Client.V8.Models;

public partial class LunchAlert
{
    public virtual string name { get; set; }
    public virtual string message { get; set; }
    public virtual string mode { get; set; }
    public virtual string recipients { get; set; }
    public virtual double notification_time { get; set; }
    public virtual string notification_moment { get; set; }
    public virtual string tz { get; set; }
    public virtual object cron_id { get; set; }
    public virtual string until { get; set; }
    public virtual bool mon { get; set; }
    public virtual bool tue { get; set; }
    public virtual bool wed { get; set; }
    public virtual bool thu { get; set; }
    public virtual bool fri { get; set; }
    public virtual bool sat { get; set; }
    public virtual bool sun { get; set; }
    public virtual bool available_today { get; set; }
    public virtual bool active { get; set; }
    public virtual long[] location_ids { get; set; }
    public virtual long id { get; set; }
    public virtual string display_name { get; set; }
    public virtual object create_uid { get; set; }
    public virtual string create_date { get; set; }
    public virtual object write_uid { get; set; }
    public virtual string write_date { get; set; }
}