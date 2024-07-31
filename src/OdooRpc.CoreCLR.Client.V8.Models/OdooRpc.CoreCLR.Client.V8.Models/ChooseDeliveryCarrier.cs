namespace OdooRpc.CoreCLR.Client.V8.Models;

public partial class ChooseDeliveryCarrier
{
    public virtual object order_id { get; set; }
    public virtual object partner_id { get; set; }
    public virtual object carrier_id { get; set; }
    public virtual string delivery_type { get; set; }
    public virtual double delivery_price { get; set; }
    public virtual double display_price { get; set; }
    public virtual object currency_id { get; set; }
    public virtual object company_id { get; set; }
    public virtual long[] available_carrier_ids { get; set; }
    public virtual string invoicing_message { get; set; }
    public virtual string delivery_message { get; set; }
    public virtual double total_weight { get; set; }
    public virtual string weight_uom_name { get; set; }
    public virtual long id { get; set; }
    public virtual string display_name { get; set; }
    public virtual object create_uid { get; set; }
    public virtual string create_date { get; set; }
    public virtual object write_uid { get; set; }
    public virtual string write_date { get; set; }
}