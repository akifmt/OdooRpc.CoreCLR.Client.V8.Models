namespace OdooRpc.CoreCLR.Client.V8.Models;

public partial class LunchOrder
{
    public virtual string name { get; set; }
    public virtual long[] topping_ids_1 { get; set; }
    public virtual long[] topping_ids_2 { get; set; }
    public virtual long[] topping_ids_3 { get; set; }
    public virtual object product_id { get; set; }
    public virtual object category_id { get; set; }
    public virtual string date { get; set; }
    public virtual object supplier_id { get; set; }
    public virtual bool available_today { get; set; }
    public virtual bool order_deadline_passed { get; set; }
    public virtual object user_id { get; set; }
    public virtual object lunch_location_id { get; set; }
    public virtual string note { get; set; }
    public virtual string price { get; set; }
    public virtual bool active { get; set; }
    public virtual string state { get; set; }
    public virtual bool notified { get; set; }
    public virtual object company_id { get; set; }
    public virtual object currency_id { get; set; }
    public virtual double quantity { get; set; }
    public virtual string display_toppings { get; set; }
    public virtual string product_description { get; set; }
    public virtual string topping_label_1 { get; set; }
    public virtual string topping_label_2 { get; set; }
    public virtual string topping_label_3 { get; set; }
    public virtual string topping_quantity_1 { get; set; }
    public virtual string topping_quantity_2 { get; set; }
    public virtual string topping_quantity_3 { get; set; }
    public virtual string image_1920 { get; set; }
    public virtual string image_128 { get; set; }
    public virtual bool available_toppings_1 { get; set; }
    public virtual bool available_toppings_2 { get; set; }
    public virtual bool available_toppings_3 { get; set; }
    public virtual bool display_reorder_button { get; set; }
    public virtual long id { get; set; }
    public virtual string display_name { get; set; }
    public virtual object create_uid { get; set; }
    public virtual string create_date { get; set; }
    public virtual object write_uid { get; set; }
    public virtual string write_date { get; set; }
}