﻿using System.Text.Json.Serialization;

namespace OdooRpc.CoreCLR.Client.V8.Models;

public partial class ResUsers
{
    public virtual object partner_id { get; set; }
    public virtual string login { get; set; }
    public virtual string password { get; set; }
    public virtual string new_password { get; set; }
    public virtual string signature { get; set; }
    public virtual bool active { get; set; }
    public virtual bool active_partner { get; set; }
    public virtual object action_id { get; set; }
    public virtual long[] groups_id { get; set; }
    public virtual long[] log_ids { get; set; }
    public virtual string login_date { get; set; }
    public virtual bool share { get; set; }
    public virtual long companies_count { get; set; }
    public virtual string tz_offset { get; set; }
    public virtual long[] res_users_settings_ids { get; set; }
    public virtual object res_users_settings_id { get; set; }
    public virtual object company_id { get; set; }
    public virtual long[] company_ids { get; set; }
    public virtual string name { get; set; }
    public virtual string email { get; set; }
    public virtual long accesses_count { get; set; }
    public virtual long rules_count { get; set; }
    public virtual long groups_count { get; set; }
    public virtual long id { get; set; }
    public virtual string display_name { get; set; }
    public virtual object create_uid { get; set; }
    public virtual string create_date { get; set; }
    public virtual object write_uid { get; set; }
    public virtual string write_date { get; set; }
    public virtual string user_group_warning { get; set; }
    public virtual long[] api_key_ids { get; set; }
    public virtual bool totp_enabled { get; set; }
    public virtual long[] totp_trusted_device_ids { get; set; }
    public virtual string im_status { get; set; }
    public virtual long[] resource_ids { get; set; }
    public virtual object resource_calendar_id { get; set; }
    public virtual string notification_type { get; set; }
    public virtual string state { get; set; }
    public virtual long karma { get; set; }
    public virtual long[] karma_tracking_ids { get; set; }
    public virtual long[] badge_ids { get; set; }
    public virtual long gold_badge { get; set; }
    public virtual long silver_badge { get; set; }
    public virtual long bronze_badge { get; set; }
    public virtual object rank_id { get; set; }
    public virtual object next_rank_id { get; set; }
    public virtual string odoobot_state { get; set; }
    public virtual bool odoobot_failed { get; set; }
    public virtual long[] crm_team_ids { get; set; }
    public virtual long[] crm_team_member_ids { get; set; }
    public virtual object sale_team_id { get; set; }
    public virtual long[] employee_ids { get; set; }
    public virtual object employee_id { get; set; }
    public virtual string job_title { get; set; }
    public virtual string work_phone { get; set; }
    public virtual string mobile_phone { get; set; }
    public virtual string work_email { get; set; }
    public virtual long[] category_ids { get; set; }
    public virtual object department_id { get; set; }
    public virtual object address_id { get; set; }
    public virtual object work_contact_id { get; set; }
    public virtual object work_location_id { get; set; }
    public virtual object employee_parent_id { get; set; }
    public virtual object coach_id { get; set; }
    public virtual string private_street { get; set; }
    public virtual string private_street2 { get; set; }
    public virtual string private_city { get; set; }
    public virtual object private_state_id { get; set; }
    public virtual string private_zip { get; set; }
    public virtual object private_country_id { get; set; }
    public virtual string private_phone { get; set; }
    public virtual string private_email { get; set; }
    public virtual string private_lang { get; set; }
    public virtual long km_home_work { get; set; }
    public virtual object employee_bank_account_id { get; set; }
    public virtual object employee_country_id { get; set; }
    public virtual string identification_id { get; set; }
    public virtual string ssnid { get; set; }
    public virtual string passport_id { get; set; }
    public virtual string gender { get; set; }
    public virtual string birthday { get; set; }
    public virtual string place_of_birth { get; set; }
    public virtual object country_of_birth { get; set; }
    public virtual string marital { get; set; }
    public virtual string spouse_complete_name { get; set; }
    public virtual string spouse_birthdate { get; set; }
    public virtual long children { get; set; }
    public virtual string emergency_contact { get; set; }
    public virtual string emergency_phone { get; set; }
    public virtual string visa_no { get; set; }
    public virtual string permit_no { get; set; }
    public virtual string visa_expire { get; set; }
    public virtual string additional_note { get; set; }
    public virtual string barcode { get; set; }
    public virtual string pin { get; set; }
    public virtual string certificate { get; set; }
    public virtual string study_field { get; set; }
    public virtual string study_school { get; set; }
    public virtual long employee_count { get; set; }
    public virtual string hr_presence_state { get; set; }
    public virtual string last_activity { get; set; }
    public virtual string last_activity_time { get; set; }
    public virtual string employee_type { get; set; }
    public virtual object employee_resource_calendar_id { get; set; }
    public virtual bool create_employee { get; set; }
    public virtual object create_employee_id { get; set; }
    public virtual bool can_edit { get; set; }
    public virtual bool is_system { get; set; }
    public virtual string oauth_uid { get; set; }
    public virtual string odoo_com_uid { get; set; }
    public virtual long[] goal_ids { get; set; }
    public virtual long[] resume_line_ids { get; set; }
    public virtual long[] employee_skill_ids { get; set; }
    public virtual string sign_signature { get; set; }
    public virtual string sign_initials { get; set; }
    public virtual string sign_signature_frame { get; set; }
    public virtual string sign_initials_frame { get; set; }
    public virtual string livechat_username { get; set; }
    public virtual long[] livechat_lang_ids { get; set; }
    public virtual bool has_access_livechat { get; set; }
    public virtual object website_id { get; set; }
    public virtual bool is_seo_optimized { get; set; }
    public virtual string website_meta_title { get; set; }
    public virtual string website_meta_description { get; set; }
    public virtual string website_meta_keywords { get; set; }
    public virtual string website_meta_og_img { get; set; }
    public virtual string seo_name { get; set; }
    public virtual bool website_published { get; set; }
    public virtual bool is_published { get; set; }
    public virtual bool can_publish { get; set; }
    public virtual string website_url { get; set; }
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
    public virtual string email_normalized { get; set; }
    public virtual bool is_blacklisted { get; set; }
    public virtual long message_bounce { get; set; }
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
    public virtual string image_1920 { get; set; }
    public virtual string image_1024 { get; set; }
    public virtual string image_512 { get; set; }
    public virtual string image_256 { get; set; }
    public virtual string image_128 { get; set; }
    public virtual string avatar_1920 { get; set; }
    public virtual string avatar_1024 { get; set; }
    public virtual string avatar_512 { get; set; }
    public virtual string avatar_256 { get; set; }
    public virtual string avatar_128 { get; set; }
    public virtual string complete_name { get; set; }
    public virtual object title { get; set; }
    public virtual object parent_id { get; set; }
    public virtual string parent_name { get; set; }
    public virtual long[] child_ids { get; set; }

