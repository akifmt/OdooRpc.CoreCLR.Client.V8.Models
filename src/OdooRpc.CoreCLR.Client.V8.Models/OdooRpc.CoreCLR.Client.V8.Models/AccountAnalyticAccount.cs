namespace OdooRpc.CoreCLR.Client.V8.Models;

public partial class AccountAnalyticAccount
{
    public virtual bool message_is_follower { get; set; }
    public virtual long[] message_follower_ids { get; set; }
    public virtual long[] message_partner_ids { get; set; }
    public virtual long[] message_ids { get; set; }
    public virtual bool has_message { get; set; }
    public virtual bool message_needaction { get; set; }
    public virtual long message_needaction_counter { get; set; }
    public virtual bool message_has_error { get; set; }
    public virtual long message_has_error_counter { get; set; }
    public virtual long message_attachment_count { get; set; }
    public virtual long[] rating_ids { get; set; }
    public virtual long[] website_message_ids { get; set; }
    public virtual bool message_has_sms_error { get; set; }
    public virtual string name { get; set; }
    public virtual string code { get; set; }
    public virtual bool active { get; set; }
    public virtual object plan_id { get; set; }
    public virtual object root_plan_id { get; set; }
    public virtual long color { get; set; }
    public virtual long[] line_ids { get; set; }
    public virtual object company_id { get; set; }
    public virtual object partner_id { get; set; }
    public virtual string balance { get; set; }
    public virtual object currency_id { get; set; }
    public virtual long id { get; set; }
    public virtual string display_name { get; set; }
    public virtual object create_uid { get; set; }
    public virtual string create_date { get; set; }
    public virtual object write_uid { get; set; }
    public virtual string write_date { get; set; }
    public virtual long invoice_count { get; set; }
    public virtual long vendor_bill_count { get; set; }
    public virtual long[] project_ids { get; set; }
    public virtual long project_count { get; set; }
}