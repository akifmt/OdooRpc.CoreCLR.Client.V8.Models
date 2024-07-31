namespace OdooRpc.CoreCLR.Client.V8.Models;

public partial class SignSendRequest
{
    public virtual object activity_id { get; set; }
    public virtual bool has_default_template { get; set; }
    public virtual object template_id { get; set; }
    public virtual long[] signer_ids { get; set; }
    public virtual bool set_sign_order { get; set; }
    public virtual object signer_id { get; set; }
    public virtual long signers_count { get; set; }
    public virtual long[] cc_partner_ids { get; set; }
    public virtual bool is_user_signer { get; set; }
    public virtual string subject { get; set; }
    public virtual string message { get; set; }
    public virtual string message_cc { get; set; }
    public virtual long[] attachment_ids { get; set; }
    public virtual string filename { get; set; }
    public virtual string validity { get; set; }
    public virtual bool reminder_enabled { get; set; }
    public virtual long reminder { get; set; }
    public virtual long id { get; set; }
    public virtual string display_name { get; set; }
    public virtual object create_uid { get; set; }
    public virtual string create_date { get; set; }
    public virtual object write_uid { get; set; }
    public virtual string write_date { get; set; }
}