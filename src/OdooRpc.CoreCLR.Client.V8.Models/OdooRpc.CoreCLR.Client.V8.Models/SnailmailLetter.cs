namespace OdooRpc.CoreCLR.Client.V8.Models;

public partial class SnailmailLetter
{
    public virtual object user_id { get; set; }
    public virtual string model { get; set; }
    public virtual long res_id { get; set; }
    public virtual object partner_id { get; set; }
    public virtual object company_id { get; set; }
    public virtual object report_template { get; set; }
    public virtual object attachment_id { get; set; }
    public virtual string attachment_datas { get; set; }
    public virtual string attachment_fname { get; set; }
    public virtual bool color { get; set; }
    public virtual bool cover { get; set; }
    public virtual bool duplex { get; set; }
    public virtual string state { get; set; }
    public virtual string error_code { get; set; }
    public virtual string info_msg { get; set; }
    public virtual string reference { get; set; }
    public virtual object message_id { get; set; }
    public virtual long[] notification_ids { get; set; }
    public virtual string street { get; set; }
    public virtual string street2 { get; set; }
    public virtual string zip { get; set; }
    public virtual string city { get; set; }
    public virtual object state_id { get; set; }
    public virtual object country_id { get; set; }
    public virtual long id { get; set; }
    public virtual string display_name { get; set; }
    public virtual object create_uid { get; set; }
    public virtual string create_date { get; set; }
    public virtual object write_uid { get; set; }
    public virtual string write_date { get; set; }
}