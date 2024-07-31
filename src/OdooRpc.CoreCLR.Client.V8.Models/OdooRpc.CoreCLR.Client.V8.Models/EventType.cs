namespace OdooRpc.CoreCLR.Client.V8.Models;

public partial class EventType
{
    public virtual string name { get; set; }
    public virtual string note { get; set; }
    public virtual long sequence { get; set; }
    public virtual long[] event_type_ticket_ids { get; set; }
    public virtual long[] tag_ids { get; set; }
    public virtual bool has_seats_limitation { get; set; }
    public virtual long seats_max { get; set; }
    public virtual string default_timezone { get; set; }
    public virtual long[] event_type_mail_ids { get; set; }
    public virtual string ticket_instructions { get; set; }
    public virtual long id { get; set; }
    public virtual string display_name { get; set; }
    public virtual object create_uid { get; set; }
    public virtual string create_date { get; set; }
    public virtual object write_uid { get; set; }
    public virtual string write_date { get; set; }
    public virtual bool website_menu { get; set; }
    public virtual bool community_menu { get; set; }
    public virtual bool menu_register_cta { get; set; }
    public virtual long[] question_ids { get; set; }
}