using System.Text.Json.Serialization;

namespace OdooRpc.CoreCLR.Client.V8.Models;

public partial class ReportPaperformat
{
    public virtual string name { get; set; }

    [JsonPropertyName("default")]
    public virtual bool default_ { get; set; }

    public virtual string format { get; set; }
    public virtual double margin_top { get; set; }
    public virtual double margin_bottom { get; set; }
    public virtual double margin_left { get; set; }
    public virtual double margin_right { get; set; }
    public virtual long page_height { get; set; }
    public virtual long page_width { get; set; }
    public virtual string orientation { get; set; }
    public virtual bool header_line { get; set; }
    public virtual long header_spacing { get; set; }
    public virtual bool disable_shrinking { get; set; }
    public virtual long dpi { get; set; }
    public virtual long[] report_ids { get; set; }
    public virtual double print_page_width { get; set; }
    public virtual double print_page_height { get; set; }
    public virtual long id { get; set; }
    public virtual string display_name { get; set; }
    public virtual object create_uid { get; set; }
    public virtual string create_date { get; set; }
    public virtual object write_uid { get; set; }
    public virtual string write_date { get; set; }
}