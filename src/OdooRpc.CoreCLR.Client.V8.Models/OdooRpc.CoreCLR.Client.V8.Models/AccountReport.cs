namespace OdooRpc.CoreCLR.Client.V8.Models;

public partial class AccountReport
{
    public virtual string name { get; set; }
    public virtual long sequence { get; set; }
    public virtual bool active { get; set; }
    public virtual long[] line_ids { get; set; }
    public virtual long[] column_ids { get; set; }
    public virtual object root_report_id { get; set; }
    public virtual long[] variant_report_ids { get; set; }
    public virtual long[] section_report_ids { get; set; }
    public virtual long[] section_main_report_ids { get; set; }
    public virtual bool use_sections { get; set; }
    public virtual string chart_template { get; set; }
    public virtual object country_id { get; set; }
    public virtual bool only_tax_exigible { get; set; }
    public virtual string availability_condition { get; set; }
    public virtual long load_more_limit { get; set; }
    public virtual bool search_bar { get; set; }
    public virtual long prefix_groups_threshold { get; set; }
    public virtual string integer_rounding { get; set; }
    public virtual string default_opening_date_filter { get; set; }
    public virtual string filter_multi_company { get; set; }
    public virtual bool filter_date_range { get; set; }
    public virtual bool filter_show_draft { get; set; }
    public virtual bool filter_unreconciled { get; set; }
    public virtual bool filter_unfold_all { get; set; }
    public virtual string filter_hide_0_lines { get; set; }
    public virtual bool filter_period_comparison { get; set; }
    public virtual bool filter_growth_comparison { get; set; }
    public virtual bool filter_journals { get; set; }
    public virtual bool filter_analytic { get; set; }
    public virtual string filter_hierarchy { get; set; }
    public virtual string filter_account_type { get; set; }
    public virtual bool filter_partner { get; set; }
    public virtual bool filter_fiscal_position { get; set; }
    public virtual bool filter_aml_ir_filters { get; set; }
    public virtual long id { get; set; }
    public virtual string display_name { get; set; }
    public virtual object create_uid { get; set; }
    public virtual string create_date { get; set; }
    public virtual object write_uid { get; set; }
    public virtual string write_date { get; set; }
}