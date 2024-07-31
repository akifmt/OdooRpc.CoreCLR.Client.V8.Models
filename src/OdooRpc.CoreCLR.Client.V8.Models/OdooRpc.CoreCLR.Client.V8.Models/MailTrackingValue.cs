namespace OdooRpc.CoreCLR.Client.V8.Models;

public partial class MailTrackingValue
{
    public virtual object field_id { get; set; }
    public virtual string field_info { get; set; }
    public virtual long old_value_integer { get; set; }
    public virtual double old_value_float { get; set; }
    public virtual string old_value_char { get; set; }
    public virtual string old_value_text { get; set; }
    public virtual string old_value_datetime { get; set; }
    public virtual long new_value_integer { get; set; }
    public virtual double new_value_float { get; set; }
    public virtual string new_value_char { get; set; }
    public virtual string new_value_text { get; set; }
    public virtual string new_value_datetime { get; set; }
    public virtual object currency_id { get; set; }
    public virtual object mail_message_id { get; set; }
    public virtual long id { get; set; }
    public virtual string display_name { get; set; }
    public virtual object create_uid { get; set; }
    public virtual string create_date { get; set; }
    public virtual object write_uid { get; set; }
    public virtual string write_date { get; set; }
}