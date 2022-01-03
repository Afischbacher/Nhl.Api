using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace Nhl.Api.Models.Game
{
    /// <summary>
    /// Includes all of the NHL live game feed content, including highlights, plays and more
    /// </summary>
    public class LiveGameFeedContent
    {

        [JsonProperty("link")]
        public string Link { get; set; }

        [JsonProperty("editorial")]
        public Editorial Editorial { get; set; }

        [JsonProperty("media")]
        public Media Media { get; set; }

        [JsonProperty("highlights")]
        public Highlights Highlights { get; set; }
    }

    public class Highlights
    {
        [JsonProperty("scoreboard")]
        public Scoreboard Scoreboard { get; set; }

        [JsonProperty("gameCenter")]
        public GameCenter GameCenter { get; set; }
    }

    public class GameCenter
    {
        [JsonProperty("title")]
        public string Title { get; set; }

        [JsonProperty("topicList")]
        public string TopicList { get; set; }

        [JsonProperty("items")]
        public List<HighlightItem> Items { get; set; }
    }

    public class Highlight
    {
        [JsonProperty("type")]
        public string Type { get; set; }

        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("date")]
        public DateTime? Date { get; set; }

        [JsonProperty("title")]
        public string Title { get; set; }

        [JsonProperty("blurb")]
        public string Blurb { get; set; }

        [JsonProperty("description")]
        public string Description { get; set; }

        [JsonProperty("duration")]
        public string Duration { get; set; }

        [JsonProperty("authFlow")]
        public bool? AuthFlow { get; set; }

        [JsonProperty("mediaPlaybackId")]
        public string MediaPlaybackId { get; set; }

        [JsonProperty("mediaState")]
        public string MediaState { get; set; }

        [JsonProperty("keywords")]
        public List<Keyword> Keywords { get; set; }

        [JsonProperty("image")]
        public Image Image { get; set; }

        [JsonProperty("playbacks")]
        public List<Playback> Playbacks { get; set; }
    }

    public class Milestones
    {
        [JsonProperty("title")]
        public string Title { get; set; }

        [JsonProperty("streamStart")]
        public DateTime StreamStart { get; set; }

        [JsonProperty("items")]
        public List<MilestoneItem> Items { get; set; }
    }

    public class Scoreboard
    {
        [JsonProperty("title")]
        public string Title { get; set; }

        [JsonProperty("topicList")]
        public string TopicList { get; set; }

        [JsonProperty("items")]
        public List<HighlightItem> Items { get; set; }
    }

    public class Contributor3
    {
        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("twitter")]
        public string Twitter { get; set; }
    }

    public class Keyword
    {
        [JsonProperty("type")]
        public string Type { get; set; }

        [JsonProperty("value")]
        public string Value { get; set; }

        [JsonProperty("displayName")]
        public string DisplayName { get; set; }
    }

    public class _1212x662
    {
        [JsonProperty("aspectRatio")]
        public string AspectRatio { get; set; }

        [JsonProperty("width")]
        public int Width { get; set; }

        [JsonProperty("height")]
        public int Height { get; set; }

        [JsonProperty("src")]
        public string Src { get; set; }

        [JsonProperty("at2x")]
        public string At2x { get; set; }

        [JsonProperty("at3x")]
        public string At3x { get; set; }
    }

    public class Playback
    {
        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("width")]
        public string Width { get; set; }

        [JsonProperty("height")]
        public string Height { get; set; }

        [JsonProperty("url")]
        public string Url { get; set; }
    }

    public class Recap
    {
        [JsonProperty("title")]
        public string Title { get; set; }

        [JsonProperty("topicList")]
        public string TopicList { get; set; }

        [JsonProperty("items")]
        public List<EditorialItem> Items { get; set; }
    }

    public class Editorial
    {
        [JsonProperty("preview")]
        public Preview Preview { get; set; }

        [JsonProperty("articles")]
        public Articles Articles { get; set; }

        [JsonProperty("recap")]
        public Recap Recap { get; set; }
    }

    public class Epg
    {
        [JsonProperty("title")]
        public string Title { get; set; }

        [JsonProperty("platform")]
        public string Platform { get; set; }

        [JsonProperty("items")]
        public List<EpgItem> Items { get; set; }

        [JsonProperty("topicList")]
        public string TopicList { get; set; }
    }

    public class _1202x670
    {
        [JsonProperty("aspectRatio")]
        public string AspectRatio { get; set; }

        [JsonProperty("width")]
        public int Width { get; set; }

        [JsonProperty("height")]
        public int Height { get; set; }

        [JsonProperty("src")]
        public string Src { get; set; }

        [JsonProperty("at2x")]
        public string At2x { get; set; }

        [JsonProperty("at3x")]
        public string At3x { get; set; }
    }

    public class _1220x668
    {
        [JsonProperty("aspectRatio")]
        public string AspectRatio { get; set; }

        [JsonProperty("width")]
        public int Width { get; set; }

        [JsonProperty("height")]
        public int Height { get; set; }

        [JsonProperty("src")]
        public string Src { get; set; }

        [JsonProperty("at2x")]
        public string At2x { get; set; }

        [JsonProperty("at3x")]
        public string At3x { get; set; }
    }

    public class MediaURLS
    {
        [JsonProperty("FLASH_192K_320X180")]
        public string FLASH192K320X180 { get; set; }

        [JsonProperty("FLASH_450K_384x216")]
        public string FLASH450K384x216 { get; set; }

        [JsonProperty("FLASH_1200K_640X360")]
        public string FLASH1200K640X360 { get; set; }

        [JsonProperty("FLASH_1800K_896x504")]
        public string FLASH1800K896x504 { get; set; }

        [JsonProperty("HTTP_CLOUD_MOBILE")]
        public string HTTPCLOUDMOBILE { get; set; }

        [JsonProperty("HTTP_CLOUD_TABLET")]
        public string HTTPCLOUDTABLET { get; set; }

        [JsonProperty("HTTP_CLOUD_TABLET_60")]
        public string HTTPCLOUDTABLET60 { get; set; }

        [JsonProperty("HTTP_CLOUD_WIRED")]
        public string HTTPCLOUDWIRED { get; set; }

        [JsonProperty("HTTP_CLOUD_WIRED_60")]
        public string HTTPCLOUDWIRED60 { get; set; }

        [JsonProperty("HTTP_CLOUD_WIRED_WEB")]
        public string HTTPCLOUDWIREDWEB { get; set; }
    }

    public class Preview
    {
        [JsonProperty("title")]
        public string Title { get; set; }

        [JsonProperty("topicList")]
        public string TopicList { get; set; }

        [JsonProperty("items")]
        public List<EditorialItem> Items { get; set; }
    }

    public class Articles
    {
        [JsonProperty("title")]
        public string Title { get; set; }

        [JsonProperty("topicList")]
        public string TopicList { get; set; }

        [JsonProperty("items")]
        public List<object> Items { get; set; }
    }

    public class Item
    {
        [JsonProperty("type")]
        public string Type { get; set; }

        [JsonProperty("state")]
        public string State { get; set; }

        [JsonProperty("date")]
        public DateTime Date { get; set; }

        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("headline")]
        public string Headline { get; set; }

        [JsonProperty("subhead")]
        public string Subhead { get; set; }

        [JsonProperty("seoTitle")]
        public string SeoTitle { get; set; }

        [JsonProperty("seoDescription")]
        public string SeoDescription { get; set; }

        [JsonProperty("seoKeywords")]
        public string SeoKeywords { get; set; }

        [JsonProperty("slug")]
        public string Slug { get; set; }

        [JsonProperty("commenting")]
        public bool Commenting { get; set; }

        [JsonProperty("tagline")]
        public string Tagline { get; set; }

        [JsonProperty("tokenData")]
        public Dictionary<string, EditorialPreviewTokenData> TokenData { get; set; }

        [JsonProperty("contributor")]
        public Contributor Contributor { get; set; }

        [JsonProperty("keywordsDisplay")]
        public List<KeywordsDisplay> KeywordsDisplay { get; set; }

        [JsonProperty("keywordsAll")]
        public List<KeywordsAll> KeywordsAll { get; set; }

        [JsonProperty("approval")]
        public string Approval { get; set; }

        [JsonProperty("url")]
        public string Url { get; set; }

        [JsonProperty("dataURI")]
        public string DataURI { get; set; }

        [JsonProperty("primaryKeyword")]
        public PrimaryKeyword PrimaryKeyword { get; set; }

        [JsonProperty("shareImage")]
        public string ShareImage { get; set; }

        [JsonProperty("media")]
        public Media Media { get; set; }

        [JsonProperty("preview")]
        public string Preview { get; set; }

        [JsonProperty("guid")]
        public string Guid { get; set; }

        [JsonProperty("mediaState")]
        public string MediaState { get; set; }

        [JsonProperty("mediaPlaybackId")]
        public string MediaPlaybackId { get; set; }

        [JsonProperty("mediaFeedType")]
        public string MediaFeedType { get; set; }

        [JsonProperty("callLetters")]
        public string CallLetters { get; set; }

        [JsonProperty("eventId")]
        public string EventId { get; set; }

        [JsonProperty("language")]
        public string Language { get; set; }

        [JsonProperty("freeGame")]
        public bool FreeGame { get; set; }

        [JsonProperty("feedName")]
        public string FeedName { get; set; }

        [JsonProperty("gamePlus")]
        public bool GamePlus { get; set; }

        [JsonProperty("title")]
        public string Title { get; set; }

        [JsonProperty("blurb")]
        public string Blurb { get; set; }

        [JsonProperty("description")]
        public string Description { get; set; }

        [JsonProperty("duration")]
        public string Duration { get; set; }

        [JsonProperty("authFlow")]
        public bool? AuthFlow { get; set; }

        [JsonProperty("keywords")]
        public List<Keyword> Keywords { get; set; }

        [JsonProperty("image")]
        public Image Image { get; set; }

        [JsonProperty("playbacks")]
        public List<Playback> Playbacks { get; set; }

        [JsonProperty("timeAbsolute")]
        public DateTime TimeAbsolute { get; set; }

        [JsonProperty("timeOffset")]
        public string TimeOffset { get; set; }

        [JsonProperty("period")]
        public string Period { get; set; }

        [JsonProperty("statsEventId")]
        public string StatsEventId { get; set; }

        [JsonProperty("teamId")]
        public string TeamId { get; set; }

        [JsonProperty("playerId")]
        public string PlayerId { get; set; }

        [JsonProperty("periodTime")]
        public string PeriodTime { get; set; }

        [JsonProperty("ordinalNum")]
        public string OrdinalNum { get; set; }

        [JsonProperty("highlight")]
        public Highlight Highlight { get; set; }
    }

    public class Image
    {
        [JsonProperty("title")]
        public string Title { get; set; }

        [JsonProperty("altText")]
        public string AltText { get; set; }

        [JsonProperty("cuts")]
        public Cuts Cuts { get; set; }
    }

    public class Media
    {
        [JsonProperty("epg")]
        public List<Epg> Epg { get; set; }

        [JsonProperty("milestones")]
        public Milestones Milestones { get; set; }
    }

    public class Cuts
    {
        [JsonProperty("2568x1444")]
        public _2568x1444 _2568x1444 { get; set; }

        [JsonProperty("2208x1242")]
        public _2208x1242 _2208x1242 { get; set; }

        [JsonProperty("2048x1152")]
        public _2048x1152 _2048x1152 { get; set; }

        [JsonProperty("1704x960")]
        public _1704x960 _1704x960 { get; set; }

        [JsonProperty("1536x864")]
        public _1536x864 _1536x864 { get; set; }

        [JsonProperty("1284x722")]
        public _1284x722 _1284x722 { get; set; }

        [JsonProperty("1136x640")]
        public _1136x640 _1136x640 { get; set; }

        [JsonProperty("1024x576")]
        public _1024x576 _1024x576 { get; set; }

        [JsonProperty("960x540")]
        public _960x540 _960x540 { get; set; }

        [JsonProperty("768x432")]
        public _768x432 _768x432 { get; set; }

        [JsonProperty("640x360")]
        public _640x360 _640x360 { get; set; }

        [JsonProperty("568x320")]
        public _568x320 _568x320 { get; set; }

        [JsonProperty("372x210")]
        public _372x210 _372x210 { get; set; }

        [JsonProperty("320x180")]
        public _320x180 _320x180 { get; set; }

        [JsonProperty("248x140")]
        public _248x140 _248x140 { get; set; }

        [JsonProperty("124x70")]
        public _124x70 _124x70 { get; set; }

        [JsonProperty("1200x630")]
        public _1200x630 _1200x630 { get; set; }

        [JsonProperty("1920x1080")]
        public _1920x1080 _1920x1080 { get; set; }

        [JsonProperty("1220x668")]
        public _1220x668 _1220x668 { get; set; }

        [JsonProperty("1212x662")]
        public _1212x662 _1212x662 { get; set; }

        [JsonProperty("1202x670")]
        public _1202x670 _1202x670 { get; set; }
    }

    public class _124x70
    {
        [JsonProperty("aspectRatio")]
        public string AspectRatio { get; set; }

        [JsonProperty("width")]
        public int Width { get; set; }

        [JsonProperty("height")]
        public int Height { get; set; }

        [JsonProperty("src")]
        public string Src { get; set; }

        [JsonProperty("at2x")]
        public string At2x { get; set; }

        [JsonProperty("at3x")]
        public string At3x { get; set; }
    }

    public class _1920x1080
    {
        [JsonProperty("aspectRatio")]
        public string AspectRatio { get; set; }

        [JsonProperty("width")]
        public int Width { get; set; }

        [JsonProperty("height")]
        public int Height { get; set; }

        [JsonProperty("src")]
        public string Src { get; set; }

        [JsonProperty("at2x")]
        public string At2x { get; set; }

        [JsonProperty("at3x")]
        public string At3x { get; set; }
    }

    public class _1200x630
    {
        [JsonProperty("aspectRatio")]
        public string AspectRatio { get; set; }

        [JsonProperty("width")]
        public int Width { get; set; }

        [JsonProperty("height")]
        public int Height { get; set; }

        [JsonProperty("src")]
        public string Src { get; set; }

        [JsonProperty("at2x")]
        public string At2x { get; set; }

        [JsonProperty("at3x")]
        public string At3x { get; set; }
    }


    public class _2568x1444
    {
        [JsonProperty("aspectRatio")]
        public string AspectRatio { get; set; }

        [JsonProperty("width")]
        public int Width { get; set; }

        [JsonProperty("height")]
        public int Height { get; set; }

        [JsonProperty("src")]
        public string Src { get; set; }

        [JsonProperty("at2x")]
        public string At2x { get; set; }

        [JsonProperty("at3x")]
        public string At3x { get; set; }
    }

    public class _2208x1242
    {
        [JsonProperty("aspectRatio")]
        public string AspectRatio { get; set; }

        [JsonProperty("width")]
        public int Width { get; set; }

        [JsonProperty("height")]
        public int Height { get; set; }

        [JsonProperty("src")]
        public string Src { get; set; }

        [JsonProperty("at2x")]
        public string At2x { get; set; }

        [JsonProperty("at3x")]
        public string At3x { get; set; }
    }

    public class _2048x1152
    {
        [JsonProperty("aspectRatio")]
        public string AspectRatio { get; set; }

        [JsonProperty("width")]
        public int Width { get; set; }

        [JsonProperty("height")]
        public int Height { get; set; }

        [JsonProperty("src")]
        public string Src { get; set; }

        [JsonProperty("at2x")]
        public string At2x { get; set; }

        [JsonProperty("at3x")]
        public string At3x { get; set; }
    }

    public class _1704x960
    {
        [JsonProperty("aspectRatio")]
        public string AspectRatio { get; set; }

        [JsonProperty("width")]
        public int Width { get; set; }

        [JsonProperty("height")]
        public int Height { get; set; }

        [JsonProperty("src")]
        public string Src { get; set; }

        [JsonProperty("at2x")]
        public string At2x { get; set; }

        [JsonProperty("at3x")]
        public string At3x { get; set; }
    }

    public class _1536x864
    {
        [JsonProperty("aspectRatio")]
        public string AspectRatio { get; set; }

        [JsonProperty("width")]
        public int Width { get; set; }

        [JsonProperty("height")]
        public int Height { get; set; }

        [JsonProperty("src")]
        public string Src { get; set; }

        [JsonProperty("at2x")]
        public string At2x { get; set; }

        [JsonProperty("at3x")]
        public string At3x { get; set; }
    }

    public class _1284x722
    {
        [JsonProperty("aspectRatio")]
        public string AspectRatio { get; set; }

        [JsonProperty("width")]
        public int Width { get; set; }

        [JsonProperty("height")]
        public int Height { get; set; }

        [JsonProperty("src")]
        public string Src { get; set; }

        [JsonProperty("at2x")]
        public string At2x { get; set; }

        [JsonProperty("at3x")]
        public string At3x { get; set; }
    }

    public class _1136x640
    {
        [JsonProperty("aspectRatio")]
        public string AspectRatio { get; set; }

        [JsonProperty("width")]
        public int Width { get; set; }

        [JsonProperty("height")]
        public int Height { get; set; }

        [JsonProperty("src")]
        public string Src { get; set; }

        [JsonProperty("at2x")]
        public string At2x { get; set; }

        [JsonProperty("at3x")]
        public string At3x { get; set; }
    }

    public class _1024x576
    {
        [JsonProperty("aspectRatio")]
        public string AspectRatio { get; set; }

        [JsonProperty("width")]
        public int Width { get; set; }

        [JsonProperty("height")]
        public int Height { get; set; }

        [JsonProperty("src")]
        public string Src { get; set; }

        [JsonProperty("at2x")]
        public string At2x { get; set; }

        [JsonProperty("at3x")]
        public string At3x { get; set; }
    }

    public class _960x540
    {
        [JsonProperty("aspectRatio")]
        public string AspectRatio { get; set; }

        [JsonProperty("width")]
        public int Width { get; set; }

        [JsonProperty("height")]
        public int Height { get; set; }

        [JsonProperty("src")]
        public string Src { get; set; }

        [JsonProperty("at2x")]
        public string At2x { get; set; }

        [JsonProperty("at3x")]
        public string At3x { get; set; }
    }

    public class _768x432
    {
        [JsonProperty("aspectRatio")]
        public string AspectRatio { get; set; }

        [JsonProperty("width")]
        public int Width { get; set; }

        [JsonProperty("height")]
        public int Height { get; set; }

        [JsonProperty("src")]
        public string Src { get; set; }

        [JsonProperty("at2x")]
        public string At2x { get; set; }

        [JsonProperty("at3x")]
        public string At3x { get; set; }
    }

    public class _640x360
    {
        [JsonProperty("aspectRatio")]
        public string AspectRatio { get; set; }

        [JsonProperty("width")]
        public int Width { get; set; }

        [JsonProperty("height")]
        public int Height { get; set; }

        [JsonProperty("src")]
        public string Src { get; set; }

        [JsonProperty("at2x")]
        public string At2x { get; set; }

        [JsonProperty("at3x")]
        public string At3x { get; set; }
    }

    public class _568x320
    {
        [JsonProperty("aspectRatio")]
        public string AspectRatio { get; set; }

        [JsonProperty("width")]
        public int Width { get; set; }

        [JsonProperty("height")]
        public int Height { get; set; }

        [JsonProperty("src")]
        public string Src { get; set; }

        [JsonProperty("at2x")]
        public string At2x { get; set; }

        [JsonProperty("at3x")]
        public string At3x { get; set; }
    }

    public class _372x210
    {
        [JsonProperty("aspectRatio")]
        public string AspectRatio { get; set; }

        [JsonProperty("width")]
        public int Width { get; set; }

        [JsonProperty("height")]
        public int Height { get; set; }

        [JsonProperty("src")]
        public string Src { get; set; }

        [JsonProperty("at2x")]
        public string At2x { get; set; }

        [JsonProperty("at3x")]
        public string At3x { get; set; }
    }

    public class _320x180
    {
        [JsonProperty("aspectRatio")]
        public string AspectRatio { get; set; }

        [JsonProperty("width")]
        public int Width { get; set; }

        [JsonProperty("height")]
        public int Height { get; set; }

        [JsonProperty("src")]
        public string Src { get; set; }

        [JsonProperty("at2x")]
        public string At2x { get; set; }

        [JsonProperty("at3x")]
        public string At3x { get; set; }
    }

    public class _248x140
    {
        [JsonProperty("aspectRatio")]
        public string AspectRatio { get; set; }

        [JsonProperty("width")]
        public int Width { get; set; }

        [JsonProperty("height")]
        public int Height { get; set; }

        [JsonProperty("src")]
        public string Src { get; set; }

        [JsonProperty("at2x")]
        public string At2x { get; set; }

        [JsonProperty("at3x")]
        public string At3x { get; set; }
    }

    public class EditorialPreviewTokenData
    {
        [JsonProperty("tokenGUID")]
        public string TokenGUID { get; set; }

        [JsonProperty("type")]
        public string Type { get; set; }

        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("teamId")]
        public string TeamId { get; set; }

        [JsonProperty("position")]
        public string Position { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("seoName")]
        public string SeoName { get; set; }

        [JsonProperty("href")]
        public string Href { get; set; }

        [JsonProperty("hrefMobile")]
        public string HrefMobile { get; set; }
    }

    public class Contributor
    {
        [JsonProperty("contributors")]
        public List<object> Contributors { get; set; }

        [JsonProperty("source")]
        public string Source { get; set; }
    }

    public class KeywordsDisplay
    {
        [JsonProperty("type")]
        public string Type { get; set; }

        [JsonProperty("value")]
        public string Value { get; set; }

        [JsonProperty("displayName")]
        public string DisplayName { get; set; }
    }

    public class KeywordsAll
    {
        [JsonProperty("type")]
        public string Type { get; set; }

        [JsonProperty("value")]
        public string Value { get; set; }

        [JsonProperty("displayName")]
        public string DisplayName { get; set; }
    }

    public class PrimaryKeyword
    {
        [JsonProperty("type")]
        public string Type { get; set; }

        [JsonProperty("value")]
        public string Value { get; set; }

        [JsonProperty("displayName")]
        public string DisplayName { get; set; }
    }

    public class EditorialItem
    {
        [JsonProperty("type")]
        public string Type { get; set; }

        [JsonProperty("state")]
        public string State { get; set; }

        [JsonProperty("date")]
        public DateTime Date { get; set; }

        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("headline")]
        public string Headline { get; set; }

        [JsonProperty("subhead")]
        public string Subhead { get; set; }

        [JsonProperty("seoTitle")]
        public string SeoTitle { get; set; }

        [JsonProperty("seoDescription")]
        public string SeoDescription { get; set; }

        [JsonProperty("seoKeywords")]
        public string SeoKeywords { get; set; }

        [JsonProperty("slug")]
        public string Slug { get; set; }

        [JsonProperty("commenting")]
        public bool Commenting { get; set; }

        [JsonProperty("tagline")]
        public string Tagline { get; set; }

        [JsonProperty("contributor")]
        public Contributor Contributor { get; set; }

        public Dictionary<string, EditorialPreviewTokenData> TokenData { get; set; }

        [JsonProperty("keywordsDisplay")]
        public List<KeywordsDisplay> KeywordsDisplay { get; set; }

        [JsonProperty("keywordsAll")]
        public List<KeywordsAll> KeywordsAll { get; set; }

        [JsonProperty("approval")]
        public string Approval { get; set; }

        [JsonProperty("url")]
        public string Url { get; set; }

        [JsonProperty("dataURI")]
        public string DataURI { get; set; }

        [JsonProperty("primaryKeyword")]
        public PrimaryKeyword PrimaryKeyword { get; set; }

        [JsonProperty("shareImage")]
        public string ShareImage { get; set; }

        [JsonProperty("media")]
        public Media Media { get; set; }

        [JsonProperty("preview")]
        public string Preview { get; set; }
    }

    public class MilestoneItem
    {
        [JsonProperty("title")]
        public string Title { get; set; }

        [JsonProperty("description")]
        public string Description { get; set; }

        [JsonProperty("type")]
        public string Type { get; set; }

        [JsonProperty("timeAbsolute")]
        public DateTime TimeAbsolute { get; set; }

        [JsonProperty("timeOffset")]
        public string TimeOffset { get; set; }

        [JsonProperty("period")]
        public string Period { get; set; }

        [JsonProperty("statsEventId")]
        public string StatsEventId { get; set; }

        [JsonProperty("teamId")]
        public string TeamId { get; set; }

        [JsonProperty("playerId")]
        public string PlayerId { get; set; }

        [JsonProperty("periodTime")]
        public string PeriodTime { get; set; }

        [JsonProperty("ordinalNum")]
        public string OrdinalNum { get; set; }

        [JsonProperty("highlight")]
        public Highlight Highlight { get; set; }
    }

    public class HighlightItem
    {
        [JsonProperty("type")]
        public string Type { get; set; }

        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("date")]
        public DateTime? Date { get; set; }

        [JsonProperty("title")]
        public string Title { get; set; }

        [JsonProperty("blurb")]
        public string Blurb { get; set; }

        [JsonProperty("description")]
        public string Description { get; set; }

        [JsonProperty("authFlow")]
        public bool? AuthFlow { get; set; }

        [JsonProperty("mediaPlaybackId")]
        public string MediaPlaybackId { get; set; }

        [JsonProperty("mediaState")]
        public string MediaState { get; set; }

        [JsonProperty("keywords")]
        public List<Keyword> Keywords { get; set; }

        [JsonProperty("image")]
        public Image Image { get; set; }

        [JsonProperty("playbacks")]
        public List<Playback> Playbacks { get; set; }
    }

    public class EpgItem
    {
        [JsonProperty("guid")]
        public string Guid { get; set; }

        [JsonProperty("mediaState")]
        public string MediaState { get; set; }

        [JsonProperty("mediaPlaybackId")]
        public string MediaPlaybackId { get; set; }

        [JsonProperty("mediaFeedType")]
        public string MediaFeedType { get; set; }

        [JsonProperty("callLetters")]
        public string CallLetters { get; set; }

        [JsonProperty("eventId")]
        public string EventId { get; set; }

        [JsonProperty("language")]
        public string Language { get; set; }

        [JsonProperty("freeGame")]
        public bool FreeGame { get; set; }

        [JsonProperty("feedName")]
        public string FeedName { get; set; }

        [JsonProperty("gamePlus")]
        public bool GamePlus { get; set; }

    }
}
