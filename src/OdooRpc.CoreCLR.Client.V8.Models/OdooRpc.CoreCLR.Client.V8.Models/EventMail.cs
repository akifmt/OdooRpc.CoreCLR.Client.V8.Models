namespace OdooRpc.CoreCLR.Client.V8.Models;

public partial class EventMail
{
    public virtual object event_id { get; set; }
    public virtual long sequence { get; set; }
    public virtual string notification_type { get; set; }
    public virtual long interval_nbr { get; set; }
    public virtual string interval_unit { get; set; }
    public virtual string interval_type { get; set; }
    public virtual string scheduled_date { get; set; }
    public virtual long[] mail_registration_ids { get; set; }
    public virtual bool mail_done { get; set; }
    public virtual string mail_state { get; set; }
    public virtual long mail_count_done { get; set; }
    public virtual object template_model_id { get; set; }
    public virtual string template_ref { get; set; }
    public virtual long id { get; set; }
    public virtual string display_name { get; set; }
    public virtual object create_uid { get; set; }
    public virtual string create_date { get; set; }
    public virtual object write_uid { get; set; }
    public virtual string write_date { get; set; }
}