namespace OdooRpc.CoreCLR.Client.V8.Models;

public partial class ExpenseSampleRegister
{
    public virtual object sheet_id { get; set; }
    public virtual string amount { get; set; }
    public virtual string memo { get; set; }
    public virtual object currency_id { get; set; }
    public virtual object company_id { get; set; }
    public virtual object journal_id { get; set; }
    public virtual object payment_method_line_id { get; set; }
    public virtual long[] available_payment_method_line_ids { get; set; }
    public virtual bool hide_payment_method_line { get; set; }
    public virtual string date { get; set; }
    public virtual bool hide_partial { get; set; }
    public virtual string partial_mode { get; set; }
    public virtual long id { get; set; }
    public virtual string display_name { get; set; }
    public virtual object create_uid { get; set; }
    public virtual string create_date { get; set; }
    public virtual object write_uid { get; set; }
    public virtual string write_date { get; set; }
}