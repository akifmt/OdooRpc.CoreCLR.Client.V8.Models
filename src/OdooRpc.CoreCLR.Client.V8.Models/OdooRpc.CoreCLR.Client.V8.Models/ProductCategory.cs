namespace OdooRpc.CoreCLR.Client.V8.Models;

public partial class ProductCategory
{
    public virtual string name { get; set; }
    public virtual string complete_name { get; set; }
    public virtual object parent_id { get; set; }
    public virtual string parent_path { get; set; }
    public virtual long[] child_id { get; set; }
    public virtual long product_count { get; set; }
    public virtual string product_properties_definition { get; set; }
    public virtual long id { get; set; }
    public virtual string display_name { get; set; }
    public virtual object create_uid { get; set; }
    public virtual string create_date { get; set; }
    public virtual object write_uid { get; set; }
    public virtual string write_date { get; set; }
    public virtual object property_account_income_categ_id { get; set; }
    public virtual object property_account_expense_categ_id { get; set; }
}