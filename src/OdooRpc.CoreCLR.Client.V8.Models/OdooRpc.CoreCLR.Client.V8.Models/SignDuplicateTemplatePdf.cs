namespace OdooRpc.CoreCLR.Client.V8.Models;

public partial class SignDuplicateTemplatePdf
{
    public virtual string new_pdf { get; set; }
    public virtual object original_template_id { get; set; }
    public virtual string new_template { get; set; }
    public virtual long id { get; set; }
    public virtual string display_name { get; set; }
    public virtual object create_uid { get; set; }
    public virtual string create_date { get; set; }
    public virtual object write_uid { get; set; }
    public virtual string write_date { get; set; }
}