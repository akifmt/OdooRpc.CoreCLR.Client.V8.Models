namespace OdooRpc.CoreCLR.Client.V8.Models;

public partial class SignItem
{
    public virtual object template_id { get; set; }
    public virtual object type_id { get; set; }
    public virtual bool required { get; set; }
    public virtual object responsible_id { get; set; }
    public virtual long[] option_ids { get; set; }
    public virtual string name { get; set; }
    public virtual long page { get; set; }
    public virtual double posX { get; set; }
    public virtual double posY { get; set; }
    public virtual double width { get; set; }
    public virtual double height { get; set; }
    public virtual string alignment { get; set; }
    public virtual long transaction_id { get; set; }
    public virtual long id { get; set; }
    public virtual string display_name { get; set; }
    public virtual object create_uid { get; set; }
    public virtual string create_date { get; set; }
    public virtual object write_uid { get; set; }
    public virtual string write_date { get; set; }
}