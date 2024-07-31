namespace OdooRpc.CoreCLR.Client.V8.Models;

public partial class PosPayment
{
    public virtual string name { get; set; }
    public virtual object pos_order_id { get; set; }
    public virtual string amount { get; set; }
    public virtual object payment_method_id { get; set; }
    public virtual string payment_date { get; set; }
    public virtual object currency_id { get; set; }
    public virtual double currency_rate { get; set; }
    public virtual object partner_id { get; set; }
    public virtual object session_id { get; set; }
    public virtual object company_id { get; set; }
    public virtual string card_type { get; set; }
    public virtual string cardholder_name { get; set; }
    public virtual string transaction_id { get; set; }
    public virtual string payment_status { get; set; }
    public virtual string ticket { get; set; }
    public virtual bool is_change { get; set; }
    public virtual object account_move_id { get; set; }
    public virtual long id { get; set; }
    public virtual string display_name { get; set; }
    public virtual object create_uid { get; set; }
    public virtual string create_date { get; set; }
    public virtual object write_uid { get; set; }
    public virtual string write_date { get; set; }
    public virtual object online_account_payment_id { get; set; }
}