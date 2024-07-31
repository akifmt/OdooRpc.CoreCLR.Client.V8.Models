namespace OdooRpc.CoreCLR.Client.V8.Models;

public partial class ExtractMixin
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
    public virtual object message_main_attachment_id { get; set; }
    public virtual string extract_state { get; set; }
    public virtual string extract_status { get; set; }
    public virtual string extract_error_message { get; set; }
    public virtual string extract_document_uuid { get; set; }
    public virtual bool extract_can_show_send_button { get; set; }
    public virtual bool is_in_extractable_state { get; set; }
    public virtual bool extract_state_processed { get; set; }
}