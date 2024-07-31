namespace OdooRpc.CoreCLR.Client.V8.Models;

public partial class SignTemplate
{
    public virtual object attachment_id { get; set; }
    public virtual string name { get; set; }
    public virtual long num_pages { get; set; }
    public virtual string datas { get; set; }
    public virtual long[] sign_item_ids { get; set; }
    public virtual long responsible_count { get; set; }
    public virtual bool active { get; set; }
    public virtual long[] favorited_ids { get; set; }
    public virtual object user_id { get; set; }
    public virtual long[] sign_request_ids { get; set; }
    public virtual long[] tag_ids { get; set; }
    public virtual long color { get; set; }
    public virtual string redirect_url { get; set; }
    public virtual string redirect_url_text { get; set; }
    public virtual long signed_count { get; set; }
    public virtual long in_progress_count { get; set; }
    public virtual long[] authorized_ids { get; set; }
    public virtual long[] group_ids { get; set; }
    public virtual bool has_sign_requests { get; set; }
    public virtual bool is_sharing { get; set; }
    public virtual long id { get; set; }
    public virtual string display_name { get; set; }
    public virtual object create_uid { get; set; }
    public virtual string create_date { get; set; }
    public virtual object write_uid { get; set; }
    public virtual string write_date { get; set; }
}