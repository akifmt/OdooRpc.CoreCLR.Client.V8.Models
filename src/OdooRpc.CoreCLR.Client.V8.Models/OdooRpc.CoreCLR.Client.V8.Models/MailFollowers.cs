namespace OdooRpc.CoreCLR.Client.V8.Models;

public partial class MailFollowers
{
    public virtual string res_model { get; set; }
    public virtual string res_id { get; set; }
    public virtual object partner_id { get; set; }
    public virtual long[] subtype_ids { get; set; }
    public virtual string name { get; set; }
    public virtual string email { get; set; }
    public virtual bool is_active { get; set; }
    public virtual long id { get; set; }
    public virtual string display_name { get; set; }
}