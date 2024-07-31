using System.Text.Json.Serialization;

namespace OdooRpc.CoreCLR.Client.V8.Models;

public partial class IrUiView
{
    public virtual bool is_seo_optimized { get; set; }
    public virtual string website_meta_title { get; set; }
    public virtual string website_meta_description { get; set; }
    public virtual string website_meta_keywords { get; set; }
    public virtual string website_meta_og_img { get; set; }
    public virtual string seo_name { get; set; }
    public virtual string name { get; set; }
    public virtual string model { get; set; }
    public virtual string key { get; set; }
    public virtual long priority { get; set; }

    [JsonPropertyName("type")]
    public virtual string type_ { get; set; }

    public virtual string arch { get; set; }
    public virtual string arch_base { get; set; }
    public virtual string arch_db { get; set; }
    public virtual string arch_fs { get; set; }
    public virtual bool arch_updated { get; set; }
    public virtual string arch_prev { get; set; }
    public virtual object inherit_id { get; set; }
    public virtual long[] inherit_children_ids { get; set; }
    public virtual object model_data_id { get; set; }
    public virtual string xml_id { get; set; }
    public virtual long[] groups_id { get; set; }
    public virtual string mode { get; set; }
    public virtual bool active { get; set; }
    public virtual object model_id { get; set; }
    public virtual long id { get; set; }
    public virtual string display_name { get; set; }
    public virtual object create_uid { get; set; }
    public virtual string create_date { get; set; }
    public virtual object write_uid { get; set; }
    public virtual string write_date { get; set; }
    public virtual bool customize_show { get; set; }
    public virtual object website_id { get; set; }
    public virtual long[] page_ids { get; set; }
    public virtual long[] controller_page_ids { get; set; }
    public virtual object first_page_id { get; set; }
    public virtual bool track { get; set; }
    public virtual string visibility { get; set; }
    public virtual string visibility_password { get; set; }
    public virtual string visibility_password_display { get; set; }
    public virtual object theme_template_id { get; set; }
}