namespace OdooRpc.CoreCLR.Client.V8.Models;

public partial class BaseDocumentLayout
{
    public virtual object company_id { get; set; }
    public virtual string logo { get; set; }
    public virtual string preview_logo { get; set; }
    public virtual string report_header { get; set; }
    public virtual string report_footer { get; set; }
    public virtual string company_details { get; set; }
    public virtual bool is_company_details_empty { get; set; }
    public virtual object paperformat_id { get; set; }
    public virtual object external_report_layout_id { get; set; }
    public virtual string font { get; set; }
    public virtual string primary_color { get; set; }
    public virtual string secondary_color { get; set; }
    public virtual bool custom_colors { get; set; }
    public virtual string logo_primary_color { get; set; }
    public virtual string logo_secondary_color { get; set; }
    public virtual string layout_background { get; set; }
    public virtual string layout_background_image { get; set; }
    public virtual object report_layout_id { get; set; }
    public virtual string preview { get; set; }
    public virtual object partner_id { get; set; }
    public virtual string phone { get; set; }
    public virtual string email { get; set; }
    public virtual string website { get; set; }
    public virtual string vat { get; set; }
    public virtual string name { get; set; }
    public virtual object country_id { get; set; }
    public virtual long id { get; set; }
    public virtual string display_name { get; set; }
    public virtual object create_uid { get; set; }
    public virtual string create_date { get; set; }
    public virtual object write_uid { get; set; }
    public virtual string write_date { get; set; }
}