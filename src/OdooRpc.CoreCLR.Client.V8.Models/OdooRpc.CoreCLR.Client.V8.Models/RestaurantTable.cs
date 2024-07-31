namespace OdooRpc.CoreCLR.Client.V8.Models;

public partial class RestaurantTable
{
    public virtual string name { get; set; }
    public virtual object floor_id { get; set; }
    public virtual string shape { get; set; }
    public virtual double position_h { get; set; }
    public virtual double position_v { get; set; }
    public virtual double width { get; set; }
    public virtual double height { get; set; }
    public virtual long seats { get; set; }
    public virtual string color { get; set; }
    public virtual object parent_id { get; set; }
    public virtual bool active { get; set; }
    public virtual long id { get; set; }
    public virtual string display_name { get; set; }
    public virtual object create_uid { get; set; }
    public virtual string create_date { get; set; }
    public virtual object write_uid { get; set; }
    public virtual string write_date { get; set; }
    public virtual string identifier { get; set; }
}