namespace OdooRpc.CoreCLR.Client.V8.Models;

public partial class ResLang
{
    public virtual string name { get; set; }
    public virtual string code { get; set; }
    public virtual string iso_code { get; set; }
    public virtual string url_code { get; set; }
    public virtual bool active { get; set; }
    public virtual string direction { get; set; }
    public virtual string date_format { get; set; }
    public virtual string time_format { get; set; }
    public virtual string week_start { get; set; }
    public virtual string grouping { get; set; }
    public virtual string decimal_point { get; set; }
    public virtual string thousands_sep { get; set; }
    public virtual string flag_image { get; set; }
    public virtual string flag_image_url { get; set; }
    public virtual long id { get; set; }
    public virtual string display_name { get; set; }
    public virtual object create_uid { get; set; }
    public virtual string create_date { get; set; }
    public virtual object write_uid { get; set; }
    public virtual string write_date { get; set; }
}