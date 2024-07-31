using System.Text.Json.Serialization;

namespace OdooRpc.CoreCLR.Client.V8.Models;

public partial class AccountAnalyticLine
{
    public virtual string name { get; set; }
    public virtual string date { get; set; }
    public virtual string amount { get; set; }
    public virtual double unit_amount { get; set; }
    public virtual object product_uom_id { get; set; }
    public virtual object product_uom_category_id { get; set; }
    public virtual object account_id { get; set; }
    public virtual object auto_account_id { get; set; }
    public virtual object partner_id { get; set; }
    public virtual object user_id { get; set; }
    public virtual object company_id { get; set; }
    public virtual object currency_id { get; set; }
    public virtual string category { get; set; }
    public virtual long id { get; set; }
    public virtual string display_name { get; set; }
    public virtual object create_uid { get; set; }
    public virtual string create_date { get; set; }
    public virtual object write_uid { get; set; }
    public virtual string write_date { get; set; }
    public virtual object product_id { get; set; }
    public virtual object general_account_id { get; set; }
    public virtual object journal_id { get; set; }
    public virtual object move_line_id { get; set; }
    public virtual string code { get; set; }

    [JsonPropertyName("ref")]
    public virtual string ref_ { get; set; }

    public virtual object so_line { get; set; }
}