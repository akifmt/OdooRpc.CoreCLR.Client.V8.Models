namespace OdooRpc.CoreCLR.Client.V8.Models;

public partial class EventEventTicket
{
    public virtual long sequence { get; set; }
    public virtual string name { get; set; }
    public virtual string description { get; set; }
    public virtual object event_type_id { get; set; }
    public virtual bool seats_limited { get; set; }
    public virtual long seats_max { get; set; }
    public virtual long id { get; set; }
    public virtual string display_name { get; set; }
    public virtual object create_uid { get; set; }
    public virtual string create_date { get; set; }
    public virtual object write_uid { get; set; }
    public virtual string write_date { get; set; }
    public virtual object event_id { get; set; }
    public virtual object company_id { get; set; }
    public virtual string start_sale_datetime { get; set; }
    public virtual string end_sale_datetime { get; set; }
    public virtual bool is_launched { get; set; }
    public virtual bool is_expired { get; set; }
    public virtual bool sale_available { get; set; }
    public virtual long[] registration_ids { get; set; }
    public virtual long seats_reserved { get; set; }
    public virtual long seats_available { get; set; }
    public virtual long seats_used { get; set; }
    public virtual long seats_taken { get; set; }
    public virtual bool is_sold_out { get; set; }
    public virtual string color { get; set; }
}