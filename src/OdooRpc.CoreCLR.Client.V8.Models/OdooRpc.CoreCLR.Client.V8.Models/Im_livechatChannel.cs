namespace OdooRpc.CoreCLR.Client.V8.Models;

public partial class Im_livechatChannel
{
    public virtual bool website_published { get; set; }
    public virtual bool is_published { get; set; }
    public virtual bool can_publish { get; set; }
    public virtual string website_url { get; set; }
    public virtual long[] rating_ids { get; set; }
    public virtual long rating_percentage_satisfaction { get; set; }
    public virtual long rating_count { get; set; }
    public virtual double rating_avg { get; set; }
    public virtual double rating_avg_percentage { get; set; }
    public virtual string name { get; set; }
    public virtual string button_text { get; set; }
    public virtual string default_message { get; set; }
    public virtual string input_placeholder { get; set; }
    public virtual string header_background_color { get; set; }
    public virtual string title_color { get; set; }
    public virtual string button_background_color { get; set; }
    public virtual string button_text_color { get; set; }
    public virtual string web_page { get; set; }
    public virtual bool are_you_inside { get; set; }
    public virtual long[] available_operator_ids { get; set; }
    public virtual string script_external { get; set; }
    public virtual long nbr_channel { get; set; }
    public virtual string image_128 { get; set; }
    public virtual long[] user_ids { get; set; }
    public virtual long[] channel_ids { get; set; }
    public virtual long chatbot_script_count { get; set; }
    public virtual long[] rule_ids { get; set; }
    public virtual long id { get; set; }
    public virtual string display_name { get; set; }
    public virtual object create_uid { get; set; }
    public virtual string create_date { get; set; }
    public virtual object write_uid { get; set; }
    public virtual string write_date { get; set; }
    public virtual string website_description { get; set; }
}