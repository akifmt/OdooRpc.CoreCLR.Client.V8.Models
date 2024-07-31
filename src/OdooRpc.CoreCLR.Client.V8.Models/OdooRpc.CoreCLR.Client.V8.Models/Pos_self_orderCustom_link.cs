namespace OdooRpc.CoreCLR.Client.V8.Models;

public partial class Pos_self_orderCustom_link
{
    public virtual string name { get; set; }
    public virtual string url { get; set; }
    public virtual long[] pos_config_ids { get; set; }
    public virtual string style { get; set; }
    public virtual string link_html { get; set; }
    public virtual long sequence { get; set; }
    public virtual long id { get; set; }
    public virtual string display_name { get; set; }
    public virtual object create_uid { get; set; }
    public virtual string create_date { get; set; }
    public virtual object write_uid { get; set; }
    public virtual string write_date { get; set; }
}