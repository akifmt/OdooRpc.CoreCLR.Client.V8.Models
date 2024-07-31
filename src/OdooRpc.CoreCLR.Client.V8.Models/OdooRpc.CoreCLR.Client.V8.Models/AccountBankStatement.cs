namespace OdooRpc.CoreCLR.Client.V8.Models;

public partial class AccountBankStatement
{
    public virtual string name { get; set; }
    public virtual string reference { get; set; }
    public virtual string date { get; set; }
    public virtual string first_line_index { get; set; }
    public virtual string balance_start { get; set; }
    public virtual string balance_end { get; set; }
    public virtual string balance_end_real { get; set; }
    public virtual object company_id { get; set; }
    public virtual object currency_id { get; set; }
    public virtual object journal_id { get; set; }
    public virtual long[] line_ids { get; set; }
    public virtual bool is_complete { get; set; }
    public virtual bool is_valid { get; set; }
    public virtual string problem_description { get; set; }
    public virtual long[] attachment_ids { get; set; }
    public virtual long id { get; set; }
    public virtual string display_name { get; set; }
    public virtual object create_uid { get; set; }
    public virtual string create_date { get; set; }
    public virtual object write_uid { get; set; }
    public virtual string write_date { get; set; }
}