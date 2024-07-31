namespace OdooRpc.CoreCLR.Client.V8.Models;

public partial class AccountReportFileDownloadErrorWizard
{
    public virtual string file_generation_errors { get; set; }
    public virtual string file_name { get; set; }
    public virtual string file_content { get; set; }
    public virtual long id { get; set; }
    public virtual string display_name { get; set; }
    public virtual object create_uid { get; set; }
    public virtual string create_date { get; set; }
    public virtual object write_uid { get; set; }
    public virtual string write_date { get; set; }
}