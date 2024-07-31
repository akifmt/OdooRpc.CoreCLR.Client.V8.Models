namespace OdooRpc.CoreCLR.Client.V8.Models;

public partial class WebsiteConfiguratorFeature
{
    public virtual long sequence { get; set; }
    public virtual string name { get; set; }
    public virtual string description { get; set; }
    public virtual string icon { get; set; }
    public virtual string iap_page_code { get; set; }
    public virtual string website_config_preselection { get; set; }
    public virtual object page_view_id { get; set; }
    public virtual object module_id { get; set; }
    public virtual string feature_url { get; set; }
    public virtual long menu_sequence { get; set; }
    public virtual bool menu_company { get; set; }
    public virtual long id { get; set; }
    public virtual string display_name { get; set; }
    public virtual object create_uid { get; set; }
    public virtual string create_date { get; set; }
    public virtual object write_uid { get; set; }
    public virtual string write_date { get; set; }
}