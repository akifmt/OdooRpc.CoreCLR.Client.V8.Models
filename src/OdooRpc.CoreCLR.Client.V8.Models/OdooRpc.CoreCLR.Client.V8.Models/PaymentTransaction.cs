namespace OdooRpc.CoreCLR.Client.V8.Models;

public partial class PaymentTransaction
{
    public virtual object provider_id { get; set; }
    public virtual string provider_code { get; set; }
    public virtual object company_id { get; set; }
    public virtual object payment_method_id { get; set; }
    public virtual string payment_method_code { get; set; }
    public virtual string reference { get; set; }
    public virtual string provider_reference { get; set; }
    public virtual string amount { get; set; }
    public virtual object currency_id { get; set; }
    public virtual object token_id { get; set; }
    public virtual string state { get; set; }
    public virtual string state_message { get; set; }
    public virtual string last_state_change { get; set; }
    public virtual string operation { get; set; }
    public virtual object source_transaction_id { get; set; }
    public virtual long[] child_transaction_ids { get; set; }
    public virtual long refunds_count { get; set; }
    public virtual bool is_post_processed { get; set; }
    public virtual bool tokenize { get; set; }
    public virtual string landing_route { get; set; }
    public virtual object callback_model_id { get; set; }
    public virtual long callback_res_id { get; set; }
    public virtual string callback_method { get; set; }
    public virtual string callback_hash { get; set; }
    public virtual bool callback_is_done { get; set; }
    public virtual object partner_id { get; set; }
    public virtual string partner_name { get; set; }
    public virtual string partner_lang { get; set; }
    public virtual string partner_email { get; set; }
    public virtual string partner_address { get; set; }
    public virtual string partner_zip { get; set; }
    public virtual string partner_city { get; set; }
    public virtual object partner_state_id { get; set; }
    public virtual object partner_country_id { get; set; }
    public virtual string partner_phone { get; set; }
    public virtual long id { get; set; }
    public virtual string display_name { get; set; }
    public virtual object create_uid { get; set; }
    public virtual string create_date { get; set; }
    public virtual object write_uid { get; set; }
    public virtual string write_date { get; set; }
    public virtual object payment_id { get; set; }
    public virtual long[] invoice_ids { get; set; }
    public virtual long invoices_count { get; set; }
    public virtual long[] sale_order_ids { get; set; }
    public virtual long sale_order_ids_nbr { get; set; }
    public virtual bool is_donation { get; set; }
}