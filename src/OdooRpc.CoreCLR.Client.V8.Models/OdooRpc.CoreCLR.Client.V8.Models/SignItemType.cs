namespace OdooRpc.CoreCLR.Client.V8.Models;

public partial class SignItemType
{
    public virtual string name { get; set; }
    public virtual string item_type { get; set; }
    public virtual string tip { get; set; }
    public virtual string placeholder { get; set; }
    public virtual double default_width { get; set; }
    public virtual double default_height { get; set; }
    public virtual string auto_field { get; set; }
    public virtual long id { get; set; }
    public virtual string display_name { get; set; }
    public virtual object create_uid { get; set; }
    public virtual string create_date { get; set; }
    public virtual object write_uid { get; set; }
    public virtual string write_date { get; set; }
}