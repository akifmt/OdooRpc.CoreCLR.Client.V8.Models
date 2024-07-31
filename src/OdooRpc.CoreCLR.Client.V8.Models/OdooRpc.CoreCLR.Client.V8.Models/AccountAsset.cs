﻿namespace OdooRpc.CoreCLR.Client.V8.Models;

public partial class AccountAsset
{
    public virtual string analytic_distribution { get; set; }
    public virtual long analytic_precision { get; set; }
    public virtual long[] activity_ids { get; set; }
    public virtual string activity_state { get; set; }
    public virtual object activity_user_id { get; set; }
    public virtual object activity_type_id { get; set; }
    public virtual string activity_type_icon { get; set; }
    public virtual string activity_date_deadline { get; set; }
    public virtual string my_activity_date_deadline { get; set; }
    public virtual string activity_summary { get; set; }
    public virtual string activity_exception_decoration { get; set; }
    public virtual string activity_exception_icon { get; set; }
    public virtual object activity_calendar_event_id { get; set; }
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
    public virtual long depreciation_entries_count { get; set; }
    public virtual long gross_increase_count { get; set; }
    public virtual long total_depreciation_entries_count { get; set; }
    public virtual string name { get; set; }
    public virtual object company_id { get; set; }
    public virtual object currency_id { get; set; }
    public virtual string state { get; set; }
    public virtual bool active { get; set; }
    public virtual string method { get; set; }
    public virtual long method_number { get; set; }
    public virtual string method_period { get; set; }
    public virtual double method_progress_factor { get; set; }
    public virtual string prorata_computation_type { get; set; }
    public virtual string prorata_date { get; set; }
    public virtual string paused_prorata_date { get; set; }
    public virtual object account_asset_id { get; set; }
    public virtual object account_depreciation_id { get; set; }
    public virtual object account_depreciation_expense_id { get; set; }
    public virtual object journal_id { get; set; }
    public virtual string original_value { get; set; }
    public virtual string book_value { get; set; }
    public virtual string value_residual { get; set; }
    public virtual string salvage_value { get; set; }
    public virtual string total_depreciable_value { get; set; }
    public virtual string gross_increase_value { get; set; }
    public virtual string non_deductible_tax_value { get; set; }
    public virtual string related_purchase_value { get; set; }
    public virtual long[] depreciation_move_ids { get; set; }
    public virtual long[] original_move_line_ids { get; set; }
    public virtual string acquisition_date { get; set; }
    public virtual string disposal_date { get; set; }
    public virtual object model_id { get; set; }
    public virtual string account_type { get; set; }
    public virtual bool display_account_asset_id { get; set; }
    public virtual object parent_id { get; set; }
    public virtual long[] children_ids { get; set; }
    public virtual string already_depreciated_amount_import { get; set; }
    public virtual double asset_lifetime_days { get; set; }
    public virtual double asset_paused_days { get; set; }
    public virtual long id { get; set; }
    public virtual string display_name { get; set; }
    public virtual object create_uid { get; set; }
    public virtual string create_date { get; set; }
    public virtual object write_uid { get; set; }
    public virtual string write_date { get; set; }
}