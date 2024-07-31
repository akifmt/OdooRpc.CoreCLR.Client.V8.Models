namespace OdooRpc.CoreCLR.Client.V8.Models;

public partial class CalendarBooking
{
    public virtual long[] appointment_answer_input_ids { get; set; }
    public virtual object appointment_invite_id { get; set; }
    public virtual object appointment_type_id { get; set; }
    public virtual string description { get; set; }
    public virtual double duration { get; set; }
    public virtual long[] guest_ids { get; set; }
    public virtual string name { get; set; }
    public virtual object partner_id { get; set; }
    public virtual string start { get; set; }
    public virtual string stop { get; set; }
    public virtual long asked_capacity { get; set; }
    public virtual long[] booking_line_ids { get; set; }
    public virtual object staff_user_id { get; set; }
    public virtual object account_move_id { get; set; }
    public virtual object product_id { get; set; }
    public virtual string booking_token { get; set; }
    public virtual bool not_available { get; set; }
    public virtual object calendar_event_id { get; set; }
    public virtual long id { get; set; }
    public virtual string display_name { get; set; }
    public virtual object create_uid { get; set; }
    public virtual string create_date { get; set; }
    public virtual object write_uid { get; set; }
    public virtual string write_date { get; set; }
    public virtual object order_line_id { get; set; }
}