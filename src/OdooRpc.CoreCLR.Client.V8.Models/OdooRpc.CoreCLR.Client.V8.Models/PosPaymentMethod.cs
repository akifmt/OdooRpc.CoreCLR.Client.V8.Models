using System.Text.Json.Serialization;

namespace OdooRpc.CoreCLR.Client.V8.Models;

public partial class PosPaymentMethod
{
    public virtual string name { get; set; }
    public virtual long sequence { get; set; }
    public virtual object outstanding_account_id { get; set; }
    public virtual object receivable_account_id { get; set; }
    public virtual bool is_cash_count { get; set; }
    public virtual object journal_id { get; set; }
    public virtual bool split_transactions { get; set; }
    public virtual long[] open_session_ids { get; set; }
    public virtual long[] config_ids { get; set; }
    public virtual object company_id { get; set; }
    public virtual string use_payment_terminal { get; set; }
    public virtual bool hide_use_payment_terminal { get; set; }
    public virtual bool active { get; set; }

    [JsonPropertyName("type")]
    public virtual string type_ { get; set; }

    public virtual string image { get; set; }
    public virtual string payment_method_type { get; set; }
    public virtual string default_qr { get; set; }
    public virtual string qr_code_method { get; set; }
    public virtual bool hide_qr_code_method { get; set; }
    public virtual long id { get; set; }
    public virtual string display_name { get; set; }
    public virtual object create_uid { get; set; }
    public virtual string create_date { get; set; }
    public virtual object write_uid { get; set; }
    public virtual string write_date { get; set; }
    public virtual bool is_online_payment { get; set; }
    public virtual long[] online_payment_provider_ids { get; set; }
    public virtual bool has_an_online_payment_provider { get; set; }
}