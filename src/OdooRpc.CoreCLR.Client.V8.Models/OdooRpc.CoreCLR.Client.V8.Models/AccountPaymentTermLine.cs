namespace OdooRpc.CoreCLR.Client.V8.Models;

public partial class AccountPaymentTermLine
{
    public virtual string value { get; set; }
    public virtual double value_amount { get; set; }
    public virtual string delay_type { get; set; }
    public virtual bool display_days_next_month { get; set; }
    public virtual string days_next_month { get; set; }
    public virtual long nb_days { get; set; }
    public virtual object payment_id { get; set; }
    public virtual long id { get; set; }
    public virtual string display_name { get; set; }
    public virtual object create_uid { get; set; }
    public virtual string create_date { get; set; }
    public virtual object write_uid { get; set; }
    public virtual string write_date { get; set; }
}