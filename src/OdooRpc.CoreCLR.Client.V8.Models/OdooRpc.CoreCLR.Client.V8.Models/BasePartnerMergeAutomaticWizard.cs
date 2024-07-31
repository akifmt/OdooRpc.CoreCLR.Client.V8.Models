namespace OdooRpc.CoreCLR.Client.V8.Models;

public partial class BasePartnerMergeAutomaticWizard
{
    public virtual bool group_by_email { get; set; }
    public virtual bool group_by_name { get; set; }
    public virtual bool group_by_is_company { get; set; }
    public virtual bool group_by_vat { get; set; }
    public virtual bool group_by_parent_id { get; set; }
    public virtual string state { get; set; }
    public virtual long number_group { get; set; }
    public virtual object current_line_id { get; set; }
    public virtual long[] line_ids { get; set; }
    public virtual long[] partner_ids { get; set; }
    public virtual object dst_partner_id { get; set; }
    public virtual bool exclude_contact { get; set; }
    public virtual bool exclude_journal_item { get; set; }
    public virtual long maximum_group { get; set; }
    public virtual long id { get; set; }
    public virtual string display_name { get; set; }
    public virtual object create_uid { get; set; }
    public virtual string create_date { get; set; }
    public virtual object write_uid { get; set; }
    public virtual string write_date { get; set; }
}