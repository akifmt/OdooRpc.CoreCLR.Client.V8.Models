namespace OdooRpc.CoreCLR.Client.V8.Models;

public partial class StockScrap
{
    public virtual bool message_is_follower { get; set; }
    public virtual long[] message_follower_ids { get; set; }
    public virtual long[] message_partner_ids { get; set; }
    public virtual long[] message_ids { get; set; }
    public virtual bool has_message { get; set; }
    public virtual bool message_needaction { get; set; }
    public virtual long message_needaction_counter { get; set; }
    public virtual bool message_has_error { get; set; }
    public virtual long message_has_error_counter { get; set; }
    public virtual long message_attachment_count { get; set; }
    public virtual long[] rating_ids { get; set; }
    public virtual long[] website_message_ids { get; set; }
    public virtual bool message_has_sms_error { get; set; }
    public virtual string name { get; set; }
    public virtual object company_id { get; set; }
    public virtual string origin { get; set; }
    public virtual object product_id { get; set; }
    public virtual object product_uom_id { get; set; }
    public virtual object product_uom_category_id { get; set; }
    public virtual string tracking { get; set; }
    public virtual object lot_id { get; set; }
    public virtual object package_id { get; set; }
    public virtual object owner_id { get; set; }
    public virtual long[] move_ids { get; set; }
    public virtual object picking_id { get; set; }
    public virtual object location_id { get; set; }
    public virtual object scrap_location_id { get; set; }
    public virtual double scrap_qty { get; set; }
    public virtual string state { get; set; }
    public virtual string date_done { get; set; }
    public virtual bool should_replenish { get; set; }
    public virtual long id { get; set; }
    public virtual string display_name { get; set; }
    public virtual object create_uid { get; set; }
    public virtual string create_date { get; set; }
    public virtual object write_uid { get; set; }
    public virtual string write_date { get; set; }
}