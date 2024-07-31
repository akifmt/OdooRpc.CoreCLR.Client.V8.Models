namespace OdooRpc.CoreCLR.Client.V8.Models;

public partial class AccountReportLine
{
    public virtual string name { get; set; }
    public virtual long[] expression_ids { get; set; }
    public virtual object report_id { get; set; }
    public virtual long hierarchy_level { get; set; }
    public virtual object parent_id { get; set; }
    public virtual long[] children_ids { get; set; }
    public virtual string groupby { get; set; }
    public virtual string user_groupby { get; set; }
    public virtual long sequence { get; set; }
    public virtual string code { get; set; }
    public virtual bool foldable { get; set; }
    public virtual bool print_on_new_page { get; set; }
    public virtual object action_id { get; set; }
    public virtual bool hide_if_zero { get; set; }
    public virtual string domain_formula { get; set; }
    public virtual string account_codes_formula { get; set; }
    public virtual string aggregation_formula { get; set; }
    public virtual string external_formula { get; set; }
    public virtual string horizontal_split_side { get; set; }
    public virtual string tax_tags_formula { get; set; }
    public virtual long id { get; set; }
    public virtual string display_name { get; set; }
    public virtual object create_uid { get; set; }
    public virtual string create_date { get; set; }
    public virtual object write_uid { get; set; }
    public virtual string write_date { get; set; }
}