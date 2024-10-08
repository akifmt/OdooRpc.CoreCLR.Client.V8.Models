﻿namespace OdooRpc.CoreCLR.Client.V8.Models;

public partial class PosOrder
{
    public virtual string access_token { get; set; }
    public virtual string access_url { get; set; }
    public virtual string access_warning { get; set; }
    public virtual string name { get; set; }
    public virtual string last_order_preparation_change { get; set; }
    public virtual string date_order { get; set; }
    public virtual object user_id { get; set; }
    public virtual double amount_tax { get; set; }
    public virtual double amount_total { get; set; }
    public virtual double amount_paid { get; set; }
    public virtual double amount_return { get; set; }
    public virtual string margin { get; set; }
    public virtual double margin_percent { get; set; }
    public virtual bool is_total_cost_computed { get; set; }
    public virtual long[] lines { get; set; }
    public virtual object company_id { get; set; }
    public virtual string country_code { get; set; }
    public virtual object pricelist_id { get; set; }
    public virtual object partner_id { get; set; }
    public virtual long sequence_number { get; set; }
    public virtual object session_id { get; set; }
    public virtual object config_id { get; set; }
    public virtual object currency_id { get; set; }
    public virtual double currency_rate { get; set; }
    public virtual string state { get; set; }
    public virtual object account_move { get; set; }
    public virtual long[] picking_ids { get; set; }
    public virtual long picking_count { get; set; }
    public virtual bool failed_pickings { get; set; }
    public virtual object picking_type_id { get; set; }
    public virtual object procurement_group_id { get; set; }
    public virtual string note { get; set; }
    public virtual long nb_print { get; set; }
    public virtual string pos_reference { get; set; }
    public virtual object sale_journal { get; set; }
    public virtual object fiscal_position_id { get; set; }
    public virtual long[] payment_ids { get; set; }
    public virtual object session_move_id { get; set; }
    public virtual bool to_invoice { get; set; }
    public virtual string shipping_date { get; set; }
    public virtual bool is_invoiced { get; set; }
    public virtual bool is_tipped { get; set; }
    public virtual double tip_amount { get; set; }
    public virtual long refund_orders_count { get; set; }
    public virtual object refunded_order_id { get; set; }
    public virtual bool has_refundable_lines { get; set; }
    public virtual string ticket_code { get; set; }
    public virtual string tracking_number { get; set; }
    public virtual long id { get; set; }
    public virtual string display_name { get; set; }
    public virtual object create_uid { get; set; }
    public virtual string create_date { get; set; }
    public virtual object write_uid { get; set; }
    public virtual string write_date { get; set; }
    public virtual object employee_id { get; set; }
    public virtual string cashier { get; set; }
    public virtual object online_payment_method_id { get; set; }
    public virtual double next_online_payment_amount { get; set; }
    public virtual object table_id { get; set; }
    public virtual long customer_count { get; set; }
    public virtual bool takeaway { get; set; }
    public virtual object crm_team_id { get; set; }
    public virtual long sale_order_count { get; set; }
    public virtual string table_stand_number { get; set; }
    public virtual bool use_self_order_online_payment { get; set; }
}