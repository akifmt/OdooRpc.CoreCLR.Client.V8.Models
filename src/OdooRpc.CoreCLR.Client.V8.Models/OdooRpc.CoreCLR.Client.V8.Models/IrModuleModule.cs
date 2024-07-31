namespace OdooRpc.CoreCLR.Client.V8.Models;

public partial class IrModuleModule
{
    public virtual string name { get; set; }
    public virtual object category_id { get; set; }
    public virtual string shortdesc { get; set; }
    public virtual string summary { get; set; }
    public virtual string description { get; set; }
    public virtual string description_html { get; set; }
    public virtual string author { get; set; }
    public virtual string maintainer { get; set; }
    public virtual string contributors { get; set; }
    public virtual string website { get; set; }
    public virtual string installed_version { get; set; }
    public virtual string latest_version { get; set; }
    public virtual string published_version { get; set; }
    public virtual string url { get; set; }
    public virtual long sequence { get; set; }
    public virtual long[] dependencies_id { get; set; }
    public virtual long[] country_ids { get; set; }
    public virtual long[] exclusion_ids { get; set; }
    public virtual bool auto_install { get; set; }
    public virtual string state { get; set; }
    public virtual bool demo { get; set; }
    public virtual string license { get; set; }
    public virtual string menus_by_module { get; set; }
    public virtual string reports_by_module { get; set; }
    public virtual string views_by_module { get; set; }
    public virtual bool application { get; set; }
    public virtual string icon { get; set; }
    public virtual string icon_image { get; set; }
    public virtual string icon_flag { get; set; }
    public virtual bool to_buy { get; set; }
    public virtual bool has_iap { get; set; }
    public virtual long id { get; set; }
    public virtual string display_name { get; set; }
    public virtual object create_uid { get; set; }
    public virtual string create_date { get; set; }
    public virtual object write_uid { get; set; }
    public virtual string write_date { get; set; }
    public virtual bool imported { get; set; }
    public virtual string module_type { get; set; }
    public virtual bool is_module_official { get; set; }
    public virtual string account_templates { get; set; }
    public virtual long[] image_ids { get; set; }
    public virtual bool is_installed_on_current_website { get; set; }
}