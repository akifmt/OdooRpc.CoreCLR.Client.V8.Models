namespace OdooRpc.CoreCLR.Client.V8.Models;

public partial class StockTrackLine
{
    public virtual string product_display_name { get; set; }
    public virtual object product_id { get; set; }
    public virtual string tracking { get; set; }
    public virtual object wizard_id { get; set; }
    public virtual long id { get; set; }
    public virtual string display_name { get; set; }
    public virtual object create_uid { get; set; }
    public virtual string create_date { get; set; }
    public virtual object write_uid { get; set; }
    public virtual string write_date { get; set; }
}