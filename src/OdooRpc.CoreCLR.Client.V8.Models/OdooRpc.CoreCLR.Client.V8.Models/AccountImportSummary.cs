namespace OdooRpc.CoreCLR.Client.V8.Models;

public partial class AccountImportSummary
{
    public virtual long[] import_summary_account_ids { get; set; }
    public virtual long[] import_summary_journal_ids { get; set; }
    public virtual long[] import_summary_move_ids { get; set; }
    public virtual long[] import_summary_partner_ids { get; set; }
    public virtual long[] import_summary_tax_ids { get; set; }
    public virtual string import_summary_name { get; set; }
    public virtual long import_summary_len_account { get; set; }
    public virtual long import_summary_len_journal { get; set; }
    public virtual long import_summary_len_move { get; set; }
    public virtual long import_summary_len_partner { get; set; }
    public virtual long import_summary_len_tax { get; set; }
    public virtual bool import_summary_have_data { get; set; }
    public virtual long id { get; set; }
    public virtual string display_name { get; set; }
    public virtual object create_uid { get; set; }
    public virtual string create_date { get; set; }
    public virtual object write_uid { get; set; }
    public virtual string write_date { get; set; }
}