namespace OdooRpc.CoreCLR.Client.V8.Models;

public partial class ResCountry
{
    public virtual string name { get; set; }
    public virtual string code { get; set; }
    public virtual string address_format { get; set; }
    public virtual object address_view_id { get; set; }
    public virtual object currency_id { get; set; }
    public virtual string image_url { get; set; }
    public virtual long phone_code { get; set; }
    public virtual long[] country_group_ids { get; set; }
    public virtual long[] state_ids { get; set; }
    public virtual string name_position { get; set; }
    public virtual string vat_label { get; set; }
    public virtual bool state_required { get; set; }
    public virtual bool zip_required { get; set; }
    public virtual long id { get; set; }
    public virtual string display_name { get; set; }
    public virtual object create_uid { get; set; }
    public virtual string create_date { get; set; }
    public virtual object write_uid { get; set; }
    public virtual string write_date { get; set; }
    public virtual bool is_stripe_supported_country { get; set; }
}