    [JsonPropertyName("ref")]
    public virtual string ref_ { get; set; }

    public virtual string lang { get; set; }
    public virtual long active_lang_count { get; set; }
    public virtual string tz { get; set; }
    public virtual object user_id { get; set; }
    public virtual string vat { get; set; }
    public virtual object same_vat_partner_id { get; set; }
    public virtual object same_company_registry_partner_id { get; set; }
    public virtual string company_registry { get; set; }
    public virtual long[] bank_ids { get; set; }
    public virtual string website { get; set; }
    public virtual string comment { get; set; }
    public virtual long[] category_id { get; set; }
    public virtual bool employee { get; set; }
    public virtual string function { get; set; }

    [JsonPropertyName("type")]
    public virtual string type_ { get; set; }

    public virtual string street { get; set; }
    public virtual string street2 { get; set; }
    public virtual string zip { get; set; }
    public virtual string city { get; set; }
    public virtual object state_id { get; set; }
    public virtual object country_id { get; set; }
    public virtual string country_code { get; set; }
    public virtual double partner_latitude { get; set; }
    public virtual double partner_longitude { get; set; }
    public virtual string email_formatted { get; set; }
    public virtual string phone { get; set; }
    public virtual string mobile { get; set; }
    public virtual bool is_company { get; set; }
    public virtual bool is_public { get; set; }
    public virtual object industry_id { get; set; }
    public virtual string company_type { get; set; }
    public virtual long color { get; set; }
    public virtual long[] user_ids { get; set; }
    public virtual bool partner_share { get; set; }
    public virtual string contact_address { get; set; }
    public virtual object commercial_partner_id { get; set; }
    public virtual string commercial_company_name { get; set; }
    public virtual string company_name { get; set; }
    public virtual object self { get; set; }
    public virtual long[] channel_ids { get; set; }
    public virtual string contact_address_inline { get; set; }
    public virtual long[] starred_message_ids { get; set; }
    public virtual string contact_address_complete { get; set; }
    public virtual string signup_token { get; set; }
    public virtual string signup_type { get; set; }
    public virtual string signup_expiration { get; set; }
    public virtual bool signup_valid { get; set; }
    public virtual string signup_url { get; set; }
    public virtual long meeting_count { get; set; }
    public virtual long[] meeting_ids { get; set; }
    public virtual string calendar_last_notif_ack { get; set; }
    public virtual object property_product_pricelist { get; set; }
    public virtual object team_id { get; set; }
    public virtual string image_medium { get; set; }
    public virtual long employees_count { get; set; }
    public virtual long partner_gid { get; set; }
    public virtual string additional_info { get; set; }
    public virtual string phone_sanitized { get; set; }
    public virtual bool phone_sanitized_blacklisted { get; set; }
    public virtual bool phone_blacklisted { get; set; }
    public virtual bool mobile_blacklisted { get; set; }
    public virtual string phone_mobile_search { get; set; }
    public virtual long certifications_count { get; set; }
    public virtual long certifications_company_count { get; set; }
    public virtual string ocn_token { get; set; }
    public virtual long[] payment_token_ids { get; set; }
    public virtual long payment_token_count { get; set; }
    public virtual long signature_count { get; set; }
    public virtual string fiscal_country_codes { get; set; }
    public virtual string credit { get; set; }
    public virtual string credit_to_invoice { get; set; }
    public virtual double credit_limit { get; set; }
    public virtual bool use_partner_credit_limit { get; set; }
    public virtual bool show_credit_limit { get; set; }
    public virtual double days_sales_outstanding { get; set; }
    public virtual string debit { get; set; }
    public virtual string debit_limit { get; set; }
    public virtual string total_invoiced { get; set; }
    public virtual object currency_id { get; set; }
    public virtual long journal_item_count { get; set; }
    public virtual object property_account_payable_id { get; set; }
    public virtual object property_account_receivable_id { get; set; }
    public virtual object property_account_position_id { get; set; }
    public virtual object property_payment_term_id { get; set; }
    public virtual object property_supplier_payment_term_id { get; set; }
    public virtual long[] ref_company_ids { get; set; }
    public virtual bool has_unreconciled_entries { get; set; }
    public virtual string last_time_entries_checked { get; set; }
    public virtual long[] invoice_ids { get; set; }
    public virtual long[] contract_ids { get; set; }
    public virtual long bank_account_count { get; set; }
    public virtual string trust { get; set; }
    public virtual bool ignore_abnormal_invoice_date { get; set; }
    public virtual bool ignore_abnormal_invoice_amount { get; set; }
    public virtual string invoice_warn { get; set; }
    public virtual string invoice_warn_msg { get; set; }
    public virtual long supplier_rank { get; set; }
    public virtual long customer_rank { get; set; }
    public virtual long duplicated_bank_account_partners_count { get; set; }
    public virtual string user_livechat_username { get; set; }
    public virtual long[] project_ids { get; set; }
    public virtual long[] task_ids { get; set; }
    public virtual long task_count { get; set; }
    public virtual long[] visitor_ids { get; set; }
    public virtual string ubl_cii_format { get; set; }
    public virtual string peppol_endpoint { get; set; }
    public virtual string peppol_eas { get; set; }
    public virtual string website_description { get; set; }
    public virtual string website_short_description { get; set; }
    public virtual long sale_order_count { get; set; }
    public virtual long[] sale_order_ids { get; set; }
    public virtual string sale_warn { get; set; }
    public virtual string sale_warn_msg { get; set; }
    public virtual object property_delivery_carrier_id { get; set; }
    public virtual long[] slide_channel_ids { get; set; }
    public virtual long[] slide_channel_completed_ids { get; set; }
    public virtual long slide_channel_count { get; set; }
    public virtual long slide_channel_company_count { get; set; }
    public virtual object last_website_so_id { get; set; }
    public virtual string sel_groups_2_4 { get; set; }
    public virtual string sel_groups_49_50 { get; set; }
    public virtual string sel_groups_56_57 { get; set; }
    public virtual string sel_groups_54_55 { get; set; }
    public virtual string sel_groups_32_33_34 { get; set; }
    public virtual string sel_groups_58_59 { get; set; }
    public virtual string sel_groups_23_25 { get; set; }
    public virtual string sel_groups_45_46 { get; set; }
    public virtual string sel_groups_1_10_11 { get; set; }
    public virtual string sel_groups_47_48 { get; set; }
    public virtual string sel_groups_66_67 { get; set; }
    public virtual string sel_groups_35_36 { get; set; }
    public virtual string sel_groups_52_53 { get; set; }
    public virtual string sel_groups_31 { get; set; }
    public virtual string sel_groups_30 { get; set; }
    public virtual bool in_group_26 { get; set; }
    public virtual bool in_group_41 { get; set; }
    public virtual bool in_group_8 { get; set; }
    public virtual bool in_group_18 { get; set; }
    public virtual bool in_group_27 { get; set; }
    public virtual bool in_group_16 { get; set; }
    public virtual bool in_group_17 { get; set; }
    public virtual bool in_group_13 { get; set; }
    public virtual bool in_group_44 { get; set; }
    public virtual bool in_group_21 { get; set; }
    public virtual bool in_group_40 { get; set; }
    public virtual bool in_group_39 { get; set; }
    public virtual bool in_group_14 { get; set; }
    public virtual bool in_group_12 { get; set; }
    public virtual bool in_group_19 { get; set; }
    public virtual bool in_group_20 { get; set; }
    public virtual bool in_group_51 { get; set; }
    public virtual bool in_group_38 { get; set; }
    public virtual bool in_group_65 { get; set; }
    public virtual bool in_group_42 { get; set; }
    public virtual bool in_group_37 { get; set; }
    public virtual bool in_group_29 { get; set; }
    public virtual bool in_group_15 { get; set; }
    public virtual bool in_group_28 { get; set; }
    public virtual bool in_group_43 { get; set; }
    public virtual bool in_group_64 { get; set; }
    public virtual bool in_group_60 { get; set; }
    public virtual bool in_group_62 { get; set; }
    public virtual bool in_group_61 { get; set; }
    public virtual bool in_group_63 { get; set; }
    public virtual bool in_group_9 { get; set; }
    public virtual bool in_group_5 { get; set; }
    public virtual bool in_group_6 { get; set; }
    public virtual bool in_group_7 { get; set; }
    public virtual bool in_group_3 { get; set; }
}