﻿namespace OdooRpc.CoreCLR.Client.V8.Models;

public partial class MailMessage
{
    public virtual string subject { get; set; }
    public virtual string date { get; set; }
    public virtual string body { get; set; }
    public virtual string description { get; set; }
    public virtual string preview { get; set; }
    public virtual long[] link_preview_ids { get; set; }
    public virtual long[] reaction_ids { get; set; }
    public virtual long[] attachment_ids { get; set; }
    public virtual object parent_id { get; set; }
    public virtual long[] child_ids { get; set; }
    public virtual string model { get; set; }
    public virtual string res_id { get; set; }
    public virtual string record_name { get; set; }
    public virtual object record_alias_domain_id { get; set; }
    public virtual object record_company_id { get; set; }
    public virtual string message_type { get; set; }
    public virtual object subtype_id { get; set; }
    public virtual object mail_activity_type_id { get; set; }
    public virtual bool is_internal { get; set; }
    public virtual string email_from { get; set; }
    public virtual object author_id { get; set; }
    public virtual string author_avatar { get; set; }
    public virtual object author_guest_id { get; set; }
    public virtual bool is_current_user_or_guest_author { get; set; }
    public virtual long[] partner_ids { get; set; }
    public virtual long[] notified_partner_ids { get; set; }
    public virtual bool needaction { get; set; }
    public virtual bool has_error { get; set; }
    public virtual long[] notification_ids { get; set; }
    public virtual long[] starred_partner_ids { get; set; }
    public virtual string pinned_at { get; set; }
    public virtual bool starred { get; set; }
    public virtual long[] tracking_value_ids { get; set; }
    public virtual bool reply_to_force_new { get; set; }
    public virtual string message_id { get; set; }
    public virtual string reply_to { get; set; }
    public virtual object mail_server_id { get; set; }
    public virtual string email_layout_xmlid { get; set; }
    public virtual bool email_add_signature { get; set; }
    public virtual long[] mail_ids { get; set; }
    public virtual long id { get; set; }
    public virtual string display_name { get; set; }
    public virtual object create_uid { get; set; }
    public virtual string create_date { get; set; }
    public virtual object write_uid { get; set; }
    public virtual string write_date { get; set; }
    public virtual long[] rating_ids { get; set; }
    public virtual double rating_value { get; set; }
    public virtual bool has_sms_error { get; set; }
    public virtual bool snailmail_error { get; set; }
    public virtual long[] letter_ids { get; set; }
    public virtual string parent_author_name { get; set; }
    public virtual string parent_body { get; set; }
}