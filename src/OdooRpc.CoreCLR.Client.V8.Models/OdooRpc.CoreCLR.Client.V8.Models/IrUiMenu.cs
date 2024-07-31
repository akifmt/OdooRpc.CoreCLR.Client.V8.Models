namespace OdooRpc.CoreCLR.Client.V8.Models;

public partial class IrUiMenu
{
    public virtual string name { get; set; }
    public virtual bool active { get; set; }
    public virtual long sequence { get; set; }
    public virtual long[] child_id { get; set; }
    public virtual object parent_id { get; set; }
    public virtual string parent_path { get; set; }
    public virtual long[] groups_id { get; set; }
    public virtual string complete_name { get; set; }
    public virtual string web_icon { get; set; }
    public virtual string action { get; set; }
    public virtual string web_icon_data { get; set; }
    public virtual long id { get; set; }
    public virtual string display_name { get; set; }
    public virtual object create_uid { get; set; }
    public virtual string create_date { get; set; }
    public virtual object write_uid { get; set; }
    public virtual string write_date { get; set; }
}