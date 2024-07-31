namespace OdooRpc.CoreCLR.Client.V8.Models;

public partial class RatingRating
{
    public virtual string create_date { get; set; }
    public virtual string res_name { get; set; }
    public virtual object res_model_id { get; set; }
    public virtual string res_model { get; set; }
    public virtual string res_id { get; set; }
    public virtual string resource_ref { get; set; }
    public virtual string parent_res_name { get; set; }
    public virtual object parent_res_model_id { get; set; }
    public virtual string parent_res_model { get; set; }
    public virtual long parent_res_id { get; set; }
    public virtual string parent_ref { get; set; }
    public virtual object rated_partner_id { get; set; }
    public virtual string rated_partner_name { get; set; }
    public virtual object partner_id { get; set; }
    public virtual double rating { get; set; }
    public virtual string rating_image { get; set; }
    public virtual string rating_image_url { get; set; }
    public virtual string rating_text { get; set; }
    public virtual string feedback { get; set; }
    public virtual object message_id { get; set; }
    public virtual bool is_internal { get; set; }
    public virtual string access_token { get; set; }
    public virtual bool consumed { get; set; }
    public virtual long id { get; set; }
    public virtual string display_name { get; set; }
    public virtual object create_uid { get; set; }
    public virtual object write_uid { get; set; }
    public virtual string write_date { get; set; }
    public virtual string publisher_comment { get; set; }
    public virtual object publisher_id { get; set; }
    public virtual string publisher_datetime { get; set; }
}