namespace OdooRpc.CoreCLR.Client.V8.Models;

public partial class RatingMixin
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
    public virtual double rating_last_value { get; set; }
    public virtual string rating_last_feedback { get; set; }
    public virtual string rating_last_image { get; set; }
    public virtual long rating_count { get; set; }
    public virtual double rating_avg { get; set; }
    public virtual string rating_avg_text { get; set; }
    public virtual double rating_percentage_satisfaction { get; set; }
    public virtual string rating_last_text { get; set; }
}