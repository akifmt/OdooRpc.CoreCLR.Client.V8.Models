namespace OdooRpc.CoreCLR.Client.V8.Models;

public partial class SignRequestItemValue
{
    public virtual object sign_request_item_id { get; set; }
    public virtual object sign_item_id { get; set; }
    public virtual object sign_request_id { get; set; }
    public virtual string value { get; set; }
    public virtual string frame_value { get; set; }
    public virtual bool frame_has_hash { get; set; }
    public virtual long id { get; set; }
    public virtual string display_name { get; set; }
    public virtual object create_uid { get; set; }
    public virtual string create_date { get; set; }
    public virtual object write_uid { get; set; }
    public virtual string write_date { get; set; }
}