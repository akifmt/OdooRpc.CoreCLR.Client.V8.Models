using System.Text.Json.Serialization;

namespace OdooRpc.CoreCLR.Client.V8.Models;

public partial class Mrp_workorderAdditionalProduct
{
    public virtual object product_id { get; set; }
    public virtual string product_tracking { get; set; }
    public virtual double product_qty { get; set; }
    public virtual object product_uom_id { get; set; }
    public virtual object product_uom_category_id { get; set; }

    [JsonPropertyName("type")]
    public virtual string type_ { get; set; }

    public virtual object production_id { get; set; }
    public virtual object workorder_id { get; set; }
    public virtual object company_id { get; set; }
    public virtual long id { get; set; }
    public virtual string display_name { get; set; }
    public virtual object create_uid { get; set; }
    public virtual string create_date { get; set; }
    public virtual object write_uid { get; set; }
    public virtual string write_date { get; set; }
}