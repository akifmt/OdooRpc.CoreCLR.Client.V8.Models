namespace OdooRpc.CoreCLR.Client.V8.Models;

public partial class HrExpenseSplitWizard
{
    public virtual object expense_id { get; set; }
    public virtual long[] expense_split_line_ids { get; set; }
    public virtual string total_amount_currency { get; set; }
    public virtual string total_amount_currency_original { get; set; }
    public virtual string tax_amount_currency { get; set; }
    public virtual bool split_possible { get; set; }
    public virtual object currency_id { get; set; }
    public virtual long id { get; set; }
    public virtual string display_name { get; set; }
    public virtual object create_uid { get; set; }
    public virtual string create_date { get; set; }
    public virtual object write_uid { get; set; }
    public virtual string write_date { get; set; }
}