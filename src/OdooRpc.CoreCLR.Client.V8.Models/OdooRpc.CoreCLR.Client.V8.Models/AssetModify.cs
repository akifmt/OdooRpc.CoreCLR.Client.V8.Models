namespace OdooRpc.CoreCLR.Client.V8.Models;

public partial class AssetModify
{
    public virtual string name { get; set; }
    public virtual object asset_id { get; set; }
    public virtual long method_number { get; set; }
    public virtual string method_period { get; set; }
    public virtual string value_residual { get; set; }
    public virtual string salvage_value { get; set; }
    public virtual object currency_id { get; set; }
    public virtual string date { get; set; }
    public virtual bool select_invoice_line_id { get; set; }
    public virtual bool gain_value { get; set; }
    public virtual object account_asset_id { get; set; }
    public virtual object account_asset_counterpart_id { get; set; }
    public virtual object account_depreciation_id { get; set; }
    public virtual object account_depreciation_expense_id { get; set; }
    public virtual string modify_action { get; set; }
    public virtual object company_id { get; set; }
    public virtual long[] invoice_ids { get; set; }
    public virtual long[] invoice_line_ids { get; set; }
    public virtual object gain_account_id { get; set; }
    public virtual object loss_account_id { get; set; }
    public virtual string informational_text { get; set; }
    public virtual string gain_or_loss { get; set; }
    public virtual long id { get; set; }
    public virtual string display_name { get; set; }
    public virtual object create_uid { get; set; }
    public virtual string create_date { get; set; }
    public virtual object write_uid { get; set; }
    public virtual string write_date { get; set; }
}