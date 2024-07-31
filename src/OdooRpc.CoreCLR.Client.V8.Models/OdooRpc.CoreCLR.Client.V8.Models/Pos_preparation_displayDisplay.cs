namespace OdooRpc.CoreCLR.Client.V8.Models;

public partial class Pos_preparation_displayDisplay
{
    public virtual string access_token { get; set; }
    public virtual string name { get; set; }
    public virtual object company_id { get; set; }
    public virtual long[] pos_config_ids { get; set; }
    public virtual long[] category_ids { get; set; }
    public virtual long order_count { get; set; }
    public virtual long average_time { get; set; }
    public virtual long[] stage_ids { get; set; }
    public virtual bool contains_bar_restaurant { get; set; }
    public virtual long id { get; set; }
    public virtual string display_name { get; set; }
    public virtual object create_uid { get; set; }
    public virtual string create_date { get; set; }
    public virtual object write_uid { get; set; }
    public virtual string write_date { get; set; }
}