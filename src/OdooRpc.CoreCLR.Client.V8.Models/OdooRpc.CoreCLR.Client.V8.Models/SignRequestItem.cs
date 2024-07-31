namespace OdooRpc.CoreCLR.Client.V8.Models;

public partial class SignRequestItem
{
    public virtual string access_url { get; set; }
    public virtual string access_token { get; set; }
    public virtual string access_warning { get; set; }
    public virtual string display_name { get; set; }
    public virtual object partner_id { get; set; }
    public virtual object sign_request_id { get; set; }
    public virtual long[] sign_item_value_ids { get; set; }
    public virtual string reference { get; set; }
    public virtual long mail_sent_order { get; set; }
    public virtual object communication_company_id { get; set; }
    public virtual bool access_via_link { get; set; }
    public virtual object role_id { get; set; }
    public virtual string sms_number { get; set; }
    public virtual string sms_token { get; set; }
    public virtual bool signed_without_extra_auth { get; set; }
    public virtual string signature { get; set; }
    public virtual string frame_hash { get; set; }
    public virtual string signing_date { get; set; }
    public virtual string state { get; set; }
    public virtual long color { get; set; }
    public virtual bool ignored { get; set; }
    public virtual string signer_email { get; set; }
    public virtual bool is_mail_sent { get; set; }
    public virtual bool change_authorized { get; set; }
    public virtual double latitude { get; set; }
    public virtual double longitude { get; set; }
    public virtual long id { get; set; }
    public virtual object create_uid { get; set; }
    public virtual string create_date { get; set; }
    public virtual object write_uid { get; set; }
    public virtual string write_date { get; set; }
}