namespace OdooRpc.CoreCLR.Client.V8.Models;

public partial class WebsiteMenu
{
    public virtual string name { get; set; }
    public virtual string url { get; set; }
    public virtual object page_id { get; set; }
    public virtual object controller_page_id { get; set; }
    public virtual bool new_window { get; set; }
    public virtual long sequence { get; set; }
    public virtual object website_id { get; set; }
    public virtual object parent_id { get; set; }
    public virtual long[] child_id { get; set; }
    public virtual string parent_path { get; set; }
    public virtual bool is_visible { get; set; }
    public virtual bool is_mega_menu { get; set; }
    public virtual string mega_menu_content { get; set; }
    public virtual string mega_menu_classes { get; set; }
    public virtual long id { get; set; }
    public virtual string display_name { get; set; }
    public virtual object create_uid { get; set; }
    public virtual string create_date { get; set; }
    public virtual object write_uid { get; set; }
    public virtual string write_date { get; set; }
    public virtual object theme_template_id { get; set; }
}