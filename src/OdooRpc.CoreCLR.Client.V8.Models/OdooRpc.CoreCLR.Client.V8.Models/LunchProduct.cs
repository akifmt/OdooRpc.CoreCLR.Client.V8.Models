namespace OdooRpc.CoreCLR.Client.V8.Models;

public partial class LunchProduct
{
    public virtual string image_1920 { get; set; }
    public virtual string image_1024 { get; set; }
    public virtual string image_512 { get; set; }
    public virtual string image_256 { get; set; }
    public virtual string image_128 { get; set; }
    public virtual string name { get; set; }
    public virtual object category_id { get; set; }
    public virtual string description { get; set; }
    public virtual double price { get; set; }
    public virtual object supplier_id { get; set; }
    public virtual bool active { get; set; }
    public virtual object company_id { get; set; }
    public virtual object currency_id { get; set; }
    public virtual string new_until { get; set; }
    public virtual bool is_new { get; set; }
    public virtual long[] favorite_user_ids { get; set; }
    public virtual bool is_favorite { get; set; }
    public virtual string last_order_date { get; set; }
    public virtual string product_image { get; set; }
    public virtual object is_available_at { get; set; }
    public virtual long id { get; set; }
    public virtual string display_name { get; set; }
    public virtual object create_uid { get; set; }
    public virtual string create_date { get; set; }
    public virtual object write_uid { get; set; }
    public virtual string write_date { get; set; }
}