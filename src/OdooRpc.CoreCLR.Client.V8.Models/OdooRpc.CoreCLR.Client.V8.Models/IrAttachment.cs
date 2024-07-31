using System.Text.Json.Serialization;

namespace OdooRpc.CoreCLR.Client.V8.Models;

public partial class IrAttachment
{
    public virtual string name { get; set; }
    public virtual string description { get; set; }
    public virtual string res_name { get; set; }
    public virtual string res_model { get; set; }
    public virtual string res_field { get; set; }
    public virtual string res_id { get; set; }
    public virtual object company_id { get; set; }

    [JsonPropertyName("type")]
    public virtual string type_ { get; set; }

    public virtual string url { get; set; }

    [JsonPropertyName("public")]
    public virtual bool public_ { get; set; }

    public virtual string access_token { get; set; }
    public virtual string raw { get; set; }
    public virtual string datas { get; set; }
    public virtual string db_datas { get; set; }
    public virtual string store_fname { get; set; }
    public virtual long file_size { get; set; }
    public virtual string checksum { get; set; }
    public virtual string mimetype { get; set; }
    public virtual string index_content { get; set; }
    public virtual long id { get; set; }
    public virtual string display_name { get; set; }
    public virtual object create_uid { get; set; }
    public virtual string create_date { get; set; }
    public virtual object write_uid { get; set; }
    public virtual string write_date { get; set; }
    public virtual long[] voice_ids { get; set; }
    public virtual string local_url { get; set; }
    public virtual string image_src { get; set; }
    public virtual long image_width { get; set; }
    public virtual long image_height { get; set; }
    public virtual object original_id { get; set; }
    public virtual string key { get; set; }
    public virtual object website_id { get; set; }
    public virtual object theme_template_id { get; set; }
}