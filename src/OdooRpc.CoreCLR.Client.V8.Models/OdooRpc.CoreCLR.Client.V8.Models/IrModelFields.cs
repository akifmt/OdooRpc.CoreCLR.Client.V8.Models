using System.Text.Json.Serialization;

namespace OdooRpc.CoreCLR.Client.V8.Models;

public partial class IrModelFields
{
    public virtual string name { get; set; }
    public virtual string complete_name { get; set; }
    public virtual string model { get; set; }
    public virtual string relation { get; set; }
    public virtual string relation_field { get; set; }
    public virtual object relation_field_id { get; set; }
    public virtual object model_id { get; set; }
    public virtual string field_description { get; set; }
    public virtual string help { get; set; }
    public virtual string ttype { get; set; }
    public virtual string selection { get; set; }
    public virtual long[] selection_ids { get; set; }
    public virtual bool copied { get; set; }
    public virtual string related { get; set; }
    public virtual object related_field_id { get; set; }
    public virtual bool required { get; set; }

    [JsonPropertyName("readonly")]
    public virtual bool readonly_ { get; set; }

    public virtual bool index { get; set; }
    public virtual bool translate { get; set; }
    public virtual long size { get; set; }
    public virtual string state { get; set; }
    public virtual string on_delete { get; set; }
    public virtual string domain { get; set; }
    public virtual long[] groups { get; set; }
    public virtual bool group_expand { get; set; }
    public virtual bool selectable { get; set; }
    public virtual string modules { get; set; }
    public virtual string relation_table { get; set; }
    public virtual string column1 { get; set; }
    public virtual string column2 { get; set; }
    public virtual string compute { get; set; }
    public virtual string depends { get; set; }
    public virtual bool store { get; set; }
    public virtual string currency_field { get; set; }
    public virtual bool sanitize { get; set; }
    public virtual bool sanitize_overridable { get; set; }
    public virtual bool sanitize_tags { get; set; }
    public virtual bool sanitize_attributes { get; set; }
    public virtual bool sanitize_style { get; set; }
    public virtual bool sanitize_form { get; set; }
    public virtual bool strip_style { get; set; }
    public virtual bool strip_classes { get; set; }
    public virtual long id { get; set; }
    public virtual string display_name { get; set; }
    public virtual object create_uid { get; set; }
    public virtual string create_date { get; set; }
    public virtual object write_uid { get; set; }
    public virtual string write_date { get; set; }
    public virtual long tracking { get; set; }
    public virtual bool website_form_blacklisted { get; set; }
}