namespace OdooRpc.CoreCLR.Client.V8.Models;

public partial class AccountAccount
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
    public virtual object currency_id { get; set; }
    public virtual object company_currency_id { get; set; }
    public virtual string code { get; set; }
    public virtual bool deprecated { get; set; }
    public virtual bool used { get; set; }
    public virtual string account_type { get; set; }
    public virtual bool include_initial_balance { get; set; }
    public virtual string internal_group { get; set; }
    public virtual bool reconcile { get; set; }
    public virtual long[] tax_ids { get; set; }
    public virtual string note { get; set; }
    public virtual object company_id { get; set; }
    public virtual long[] tag_ids { get; set; }
    public virtual object group_id { get; set; }
    public virtual object root_id { get; set; }
    public virtual long[] allowed_journal_ids { get; set; }
    public virtual string opening_debit { get; set; }
    public virtual string opening_credit { get; set; }
    public virtual string opening_balance { get; set; }
    public virtual double current_balance { get; set; }
    public virtual long related_taxes_amount { get; set; }
    public virtual bool non_trade { get; set; }
    public virtual long id { get; set; }
    public virtual string display_name { get; set; }
    public virtual object create_uid { get; set; }
    public virtual string create_date { get; set; }
    public virtual object write_uid { get; set; }
    public virtual string write_date { get; set; }
}