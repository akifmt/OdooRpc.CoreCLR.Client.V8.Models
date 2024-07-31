namespace OdooRpc.CoreCLR.Client.V8.Models;

public partial class SaleOrderTemplate
{
    public virtual bool active { get; set; }
    public virtual object company_id { get; set; }
    public virtual string name { get; set; }
    public virtual string note { get; set; }
    public virtual long sequence { get; set; }
    public virtual object mail_template_id { get; set; }
    public virtual long number_of_days { get; set; }
    public virtual bool require_signature { get; set; }
    public virtual bool require_payment { get; set; }
    public virtual double prepayment_percent { get; set; }
    public virtual long[] sale_order_template_line_ids { get; set; }
    public virtual long[] sale_order_template_option_ids { get; set; }
    public virtual object journal_id { get; set; }
    public virtual long id { get; set; }
    public virtual string display_name { get; set; }
    public virtual object create_uid { get; set; }
    public virtual string create_date { get; set; }
    public virtual object write_uid { get; set; }
    public virtual string write_date { get; set; }
    public virtual string sale_header { get; set; }
    public virtual string sale_header_name { get; set; }
    public virtual string sale_footer { get; set; }
    public virtual string sale_footer_name { get; set; }
    public virtual bool is_subscription { get; set; }
    public virtual object plan_id { get; set; }
    public virtual bool is_unlimited { get; set; }
    public virtual long duration_value { get; set; }
    public virtual string duration_unit { get; set; }
}