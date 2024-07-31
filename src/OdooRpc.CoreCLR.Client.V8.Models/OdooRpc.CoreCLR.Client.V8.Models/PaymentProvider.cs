namespace OdooRpc.CoreCLR.Client.V8.Models;

public partial class PaymentProvider
{
    public virtual string name { get; set; }
    public virtual long sequence { get; set; }
    public virtual string code { get; set; }
    public virtual string state { get; set; }
    public virtual bool is_published { get; set; }
    public virtual object company_id { get; set; }
    public virtual object main_currency_id { get; set; }
    public virtual long[] payment_method_ids { get; set; }
    public virtual bool allow_tokenization { get; set; }
    public virtual bool capture_manually { get; set; }
    public virtual bool allow_express_checkout { get; set; }
    public virtual object redirect_form_view_id { get; set; }
    public virtual object inline_form_view_id { get; set; }
    public virtual object token_inline_form_view_id { get; set; }
    public virtual object express_checkout_form_view_id { get; set; }
    public virtual long[] available_country_ids { get; set; }
    public virtual long[] available_currency_ids { get; set; }
    public virtual string maximum_amount { get; set; }
    public virtual string pre_msg { get; set; }
    public virtual string pending_msg { get; set; }
    public virtual string auth_msg { get; set; }
    public virtual string done_msg { get; set; }
    public virtual string cancel_msg { get; set; }
    public virtual bool support_tokenization { get; set; }
    public virtual string support_manual_capture { get; set; }
    public virtual bool support_express_checkout { get; set; }
    public virtual string support_refund { get; set; }
    public virtual string image_128 { get; set; }
    public virtual long color { get; set; }
    public virtual object module_id { get; set; }
    public virtual string module_state { get; set; }
    public virtual bool module_to_buy { get; set; }
    public virtual bool show_credentials_page { get; set; }
    public virtual bool show_allow_tokenization { get; set; }
    public virtual bool show_allow_express_checkout { get; set; }
    public virtual bool show_pre_msg { get; set; }
    public virtual bool show_pending_msg { get; set; }
    public virtual bool show_auth_msg { get; set; }
    public virtual bool show_done_msg { get; set; }
    public virtual bool show_cancel_msg { get; set; }
    public virtual bool require_currency { get; set; }
    public virtual long id { get; set; }
    public virtual string display_name { get; set; }
    public virtual object create_uid { get; set; }
    public virtual string create_date { get; set; }
    public virtual object write_uid { get; set; }
    public virtual string write_date { get; set; }
    public virtual object journal_id { get; set; }
    public virtual string so_reference_type { get; set; }
    public virtual object website_id { get; set; }
}