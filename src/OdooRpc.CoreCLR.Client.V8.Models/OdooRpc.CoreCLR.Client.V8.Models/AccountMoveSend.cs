namespace OdooRpc.CoreCLR.Client.V8.Models;

public partial class AccountMoveSend
{
    public virtual object company_id { get; set; }
    public virtual long[] move_ids { get; set; }
    public virtual string mode { get; set; }
    public virtual bool enable_download { get; set; }
    public virtual bool checkbox_download { get; set; }
    public virtual bool enable_send_mail { get; set; }
    public virtual bool checkbox_send_mail { get; set; }
    public virtual bool display_mail_composer { get; set; }
    public virtual string send_mail_warning_message { get; set; }
    public virtual bool send_mail_readonly { get; set; }
    public virtual object mail_template_id { get; set; }
    public virtual string mail_lang { get; set; }
    public virtual long[] mail_partner_ids { get; set; }
    public virtual string mail_subject { get; set; }
    public virtual string mail_body { get; set; }
    public virtual string mail_attachments_widget { get; set; }
    public virtual bool sequence_gap_warning { get; set; }
    public virtual long id { get; set; }
    public virtual string display_name { get; set; }
    public virtual object create_uid { get; set; }
    public virtual string create_date { get; set; }
    public virtual object write_uid { get; set; }
    public virtual string write_date { get; set; }
    public virtual bool enable_ubl_cii_xml { get; set; }
    public virtual string checkbox_ubl_cii_label { get; set; }
    public virtual bool checkbox_ubl_cii_xml { get; set; }
    public virtual string ubl_partner_warning { get; set; }
    public virtual bool show_ubl_company_warning { get; set; }
    public virtual bool enable_send_by_post { get; set; }
    public virtual bool checkbox_send_by_post { get; set; }
    public virtual long send_by_post_cost { get; set; }
    public virtual string send_by_post_warning_message { get; set; }
    public virtual bool send_by_post_readonly { get; set; }
}