﻿namespace OdooRpc.CoreCLR.Client.V8.Models;

public partial class SocialStreamPost
{
    public virtual string message { get; set; }
    public virtual string author_name { get; set; }
    public virtual string author_link { get; set; }
    public virtual string post_link { get; set; }
    public virtual object stream_id { get; set; }
    public virtual string media_type { get; set; }
    public virtual string published_date { get; set; }
    public virtual string formatted_published_date { get; set; }
    public virtual object account_id { get; set; }
    public virtual object company_id { get; set; }
    public virtual bool is_author { get; set; }
    public virtual long[] stream_post_image_ids { get; set; }
    public virtual string stream_post_image_urls { get; set; }
    public virtual string link_title { get; set; }
    public virtual string link_description { get; set; }
    public virtual string link_image_url { get; set; }
    public virtual string link_url { get; set; }
    public virtual long id { get; set; }
    public virtual string display_name { get; set; }
    public virtual object create_uid { get; set; }
    public virtual string create_date { get; set; }
    public virtual object write_uid { get; set; }
    public virtual string write_date { get; set; }
    public virtual string facebook_post_id { get; set; }
    public virtual string facebook_author_id { get; set; }
    public virtual long facebook_likes_count { get; set; }
    public virtual bool facebook_user_likes { get; set; }
    public virtual long facebook_comments_count { get; set; }
    public virtual long facebook_shares_count { get; set; }
    public virtual long facebook_reach { get; set; }
    public virtual bool facebook_is_event_post { get; set; }
    public virtual string instagram_facebook_author_id { get; set; }
    public virtual string instagram_post_id { get; set; }
    public virtual long instagram_comments_count { get; set; }
    public virtual long instagram_likes_count { get; set; }
    public virtual string instagram_post_link { get; set; }
    public virtual string linkedin_post_urn { get; set; }
    public virtual string linkedin_author_urn { get; set; }
    public virtual string linkedin_author_id { get; set; }
    public virtual string linkedin_author_vanity_name { get; set; }
    public virtual string linkedin_author_image_url { get; set; }
    public virtual long linkedin_comments_count { get; set; }
    public virtual long linkedin_likes_count { get; set; }
    public virtual string twitter_tweet_id { get; set; }
    public virtual string twitter_conversation_id { get; set; }
    public virtual string twitter_author_id { get; set; }
    public virtual string twitter_screen_name { get; set; }
    public virtual string twitter_profile_image_url { get; set; }
    public virtual long twitter_likes_count { get; set; }
    public virtual bool twitter_user_likes { get; set; }
    public virtual long twitter_comments_count { get; set; }
    public virtual long twitter_retweet_count { get; set; }
    public virtual string twitter_retweeted_tweet_id_str { get; set; }
    public virtual bool twitter_can_retweet { get; set; }
    public virtual string twitter_quoted_tweet_id_str { get; set; }
    public virtual string twitter_quoted_tweet_message { get; set; }
    public virtual string twitter_quoted_tweet_author_name { get; set; }
    public virtual string twitter_quoted_tweet_author_link { get; set; }
    public virtual string twitter_quoted_tweet_profile_image_url { get; set; }
    public virtual string youtube_video_id { get; set; }
    public virtual long youtube_likes_count { get; set; }
    public virtual long youtube_dislikes_count { get; set; }
    public virtual long youtube_comments_count { get; set; }
    public virtual long youtube_views_count { get; set; }
    public virtual string youtube_thumbnail_url { get; set; }
}