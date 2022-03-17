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
        /// <summary>
        /// A link to the NHL live game feed content <br/>
        /// Example: /api/v1/game/2021020566/content
        /// </summary>
        [JsonProperty("link")]
        public string Link { get; set; }

        /// <summary>
        /// An editorial of the preview, recap and articles for the NHL game
        /// </summary>
        [JsonProperty("editorial")]
        public Editorial Editorial { get; set; }

        /// <summary>
        /// All of the NHL game related media, including video's, images and more
        /// </summary>
        [JsonProperty("media")]
        public Media Media { get; set; }

        /// <summary>
        /// All of the NHL game highlights, including goals, penalties, power-plays and more
        /// </summary>
        [JsonProperty("highlights")]
        public Highlights Highlights { get; set; }
    }

    /// <summary>
    /// A summation of both the GameCenter and Scoreboard highlights for the NHL game
    /// </summary>
    public class Highlights
    {
        /// <summary>
        /// The NHL scoreboard which includes information, media and score highlights
        /// </summary>
        [JsonProperty("scoreboard")]
        public Scoreboard Scoreboard { get; set; }

        /// <summary>
        /// The NHL game center which includes information, media and game center highlights
        /// </summary>
        [JsonProperty("gameCenter")]
        public GameCenter GameCenter { get; set; }
    }

    /// <summary>
    /// Game Center
    /// </summary>
    public class GameCenter
    {
        /// <summary>
        /// Provides the title for the Game Center highlights <br/>
        /// Example: Highlights
        /// </summary>
        [JsonProperty("title")]
        public string Title { get; set; }

        /// <summary>
        /// Provides the identifier for the topic list <br/>
        /// Example: 329057500
        /// </summary>
        [JsonProperty("topicList")]
        public string TopicList { get; set; }

        /// <summary>
        /// A collection of NHL Game Center highlights
        /// </summary>
        [JsonProperty("items")]
        public List<HighlightItem> Items { get; set; }
    }

    /// <summary>
    /// Game Highlight
    /// </summary>
    public class Highlight
    {
        /// <summary>
        /// The type of NHL live game feed content highlight <br/>
        /// Example: video
        /// </summary>
        [JsonProperty("type")]
        public string Type { get; set; }

        /// <summary>
        /// The highlight identifier <br/>
        /// Example: 10066385
        /// </summary>
        [JsonProperty("id")]
        public string Id { get; set; }

        /// <summary>
        /// The date and time of the highlight <br/>
        /// Example: 2022-01-01T14:00:00-0500
        /// </summary>
        [JsonProperty("date")]
        public DateTime? Date { get; set; }

        /// <summary>
        /// The title of the highlight <br/>
        /// Example: Nurse puts away loose puck
        /// </summary>
        [JsonProperty("title")]
        public string Title { get; set; }

        /// <summary>
        /// The blurb for the highlight <br/>
        /// Example: EDM@NYI: Nurse buries slick goal in 2nd
        /// </summary>
        [JsonProperty("blurb")]
        public string Blurb { get; set; }

        /// <summary>
        /// The description for the highlight <br/>
        /// Example: A scramble in front of Ilya Sorokin ends with Darnell Nurse firing home a go-ahead goal off a wrist shot goal
        /// </summary>
        [JsonProperty("description")]
        public string Description { get; set; }

        /// <summary>
        /// The duration of the entire highlight <br/>
        /// Example: 00:52
        /// </summary>
        [JsonProperty("duration")]
        public string Duration { get; set; }

        /// <summary>
        /// If an authorization flow is required for the highlight
        /// </summary>
        [JsonProperty("authFlow")]
        public bool? AuthFlow { get; set; }

        /// <summary>
        /// The media playback identifier <br/>
        /// Example: 10066385
        /// </summary>
        [JsonProperty("mediaPlaybackId")]
        public string MediaPlaybackId { get; set; }

        /// <summary>
        /// Returns the state of the media for the highlight <br/>
        /// Example: MEDIA_ARCHIVE
        /// </summary>
        [JsonProperty("mediaState")]
        public string MediaState { get; set; }

        /// <summary>
        /// Returns a collection of keywords associated with the highlight
        /// </summary>
        [JsonProperty("keywords")]
        public List<Keyword> Keywords { get; set; }

        /// <summary>
        /// Returns the associated image with the highlight 
        /// </summary>
        [JsonProperty("image")]
        public Image Image { get; set; }

        /// <summary>
        /// Returns a collection of media playbacks for the highlight
        /// </summary>
        [JsonProperty("playbacks")]
        public List<Playback> Playbacks { get; set; }
    }

    /// <summary>
    /// Highlight Milestones
    /// </summary>
    public class Milestones
    {
        /// <summary>
        /// The title of the milestone content <br/>
        /// Example: Milestones
        /// </summary>
        [JsonProperty("title")]
        public string Title { get; set; }

        /// <summary>
        /// Returns the date of the milestones stream start <br/>
        /// Example: 2022-01-01T19:00:23+0000
        /// </summary>
        [JsonProperty("streamStart")]
        public DateTime StreamStart { get; set; }

        /// <summary>
        /// Returns a collection of all the milestone items for the NHL game
        /// </summary>
        [JsonProperty("items")]
        public List<MilestoneItem> Items { get; set; }
    }

    /// <summary>
    /// Scoreboard
    /// </summary>
    public class Scoreboard
    {
        /// <summary>
        /// Returns the scoreboard title <br/>
        /// Example: Highlights
        /// </summary>
        [JsonProperty("title")]
        public string Title { get; set; }

        /// <summary>
        /// Returns the identifier of the topic list <br/>
        /// Example: 329057500
        /// </summary>
        [JsonProperty("topicList")]
        public string TopicList { get; set; }

        /// <summary>
        /// Returns a collection of the NHL highlight items
        /// </summary>
        [JsonProperty("items")]
        public List<HighlightItem> Items { get; set; }
    }

    /// <summary>
    /// Contributor Information
    /// </summary>
    public class ContributorInformation
    {
        /// <summary>
        /// The name of the contributor <br/>
        /// Example: Derek Van Diest
        /// </summary>
        [JsonProperty("name")]
        public string Name { get; set; }

        /// <summary>
        /// Returns the Twitter user name for the contributor <br/>
        /// Example: @DanArritt
        /// </summary>
        [JsonProperty("twitter")]
        public string Twitter { get; set; }
    }

    /// <summary>
    /// Content Keyword
    /// </summary>
    public class Keyword
    {
        /// <summary>
        /// Returns the type of keyword <br/>
        /// Example: shareable
        /// </summary>
        [JsonProperty("type")]
        public string Type { get; set; }

        /// <summary>
        /// Returns if the value is present <br/>
        /// Example: Y
        /// </summary>
        [JsonProperty("value")]
        public string Value { get; set; }

        /// <summary>
        /// Returns if the display name <br/>
        /// Example: Y
        /// </summary>
        [JsonProperty("displayName")]
        public string DisplayName { get; set; }
    }

    /// <summary>
    /// 1212x662 Content
    /// </summary>
    public class _1212x662
    {
        /// <summary>
        /// Returns the aspect ratio of the content <br/>
        /// Example: 16:9
        /// </summary>
        [JsonProperty("aspectRatio")]
        public string AspectRatio { get; set; }

        /// <summary>
        /// Returns the width of the content <br/>
        /// Example: 372
        /// </summary>
        [JsonProperty("width")]
        public int Width { get; set; }

        /// <summary>
        /// Returns the height of the content <br/>
        /// Example: 210
        /// </summary>
        [JsonProperty("height")]
        public int Height { get; set; }

        /// <summary>
        /// Returns the source of the content <br/>
        /// Example: https://cms.nhl.bamgrid.com/images/photos/329384462/320x180/cut.jpg
        /// </summary>
        [JsonProperty("src")]
        public string Src { get; set; }

        /// <summary>
        /// Returns the source of the content at 2x size<br/>
        /// Example: https://cms.nhl.bamgrid.com/images/photos/329384462/640x360/cut.jpg
        /// </summary>
        [JsonProperty("at2x")]
        public string At2x { get; set; }

        /// <summary>
        /// Returns the source of the content at 3x size<br/>
        /// Example: https://cms.nhl.bamgrid.com/images/photos/329384462/960x540/cut.jpg
        /// </summary>
        [JsonProperty("at3x")]
        public string At3x { get; set; }
    }

    /// <summary>
    /// Content Playback
    /// </summary>
    public class Playback
    {
        /// <summary>
        /// The name of the content playback <br/>
        /// Example: FLASH_192K_320X180
        /// </summary>
        [JsonProperty("name")]
        public string Name { get; set; }
        /// <summary>
        /// Returns the width of the content <br/>
        /// Example: 320
        /// </summary>
        [JsonProperty("width")]
        public string Width { get; set; }
        /// <summary>
        /// Returns the height of the content <br/>
        /// Example: 180
        /// </summary>
        [JsonProperty("height")]
        public string Height { get; set; }
        /// <summary>
        /// Returns a URL for the playback content <br/>
        /// Example: <a href="https://hlslive-wsczoominwestus.med.nhl.com/editor/7dbf6960-2945-4b29-8f00-af045b72adb6.mp4">https://hlslive-wsczoominwestus.med.nhl.com/editor/7dbf6960-2945-4b29-8f00-af045b72adb6.mp4</a>
        /// </summary>
        [JsonProperty("url")]
        public string Url { get; set; }
    }

    /// <summary>
    /// Content Recap
    /// </summary>
    public class Recap
    {
        /// <summary>
        /// Returns the title of the recap <br/>
        /// Example: Recap
        /// </summary>
        [JsonProperty("title")]
        public string Title { get; set; }

        /// <summary>
        /// Returns the topic list <br/>
        /// Example: Anaheim Ducks, Colorado Avalanche, game recap, NHL, hockey, news
        /// </summary>
        [JsonProperty("topicList")]
        public string TopicList { get; set; }

        /// <summary>
        /// Returns a collection of editorial items for the NHL game recap
        /// </summary>
        [JsonProperty("items")]
        public List<EditorialItem> Items { get; set; }
    }

    /// <summary>
    /// Content Editorial 
    /// </summary>
    public class Editorial
    {
        /// <summary>
        /// Returns the NHL live game feed content preview
        /// </summary>
        [JsonProperty("preview")]
        public Preview Preview { get; set; }

        /// <summary>
        /// Returns the NHL live game feed content articles
        /// </summary>
        [JsonProperty("articles")]
        public Articles Articles { get; set; }

        /// <summary>
        /// Returns the NHL live game feed content recap
        /// </summary>
        [JsonProperty("recap")]
        public Recap Recap { get; set; }
    }

    /// <summary>
    /// Content Electronic Program Guide
    /// </summary>
    public class Epg
    {
        /// <summary>
        /// The title of the electronic program guide <br/>
        /// Example: NHLTV
        /// </summary>
        [JsonProperty("title")]
        public string Title { get; set; }

        /// <summary>
        /// Returns the type of platform for the electronic program guide <br/>
        /// Example: web
        /// </summary>
        [JsonProperty("platform")]
        public string Platform { get; set; }

        /// <summary>
        /// Returns the a collection of items for the electronic program guide 
        /// </summary>
        [JsonProperty("items")]
        public List<EpgItem> Items { get; set; }

        /// <summary>
        /// Returns a collection of terms for the topic list for the electronic program guide <br/>
        /// Example: 329057632
        /// </summary>
        [JsonProperty("topicList")]
        public string TopicList { get; set; }
    }

    /// <summary>
    /// 1202x670 Content
    /// </summary>
    public class _1202x670
    {
        /// <summary>
        /// Returns the aspect ratio of the content <br/>
        /// Example: 16:9
        /// </summary>
        [JsonProperty("aspectRatio")]
        public string AspectRatio { get; set; }

        /// <summary>
        /// Returns the width of the content <br/>
        /// Example: 372
        /// </summary>
        [JsonProperty("width")]
        public int Width { get; set; }

        /// <summary>
        /// Returns the height of the content <br/>
        /// Example: 210
        /// </summary>
        [JsonProperty("height")]
        public int Height { get; set; }

        /// <summary>
        /// Returns the source of the content <br/>
        /// Example: https://cms.nhl.bamgrid.com/images/photos/329384462/320x180/cut.jpg
        /// </summary>
        [JsonProperty("src")]
        public string Src { get; set; }

        /// <summary>
        /// Returns the source of the content at 2x size<br/>
        /// Example: https://cms.nhl.bamgrid.com/images/photos/329384462/640x360/cut.jpg
        /// </summary>
        [JsonProperty("at2x")]
        public string At2x { get; set; }

        /// <summary>
        /// Returns the source of the content at 3x size<br/>
        /// Example: https://cms.nhl.bamgrid.com/images/photos/329384462/960x540/cut.jpg
        /// </summary>
        [JsonProperty("at3x")]
        public string At3x { get; set; }
    }

    /// <summary>
    /// 1220x668 Content
    /// </summary>
    public class _1220x668
    {
        /// <summary>
        /// Returns the aspect ratio of the content <br/>
        /// Example: 16:9
        /// </summary>
        [JsonProperty("aspectRatio")]
        public string AspectRatio { get; set; }

        /// <summary>
        /// Returns the width of the content <br/>
        /// Example: 372
        /// </summary>
        [JsonProperty("width")]
        public int Width { get; set; }

        /// <summary>
        /// Returns the height of the content <br/>
        /// Example: 210
        /// </summary>
        [JsonProperty("height")]
        public int Height { get; set; }

        /// <summary>
        /// Returns the source of the content <br/>
        /// Example: https://cms.nhl.bamgrid.com/images/photos/329384462/320x180/cut.jpg
        /// </summary>
        [JsonProperty("src")]
        public string Src { get; set; }

        /// <summary>
        /// Returns the source of the content at 2x size<br/>
        /// Example: https://cms.nhl.bamgrid.com/images/photos/329384462/640x360/cut.jpg
        /// </summary>
        [JsonProperty("at2x")]
        public string At2x { get; set; }

        /// <summary>
        /// Returns the source of the content at 3x size<br/>
        /// Example: https://cms.nhl.bamgrid.com/images/photos/329384462/960x540/cut.jpg
        /// </summary>
        [JsonProperty("at3x")]
        public string At3x { get; set; }
    }

    /// <summary>
    /// Media URLS
    /// </summary>
    public class MediaURLS
    {
        /// <summary>
        /// Returns the media URL for the 320x180 content <br/>
        /// Example: https://hlslive-wsczoominwestus.med.nhl.com/editor/52fe29c6-4a70-4979-82e4-7f8cc286187b.mp4
        /// </summary>
        [JsonProperty("FLASH_192K_320X180")]
        public string FLASH192K320X180 { get; set; }

        /// <summary>
        /// Returns the media URL for the 384x216 content <br/>
        /// Example: https://hlslive-wsczoominwestus.med.nhl.com/editor/889b39d5-bd16-4a4e-901a-ea0677908a6d.mp4
        /// </summary>
        [JsonProperty("FLASH_450K_384x216")]
        public string FLASH450K384x216 { get; set; }

        /// <summary>
        /// Returns the media URL for the 640X360 content <br/>
        /// Example: https://hlslive-wsczoominwestus.med.nhl.com/editor/c7722f68-f914-4fb4-920e-3d3078a9e4d5.mp4
        /// </summary>
        [JsonProperty("FLASH_1200K_640X360")]
        public string FLASH1200K640X360 { get; set; }

        /// <summary>
        /// Returns the media URL for the 896x504 content <br/>
        /// Example: https://hlslive-wsczoominwestus.med.nhl.com/editor/783b8ee5-0690-404c-a723-48ad3859a9e3.mp4
        /// </summary>
        [JsonProperty("FLASH_1800K_896x504")]
        public string FLASH1800K896x504 { get; set; }

        /// <summary>
        /// Returns the media HTTP cloud mobile content <br/>
        /// Example: https://hlslive-wsczoominwestus.med.nhl.com/publish-hls/4135809/MasterMobile.m3u8
        /// </summary>
        [JsonProperty("HTTP_CLOUD_MOBILE")]
        public string HTTPCLOUDMOBILE { get; set; }

        /// <summary>
        /// Returns the media HTTP cloud tablet content <br/>
        /// Example: https://hlslive-wsczoominwestus.med.nhl.com/publish-hls/4135809/MasterTablet.m3u8
        /// </summary>
        [JsonProperty("HTTP_CLOUD_TABLET")]
        public string HTTPCLOUDTABLET { get; set; }

        /// <summary>
        /// Returns the media HTTP cloud tablet 60 content <br/>
        /// Example: https://hlslive-wsczoominwestus.med.nhl.com/publish-hls/4135809/MasterTablet60.m3u8
        /// </summary>
        [JsonProperty("HTTP_CLOUD_TABLET_60")]
        public string HTTPCLOUDTABLET60 { get; set; }

        /// <summary>
        /// Returns the media HTTP cloud wired content <br/>
        /// Example: https://hlslive-wsczoominwestus.med.nhl.com/publish-hls/4135809/MasterWired.m3u8
        /// </summary>
        [JsonProperty("HTTP_CLOUD_WIRED")]
        public string HTTPCLOUDWIRED { get; set; }

        /// <summary>
        /// Returns the media HTTP cloud wired 60 content <br/>
        /// Example: https://hlslive-wsczoominwestus.med.nhl.com/publish-hls/4135809/MasterWired60.m3u8
        /// </summary>
        [JsonProperty("HTTP_CLOUD_WIRED_60")]
        public string HTTPCLOUDWIRED60 { get; set; }

        /// <summary>
        /// Returns the media HTTP cloud wired web content <br/>
        /// Example: https://hlslive-wsczoominwestus.med.nhl.com/publish-hls/4135809/MasterWiredWeb.m3u8
        /// </summary>
        [JsonProperty("HTTP_CLOUD_WIRED_WEB")]
        public string HTTPCLOUDWIREDWEB { get; set; }
    }

    /// <summary>
    /// Content Preview
    /// </summary>
    public class Preview
    {
        /// <summary>
        /// Returns the title of the preview <br/>
        /// Example: Preview
        /// </summary>
        [JsonProperty("title")]
        public string Title { get; set; }

        /// <summary>
        /// Returns a collection of topics <br/>
        /// Example: Anaheim Ducks, Colorado Avalanche, Game Preview, NHL, Hockey, Projected Lineups
        /// </summary>
        [JsonProperty("topicList")]
        public string TopicList { get; set; }

        /// <summary>
        /// Returns a collection of editorial items
        /// </summary>
        [JsonProperty("items")]
        public List<EditorialItem> Items { get; set; }
    }

    /// <summary>
    /// Content Articles
    /// </summary>
    public class Articles
    {
        /// <summary>
        /// Returns the title of the articles <br/>
        /// Example: Article
        /// </summary>
        [JsonProperty("title")]
        public string Title { get; set; }

        /// <summary>
        /// Returns a collection of topics <br/>
        /// Example: Anaheim Ducks, Colorado Avalanche, Game Preview, NHL, Hockey, Projected Lineups
        /// </summary>
        [JsonProperty("topicList")]
        public string TopicList { get; set; }

        /// <summary>
        /// A collection of article items
        /// </summary>
        [JsonProperty("items")]
        public List<object> Items { get; set; }
    }

    /// <summary>
    /// Content Item
    /// </summary>
    public class Item
    {
        /// <summary>
        /// The type of content item <br/>
        /// Example: article
        /// </summary>
        [JsonProperty("type")]
        public string Type { get; set; }

        /// <summary>
        /// The state of the content item <br/>
        /// Example: A
        /// </summary>
        [JsonProperty("state")]
        public string State { get; set; }

        /// <summary>
        /// The date of the content item <br/>
        /// Example: 2022-01-02T20:05:46-0500
        /// </summary>
        [JsonProperty("date")]
        public DateTime Date { get; set; }

        /// <summary>
        /// The identifier of the content item <br/>
        /// Example: 329232864
        /// </summary>
        [JsonProperty("id")]
        public string Id { get; set; }

        /// <summary>
        /// The headline of the content item <br/>
        /// Example: Avalanche rally to defeat Ducks after 16-day break
        /// </summary>
        [JsonProperty("headline")]
        public string Headline { get; set; }

        /// <summary>
        /// The sub head of the content item <br/>
        /// Example: O'Connor scores winner with 1:11 left, Landeskog gets goal in return from injury
        /// </summary>
        [JsonProperty("subhead")]
        public string Subhead { get; set; }

        /// <summary>
        /// The SEO title of the content item <br/>
        /// Example: Anaheim Ducks Colorado Avalanche game recap
        /// </summary>
        [JsonProperty("seoTitle")]
        public string SeoTitle { get; set; }

        /// <summary>
        /// The SEO description of the content item <br/>
        /// Example: Logan O'Connor scored with 1:11 left in the third period for the Colorado Avalanche, who rallied for a 4-2 win against the Anaheim Ducks at Ball Arena on Sunday.
        /// </summary>
        [JsonProperty("seoDescription")]
        public string SeoDescription { get; set; }

        /// <summary>
        /// The SEO keywords of the content item <br/>
        /// Example: Anaheim Ducks, Colorado Avalanche, game recap, NHL, hockey, news
        /// </summary>
        [JsonProperty("seoKeywords")]
        public string SeoKeywords { get; set; }

        /// <summary>
        /// The slug for the content item <br/>
        /// Example: Anaheim Ducks, Colorado Avalanche, game recap, NHL, hockey, news
        /// </summary>
        [JsonProperty("slug")]
        public string Slug { get; set; }

        /// <summary>
        /// The boolean value if commenting is available
        /// </summary>
        [JsonProperty("commenting")]
        public bool Commenting { get; set; }

        /// <summary>
        /// The tag line for the content item <br/>
        /// Example: O'Connor scores winner with 1:11 left, Landeskog gets goal in return from injury
        /// </summary>
        [JsonProperty("tagline")]
        public string Tagline { get; set; }

        /// <summary>
        /// The collection of token data for all of the items related to the content item
        /// </summary>
        [JsonProperty("tokenData")]
        public Dictionary<string, EditorialPreviewTokenData> TokenData { get; set; }

        /// <summary>
        /// The collection of token data for all of the items related to the content item
        /// </summary>
        [JsonProperty("contributor")]
        public Contributor Contributor { get; set; }

        /// <summary>
        /// A collection of keywords display
        /// </summary>
        [JsonProperty("keywordsDisplay")]
        public List<KeywordsDisplay> KeywordsDisplay { get; set; }

        /// <summary>
        /// A collection of all keywords
        /// </summary>
        [JsonProperty("keywordsAll")]
        public List<KeywordsAll> KeywordsAll { get; set; }

        /// <summary>
        /// The content item approval
        /// </summary>
        [JsonProperty("approval")]
        public string Approval { get; set; }

        /// <summary>
        /// The URL to the content item <br/>
        /// Example: /news/anaheim-ducks-colorado-avalanche-game-recap/c-329232864?game_pk=2021020580
        /// </summary>
        [JsonProperty("url")]
        public string Url { get; set; }

        /// <summary>
        /// The data URI <br/>
        /// Example: /nhl/id/v1/329232864/details/web-v1.json
        /// </summary>
        [JsonProperty("dataURI")]
        public string DataURI { get; set; }

        /// <summary>
        /// The content item object primary key word <br/>
        /// </summary>
        [JsonProperty("primaryKeyword")]
        public PrimaryKeyword PrimaryKeyword { get; set; }

        /// <summary>
        /// The share image of content item
        /// </summary>
        [JsonProperty("shareImage")]
        public string ShareImage { get; set; }

        /// <summary>
        /// Returns a collection of media for the content item
        /// </summary>
        [JsonProperty("media")]
        public Media Media { get; set; }

        /// <summary>
        /// Returns the preview headline for the content item <br/>
        /// Example: DENVER -- Logan O'Connor scored to break a tie with 1:11 left in the third period for the Colorado Avalanche, who rallied for a 4-2 win against the Anaheim Ducks at Ball Arena on Sunday.
        /// </summary>
        [JsonProperty("preview")]
        public string Preview { get; set; }

        /// <summary>
        /// Returns the GUID for the content item <br/>
        /// Example: 8d67cae1-94e1-4025-9aae-a1525fec0309
        /// </summary>
        [JsonProperty("guid")]
        public string Guid { get; set; }

        /// <summary>
        /// Returns the type of media state of the content item<br/>
        /// Example: MEDIA_ARCHIVE
        /// </summary>
        [JsonProperty("mediaState")]
        public string MediaState { get; set; }

        /// <summary>
        /// Returns the media playback id of the content item<br/>
        /// Example: 2026746301
        /// </summary>
        [JsonProperty("mediaPlaybackId")]
        public string MediaPlaybackId { get; set; }

        /// <summary>
        /// Returns the media feed type of the content item<br/>
        /// Example: AWAY 
        /// </summary>
        [JsonProperty("mediaFeedType")]
        public string MediaFeedType { get; set; }

        /// <summary>
        /// Returns the call letters of the content item<br/>
        /// Example: BSSC
        /// </summary>
        [JsonProperty("callLetters")]
        public string CallLetters { get; set; }

        /// <summary>
        /// Returns the event identifier of the content item<br/>
        /// Example: 221-3002142
        /// </summary>
        [JsonProperty("eventId")]
        public string EventId { get; set; }

        /// <summary>
        /// Returns the language of the content item <br/>
        /// Example: Eng
        /// </summary>
        [JsonProperty("language")]
        public string Language { get; set; }

        /// <summary>
        /// Returns true or false if it is a free game
        /// </summary>
        [JsonProperty("freeGame")]
        public bool FreeGame { get; set; }

        /// <summary>
        /// Returns the name of the feed
        /// </summary>
        [JsonProperty("feedName")]
        public string FeedName { get; set; }

        /// <summary>
        /// Returns true or false if it has game plus
        /// </summary>
        [JsonProperty("gamePlus")]
        public bool GamePlus { get; set; }

        /// <summary>
        /// Returns the title for the content item <br/>
        /// Example: Audio
        /// </summary>
        [JsonProperty("title")]
        public string Title { get; set; }

        /// <summary>
        /// Returns a blurb for the content item <br/>
        /// Example: Condensed Game: Ducks @ Avalanche
        /// </summary>
        [JsonProperty("blurb")]
        public string Blurb { get; set; }

        /// <summary>
        /// Returns a description for the content item <br/>
        /// Example: Extended highlights of the Anaheim Ducks at the Colorado Avalanche
        /// </summary>
        [JsonProperty("description")]
        public string Description { get; set; }

        /// <summary>
        /// Returns the duration for the content item <br/>
        /// Example: 09:07
        /// </summary>
        [JsonProperty("duration")]
        public string Duration { get; set; }

        /// <summary>
        /// Returns true or false for the auth flow for the content item 
        /// </summary>
        [JsonProperty("authFlow")]
        public bool? AuthFlow { get; set; }

        /// <summary>
        /// Returns a collection of keywords
        /// </summary>
        [JsonProperty("keywords")]
        public List<Keyword> Keywords { get; set; }

        /// <summary>
        /// Returns the image for the content item
        /// </summary>
        [JsonProperty("image")]
        public Image Image { get; set; }

        /// <summary>
        /// Returns a collection of playback items for the content item
        /// </summary>
        [JsonProperty("playbacks")]
        public List<Playback> Playbacks { get; set; }

        /// <summary>
        /// Returns the absolute time and date <br/>
        /// Example: 2022-01-02T20:00:49+0000
        /// </summary>
        [JsonProperty("timeAbsolute")]
        public DateTime TimeAbsolute { get; set; }

        /// <summary>
        /// Returns the time offset <br/>
        /// Example: 0
        /// </summary>
        [JsonProperty("timeOffset")]
        public string TimeOffset { get; set; }

        /// <summary>
        /// Returns the NHL game period for the content item <br/>
        /// Example: 1
        /// </summary>
        [JsonProperty("period")]
        public string Period { get; set; }

        /// <summary>
        /// Returns the stats event identifier for the content item <br/>
        /// Example: 8
        /// </summary>
        [JsonProperty("statsEventId")]
        public string StatsEventId { get; set; }

        /// <summary>
        /// Returns the NHL team identifier <br/>
        /// Example: 10
        /// </summary>
        [JsonProperty("teamId")]
        public string TeamId { get; set; }

        /// <summary>
        /// Returns the NHL player identifier for the content item <br/>
        /// Example: 8470613
        /// </summary>
        [JsonProperty("playerId")]
        public string PlayerId { get; set; }

        /// <summary>
        /// Returns the period time for the content item <br/>
        /// Example: 00:00
        /// </summary>
        [JsonProperty("periodTime")]
        public string PeriodTime { get; set; }

        /// <summary>
        /// Returns the ordinal number for the content item <br/>
        /// Example: 1st
        /// </summary>
        [JsonProperty("ordinalNum")]
        public string OrdinalNum { get; set; }

        /// <summary>
        /// Returns the highlight for the content item
        /// </summary>
        [JsonProperty("highlight")]
        public Highlight Highlight { get; set; }
    }

    /// <summary>
    /// Content Image
    /// </summary>
    public class Image
    {
        /// <summary>
        /// Returns the title of the image
        /// </summary>
        [JsonProperty("title")]
        public string Title { get; set; }

        /// <summary>
        /// Returns the alternate text of the image
        /// </summary>
        [JsonProperty("altText")]
        public string AltText { get; set; }

        /// <summary>
        /// Returns all of the cuts and sizes for the content image
        /// </summary>
        [JsonProperty("cuts")]
        public Cuts Cuts { get; set; }
    }

    /// <summary>
    /// Content Media
    /// </summary>
    public class Media
    {
        /// <summary>
        /// A collection of all the EPG's
        /// </summary>
        [JsonProperty("epg")]
        public List<Epg> Epg { get; set; }

        /// <summary>
        /// Returns all of the milestones for the NHL game content
        /// </summary>
        [JsonProperty("milestones")]
        public Milestones Milestones { get; set; }
    }

    /// <summary>
    /// Content Cuts
    /// </summary>
    public class Cuts
    {
        /// <summary>
        /// The content cuts for 2568x1444
        /// </summary>
        [JsonProperty("2568x1444")]
        public _2568x1444 _2568x1444 { get; set; }

        /// <summary>
        /// The content cuts for 2208x1242
        /// </summary>
        [JsonProperty("2208x1242")]
        public _2208x1242 _2208x1242 { get; set; }

        /// <summary>
        /// The content cuts for 2048x1152
        /// </summary>
        [JsonProperty("2048x1152")]
        public _2048x1152 _2048x1152 { get; set; }

        /// <summary>
        /// The content cuts for 1704x960
        /// </summary>
        [JsonProperty("1704x960")]
        public _1704x960 _1704x960 { get; set; }

        /// <summary>
        /// The content cuts for 1536x864
        /// </summary>
        [JsonProperty("1536x864")]
        public _1536x864 _1536x864 { get; set; }

        /// <summary>
        /// The content cuts for 1284x722
        /// </summary>
        [JsonProperty("1284x722")]
        public _1284x722 _1284x722 { get; set; }

        /// <summary>
        /// The content cuts for 1136x640
        /// </summary>
        [JsonProperty("1136x640")]
        public _1136x640 _1136x640 { get; set; }

        /// <summary>
        /// The content cuts for 1024x576
        /// </summary>
        [JsonProperty("1024x576")]
        public _1024x576 _1024x576 { get; set; }

        /// <summary>
        /// The content cuts for 960x540
        /// </summary>
        [JsonProperty("960x540")]
        public _960x540 _960x540 { get; set; }

        /// <summary>
        /// The content cuts for 768x432
        /// </summary>
        [JsonProperty("768x432")]
        public _768x432 _768x432 { get; set; }

        /// <summary>
        /// The content cuts for 640x360
        /// </summary>
        [JsonProperty("640x360")]
        public _640x360 _640x360 { get; set; }

        /// <summary>
        /// The content cuts for 568x320
        /// </summary>
        [JsonProperty("568x320")]
        public _568x320 _568x320 { get; set; }

        /// <summary>
        /// The content cuts for 372x210
        /// </summary>
        [JsonProperty("372x210")]
        public _372x210 _372x210 { get; set; }

        /// <summary>
        /// The content cuts for 320x180
        /// </summary>
        [JsonProperty("320x180")]
        public _320x180 _320x180 { get; set; }

        /// <summary>
        /// The content cuts for 248x140
        /// </summary>
        [JsonProperty("248x140")]
        public _248x140 _248x140 { get; set; }

        /// <summary>
        /// The content cuts for 124x70
        /// </summary>
        [JsonProperty("124x70")]
        public _124x70 _124x70 { get; set; }

        /// <summary>
        /// The content cuts for 1200x630
        /// </summary>
        [JsonProperty("1200x630")]
        public _1200x630 _1200x630 { get; set; }

        /// <summary>
        /// The content cuts for 1920x1080
        /// </summary>
        [JsonProperty("1920x1080")]
        public _1920x1080 _1920x1080 { get; set; }

        /// <summary>
        /// The content cuts for 1220x668
        /// </summary>
        [JsonProperty("1220x668")]
        public _1220x668 _1220x668 { get; set; }

        /// <summary>
        /// The content cuts for 1212x662
        /// </summary>
        [JsonProperty("1212x662")]
        public _1212x662 _1212x662 { get; set; }

        /// <summary>
        /// The content cuts for 1202x670
        /// </summary>
        [JsonProperty("1202x670")]
        public _1202x670 _1202x670 { get; set; }
    }

    /// <summary>
    /// 124x70 Content
    /// </summary>
    public class _124x70
    {
        /// <summary>
        /// Returns the aspect ratio of the content <br/>
        /// Example: 16:9
        /// </summary>
        [JsonProperty("aspectRatio")]
        public string AspectRatio { get; set; }

        /// <summary>
        /// Returns the width of the content <br/>
        /// Example: 372
        /// </summary>
        [JsonProperty("width")]
        public int Width { get; set; }

        /// <summary>
        /// Returns the height of the content <br/>
        /// Example: 210
        /// </summary>
        [JsonProperty("height")]
        public int Height { get; set; }

        /// <summary>
        /// Returns the source of the content <br/>
        /// Example: https://cms.nhl.bamgrid.com/images/photos/329384462/320x180/cut.jpg
        /// </summary>
        [JsonProperty("src")]
        public string Src { get; set; }

        /// <summary>
        /// Returns the source of the content at 2x size<br/>
        /// Example: https://cms.nhl.bamgrid.com/images/photos/329384462/640x360/cut.jpg
        /// </summary>
        [JsonProperty("at2x")]
        public string At2x { get; set; }

        /// <summary>
        /// Returns the source of the content at 3x size<br/>
        /// Example: https://cms.nhl.bamgrid.com/images/photos/329384462/960x540/cut.jpg
        /// </summary>
        [JsonProperty("at3x")]
        public string At3x { get; set; }

    }

    /// <summary>
    /// 1920x1080 Content
    /// </summary>
    public class _1920x1080
    {
        /// <summary>
        /// Returns the aspect ratio of the content <br/>
        /// Example: 16:9
        /// </summary>
        [JsonProperty("aspectRatio")]
        public string AspectRatio { get; set; }

        /// <summary>
        /// Returns the width of the content <br/>
        /// Example: 372
        /// </summary>
        [JsonProperty("width")]
        public int Width { get; set; }

        /// <summary>
        /// Returns the height of the content <br/>
        /// Example: 210
        /// </summary>
        [JsonProperty("height")]
        public int Height { get; set; }

        /// <summary>
        /// Returns the source of the content <br/>
        /// Example: https://cms.nhl.bamgrid.com/images/photos/329384462/320x180/cut.jpg
        /// </summary>
        [JsonProperty("src")]
        public string Src { get; set; }

        /// <summary>
        /// Returns the source of the content at 2x size<br/>
        /// Example: https://cms.nhl.bamgrid.com/images/photos/329384462/640x360/cut.jpg
        /// </summary>
        [JsonProperty("at2x")]
        public string At2x { get; set; }

        /// <summary>
        /// Returns the source of the content at 3x size<br/>
        /// Example: https://cms.nhl.bamgrid.com/images/photos/329384462/960x540/cut.jpg
        /// </summary>
        [JsonProperty("at3x")]
        public string At3x { get; set; }
    }

    /// <summary>
    /// 1200x630 Content
    /// </summary>
    public class _1200x630
    {
        /// <summary>
        /// Returns the aspect ratio of the content <br/>
        /// Example: 16:9
        /// </summary>
        [JsonProperty("aspectRatio")]
        public string AspectRatio { get; set; }

        /// <summary>
        /// Returns the width of the content <br/>
        /// Example: 372
        /// </summary>
        [JsonProperty("width")]
        public int Width { get; set; }

        /// <summary>
        /// Returns the height of the content <br/>
        /// Example: 210
        /// </summary>
        [JsonProperty("height")]
        public int Height { get; set; }

        /// <summary>
        /// Returns the source of the content <br/>
        /// Example: https://cms.nhl.bamgrid.com/images/photos/329384462/320x180/cut.jpg
        /// </summary>
        [JsonProperty("src")]
        public string Src { get; set; }

        /// <summary>
        /// Returns the source of the content at 2x size<br/>
        /// Example: https://cms.nhl.bamgrid.com/images/photos/329384462/640x360/cut.jpg
        /// </summary>
        [JsonProperty("at2x")]
        public string At2x { get; set; }

        /// <summary>
        /// Returns the source of the content at 3x size<br/>
        /// Example: https://cms.nhl.bamgrid.com/images/photos/329384462/960x540/cut.jpg
        /// </summary>
        [JsonProperty("at3x")]
        public string At3x { get; set; }
    }


    /// <summary>
    /// 2568x1444 Content
    /// </summary>
    public class _2568x1444
    {
        /// <summary>
        /// Returns the aspect ratio of the content <br/>
        /// Example: 16:9
        /// </summary>
        [JsonProperty("aspectRatio")]
        public string AspectRatio { get; set; }

        /// <summary>
        /// Returns the width of the content <br/>
        /// Example: 372
        /// </summary>
        [JsonProperty("width")]
        public int Width { get; set; }

        /// <summary>
        /// Returns the height of the content <br/>
        /// Example: 210
        /// </summary>
        [JsonProperty("height")]
        public int Height { get; set; }

        /// <summary>
        /// Returns the source of the content <br/>
        /// Example: https://cms.nhl.bamgrid.com/images/photos/329384462/320x180/cut.jpg
        /// </summary>
        [JsonProperty("src")]
        public string Src { get; set; }

        /// <summary>
        /// Returns the source of the content at 2x size<br/>
        /// Example: https://cms.nhl.bamgrid.com/images/photos/329384462/640x360/cut.jpg
        /// </summary>
        [JsonProperty("at2x")]
        public string At2x { get; set; }

        /// <summary>
        /// Returns the source of the content at 3x size<br/>
        /// Example: https://cms.nhl.bamgrid.com/images/photos/329384462/960x540/cut.jpg
        /// </summary>
        [JsonProperty("at3x")]
        public string At3x { get; set; }
    }

    /// <summary>
    /// 2208x1242 Content
    /// </summary>
    public class _2208x1242
    {
        /// <summary>
        /// Returns the aspect ratio of the content <br/>
        /// Example: 16:9
        /// </summary>
        [JsonProperty("aspectRatio")]
        public string AspectRatio { get; set; }

        /// <summary>
        /// Returns the width of the content <br/>
        /// Example: 372
        /// </summary>
        [JsonProperty("width")]
        public int Width { get; set; }

        /// <summary>
        /// Returns the height of the content <br/>
        /// Example: 210
        /// </summary>
        [JsonProperty("height")]
        public int Height { get; set; }

        /// <summary>
        /// Returns the source of the content <br/>
        /// Example: https://cms.nhl.bamgrid.com/images/photos/329384462/320x180/cut.jpg
        /// </summary>
        [JsonProperty("src")]
        public string Src { get; set; }

        /// <summary>
        /// Returns the source of the content at 2x size<br/>
        /// Example: https://cms.nhl.bamgrid.com/images/photos/329384462/640x360/cut.jpg
        /// </summary>
        [JsonProperty("at2x")]
        public string At2x { get; set; }

        /// <summary>
        /// Returns the source of the content at 3x size<br/>
        /// Example: https://cms.nhl.bamgrid.com/images/photos/329384462/960x540/cut.jpg
        /// </summary>
        [JsonProperty("at3x")]
        public string At3x { get; set; }
    }

    /// <summary> 
    /// 2048x1152 Content
    /// </summary>
    public class _2048x1152
    {
        /// <summary>
        /// Returns the aspect ratio of the content <br/>
        /// Example: 16:9
        /// </summary>
        [JsonProperty("aspectRatio")]
        public string AspectRatio { get; set; }

        /// <summary>
        /// Returns the width of the content <br/>
        /// Example: 372
        /// </summary>
        [JsonProperty("width")]
        public int Width { get; set; }

        /// <summary>
        /// Returns the height of the content <br/>
        /// Example: 210
        /// </summary>
        [JsonProperty("height")]
        public int Height { get; set; }

        /// <summary>
        /// Returns the source of the content <br/>
        /// Example: https://cms.nhl.bamgrid.com/images/photos/329384462/320x180/cut.jpg
        /// </summary>
        [JsonProperty("src")]
        public string Src { get; set; }

        /// <summary>
        /// Returns the source of the content at 2x size<br/>
        /// Example: https://cms.nhl.bamgrid.com/images/photos/329384462/640x360/cut.jpg
        /// </summary>
        [JsonProperty("at2x")]
        public string At2x { get; set; }

        /// <summary>
        /// Returns the source of the content at 3x size<br/>
        /// Example: https://cms.nhl.bamgrid.com/images/photos/329384462/960x540/cut.jpg
        /// </summary>
        [JsonProperty("at3x")]
        public string At3x { get; set; }
    }

    /// <summary> 
    /// 1704x960 Content
    /// </summary>
    public class _1704x960
    {
        /// <summary>
        /// Returns the aspect ratio of the content <br/>
        /// Example: 16:9
        /// </summary>
        [JsonProperty("aspectRatio")]
        public string AspectRatio { get; set; }

        /// <summary>
        /// Returns the width of the content <br/>
        /// Example: 372
        /// </summary>
        [JsonProperty("width")]
        public int Width { get; set; }

        /// <summary>
        /// Returns the height of the content <br/>
        /// Example: 210
        /// </summary>
        [JsonProperty("height")]
        public int Height { get; set; }

        /// <summary>
        /// Returns the source of the content <br/>
        /// Example: https://cms.nhl.bamgrid.com/images/photos/329384462/320x180/cut.jpg
        /// </summary>
        [JsonProperty("src")]
        public string Src { get; set; }

        /// <summary>
        /// Returns the source of the content at 2x size<br/>
        /// Example: https://cms.nhl.bamgrid.com/images/photos/329384462/640x360/cut.jpg
        /// </summary>
        [JsonProperty("at2x")]
        public string At2x { get; set; }

        /// <summary>
        /// Returns the source of the content at 3x size<br/>
        /// Example: https://cms.nhl.bamgrid.com/images/photos/329384462/960x540/cut.jpg
        /// </summary>
        [JsonProperty("at3x")]
        public string At3x { get; set; }
    }

    /// <summary>
    /// 1536x864 Content
    /// </summary>
    public class _1536x864
    {
        /// <summary>
        /// Returns the aspect ratio of the content <br/>
        /// Example: 16:9
        /// </summary>
        [JsonProperty("aspectRatio")]
        public string AspectRatio { get; set; }

        /// <summary>
        /// Returns the width of the content <br/>
        /// Example: 372
        /// </summary>
        [JsonProperty("width")]
        public int Width { get; set; }

        /// <summary>
        /// Returns the height of the content <br/>
        /// Example: 210
        /// </summary>
        [JsonProperty("height")]
        public int Height { get; set; }

        /// <summary>
        /// Returns the source of the content <br/>
        /// Example: https://cms.nhl.bamgrid.com/images/photos/329384462/320x180/cut.jpg
        /// </summary>
        [JsonProperty("src")]
        public string Src { get; set; }

        /// <summary>
        /// Returns the source of the content at 2x size<br/>
        /// Example: https://cms.nhl.bamgrid.com/images/photos/329384462/640x360/cut.jpg
        /// </summary>
        [JsonProperty("at2x")]
        public string At2x { get; set; }

        /// <summary>
        /// Returns the source of the content at 3x size<br/>
        /// Example: https://cms.nhl.bamgrid.com/images/photos/329384462/960x540/cut.jpg
        /// </summary>
        [JsonProperty("at3x")]
        public string At3x { get; set; }
    }

    /// <summary>
    /// 1284x722 Content
    /// </summary>
    public class _1284x722
    {
        /// <summary>
        /// Returns the aspect ratio of the content <br/>
        /// Example: 16:9
        /// </summary>
        [JsonProperty("aspectRatio")]
        public string AspectRatio { get; set; }

        /// <summary>
        /// Returns the width of the content <br/>
        /// Example: 372
        /// </summary>
        [JsonProperty("width")]
        public int Width { get; set; }

        /// <summary>
        /// Returns the height of the content <br/>
        /// Example: 210
        /// </summary>
        [JsonProperty("height")]
        public int Height { get; set; }

        /// <summary>
        /// Returns the source of the content <br/>
        /// Example: https://cms.nhl.bamgrid.com/images/photos/329384462/320x180/cut.jpg
        /// </summary>
        [JsonProperty("src")]
        public string Src { get; set; }

        /// <summary>
        /// Returns the source of the content at 2x size<br/>
        /// Example: https://cms.nhl.bamgrid.com/images/photos/329384462/640x360/cut.jpg
        /// </summary>
        [JsonProperty("at2x")]
        public string At2x { get; set; }

        /// <summary>
        /// Returns the source of the content at 3x size<br/>
        /// Example: https://cms.nhl.bamgrid.com/images/photos/329384462/960x540/cut.jpg
        /// </summary>
        [JsonProperty("at3x")]
        public string At3x { get; set; }
    }

    /// <summary>
    /// 1136x640 Content
    /// </summary>
    public class _1136x640
    {
        /// <summary>
        /// Returns the aspect ratio of the content <br/>
        /// Example: 16:9
        /// </summary>
        [JsonProperty("aspectRatio")]
        public string AspectRatio { get; set; }

        /// <summary>
        /// Returns the width of the content <br/>
        /// Example: 372
        /// </summary>
        [JsonProperty("width")]
        public int Width { get; set; }

        /// <summary>
        /// Returns the height of the content <br/>
        /// Example: 210
        /// </summary>
        [JsonProperty("height")]
        public int Height { get; set; }

        /// <summary>
        /// Returns the source of the content <br/>
        /// Example: https://cms.nhl.bamgrid.com/images/photos/329384462/320x180/cut.jpg
        /// </summary>
        [JsonProperty("src")]
        public string Src { get; set; }

        /// <summary>
        /// Returns the source of the content at 2x size<br/>
        /// Example: https://cms.nhl.bamgrid.com/images/photos/329384462/640x360/cut.jpg
        /// </summary>
        [JsonProperty("at2x")]
        public string At2x { get; set; }

        /// <summary>
        /// Returns the source of the content at 3x size<br/>
        /// Example: https://cms.nhl.bamgrid.com/images/photos/329384462/960x540/cut.jpg
        /// </summary>
        [JsonProperty("at3x")]
        public string At3x { get; set; }
    }

    /// <summary>
    /// _1024x576 Content
    /// </summary>
    public class _1024x576
    {
        /// <summary>
        /// Returns the aspect ratio of the content <br/>
        /// Example: 16:9
        /// </summary>
        [JsonProperty("aspectRatio")]
        public string AspectRatio { get; set; }

        /// <summary>
        /// Returns the width of the content <br/>
        /// Example: 372
        /// </summary>
        [JsonProperty("width")]
        public int Width { get; set; }

        /// <summary>
        /// Returns the height of the content <br/>
        /// Example: 210
        /// </summary>
        [JsonProperty("height")]
        public int Height { get; set; }

        /// <summary>
        /// Returns the source of the content <br/>
        /// Example: https://cms.nhl.bamgrid.com/images/photos/329384462/320x180/cut.jpg
        /// </summary>
        [JsonProperty("src")]
        public string Src { get; set; }

        /// <summary>
        /// Returns the source of the content at 2x size<br/>
        /// Example: https://cms.nhl.bamgrid.com/images/photos/329384462/640x360/cut.jpg
        /// </summary>
        [JsonProperty("at2x")]
        public string At2x { get; set; }

        /// <summary>
        /// Returns the source of the content at 3x size<br/>
        /// Example: https://cms.nhl.bamgrid.com/images/photos/329384462/960x540/cut.jpg
        /// </summary>
        [JsonProperty("at3x")]
        public string At3x { get; set; }
    }

    /// <summary>
    /// 960x540 Content
    /// </summary>
    public class _960x540
    {
        /// <summary>
        /// Returns the aspect ratio of the content <br/>
        /// Example: 16:9
        /// </summary>
        [JsonProperty("aspectRatio")]
        public string AspectRatio { get; set; }

        /// <summary>
        /// Returns the width of the content <br/>
        /// Example: 372
        /// </summary>
        [JsonProperty("width")]
        public int Width { get; set; }

        /// <summary>
        /// Returns the height of the content <br/>
        /// Example: 210
        /// </summary>
        [JsonProperty("height")]
        public int Height { get; set; }

        /// <summary>
        /// Returns the source of the content <br/>
        /// Example: https://cms.nhl.bamgrid.com/images/photos/329384462/320x180/cut.jpg
        /// </summary>
        [JsonProperty("src")]
        public string Src { get; set; }

        /// <summary>
        /// Returns the source of the content at 2x size<br/>
        /// Example: https://cms.nhl.bamgrid.com/images/photos/329384462/640x360/cut.jpg
        /// </summary>
        [JsonProperty("at2x")]
        public string At2x { get; set; }

        /// <summary>
        /// Returns the source of the content at 3x size<br/>
        /// Example: https://cms.nhl.bamgrid.com/images/photos/329384462/960x540/cut.jpg
        /// </summary>
        [JsonProperty("at3x")]
        public string At3x { get; set; }
    }

    /// <summary>
    /// 768x432 Content
    /// </summary>
    public class _768x432
    {
        /// <summary>
        /// Returns the aspect ratio of the content <br/>
        /// Example: 16:9
        /// </summary>
        [JsonProperty("aspectRatio")]
        public string AspectRatio { get; set; }

        /// <summary>
        /// Returns the width of the content <br/>
        /// Example: 372
        /// </summary>
        [JsonProperty("width")]
        public int Width { get; set; }

        /// <summary>
        /// Returns the height of the content <br/>
        /// Example: 210
        /// </summary>
        [JsonProperty("height")]
        public int Height { get; set; }

        /// <summary>
        /// Returns the source of the content <br/>
        /// Example: https://cms.nhl.bamgrid.com/images/photos/329384462/320x180/cut.jpg
        /// </summary>
        [JsonProperty("src")]
        public string Src { get; set; }

        /// <summary>
        /// Returns the source of the content at 2x size<br/>
        /// Example: https://cms.nhl.bamgrid.com/images/photos/329384462/640x360/cut.jpg
        /// </summary>
        [JsonProperty("at2x")]
        public string At2x { get; set; }

        /// <summary>
        /// Returns the source of the content at 3x size<br/>
        /// Example: https://cms.nhl.bamgrid.com/images/photos/329384462/960x540/cut.jpg
        /// </summary>
        [JsonProperty("at3x")]
        public string At3x { get; set; }
    }

    /// <summary>
    /// 640x360 Content
    /// </summary>
    public class _640x360
    {
        /// <summary>
        /// Returns the aspect ratio of the content <br/>
        /// Example: 16:9
        /// </summary>
        [JsonProperty("aspectRatio")]
        public string AspectRatio { get; set; }

        /// <summary>
        /// Returns the width of the content <br/>
        /// Example: 372
        /// </summary>
        [JsonProperty("width")]
        public int Width { get; set; }

        /// <summary>
        /// Returns the height of the content <br/>
        /// Example: 210
        /// </summary>
        [JsonProperty("height")]
        public int Height { get; set; }

        /// <summary>
        /// Returns the source of the content <br/>
        /// Example: https://cms.nhl.bamgrid.com/images/photos/329384462/320x180/cut.jpg
        /// </summary>
        [JsonProperty("src")]
        public string Src { get; set; }

        /// <summary>
        /// Returns the source of the content at 2x size<br/>
        /// Example: https://cms.nhl.bamgrid.com/images/photos/329384462/640x360/cut.jpg
        /// </summary>
        [JsonProperty("at2x")]
        public string At2x { get; set; }

        /// <summary>
        /// Returns the source of the content at 3x size<br/>
        /// Example: https://cms.nhl.bamgrid.com/images/photos/329384462/960x540/cut.jpg
        /// </summary>
        [JsonProperty("at3x")]
        public string At3x { get; set; }
    }

    /// <summary>
    /// 568x320 Content
    /// </summary>
    public class _568x320
    {
        /// <summary>
        /// Returns the aspect ratio of the content <br/>
        /// Example: 16:9
        /// </summary>
        [JsonProperty("aspectRatio")]
        public string AspectRatio { get; set; }

        /// <summary>
        /// Returns the width of the content <br/>
        /// Example: 372
        /// </summary>
        [JsonProperty("width")]
        public int Width { get; set; }

        /// <summary>
        /// Returns the height of the content <br/>
        /// Example: 210
        /// </summary>
        [JsonProperty("height")]
        public int Height { get; set; }

        /// <summary>
        /// Returns the source of the content <br/>
        /// Example: https://cms.nhl.bamgrid.com/images/photos/329384462/320x180/cut.jpg
        /// </summary>
        [JsonProperty("src")]
        public string Src { get; set; }

        /// <summary>
        /// Returns the source of the content at 2x size<br/>
        /// Example: https://cms.nhl.bamgrid.com/images/photos/329384462/640x360/cut.jpg
        /// </summary>
        [JsonProperty("at2x")]
        public string At2x { get; set; }

        /// <summary>
        /// Returns the source of the content at 3x size<br/>
        /// Example: https://cms.nhl.bamgrid.com/images/photos/329384462/960x540/cut.jpg
        /// </summary>
        [JsonProperty("at3x")]
        public string At3x { get; set; }
    }

    /// <summary>
    /// 372x210 Content
    /// </summary>
    public class _372x210
    {
        /// <summary>
        /// Returns the aspect ratio of the content <br/>
        /// Example: 16:9
        /// </summary>
        [JsonProperty("aspectRatio")]
        public string AspectRatio { get; set; }

        /// <summary>
        /// Returns the width of the content <br/>
        /// Example: 372
        /// </summary>
        [JsonProperty("width")]
        public int Width { get; set; }

        /// <summary>
        /// Returns the height of the content <br/>
        /// Example: 210
        /// </summary>
        [JsonProperty("height")]
        public int Height { get; set; }

        /// <summary>
        /// Returns the source of the content <br/>
        /// Example: https://cms.nhl.bamgrid.com/images/photos/329384462/320x180/cut.jpg
        /// </summary>
        [JsonProperty("src")]
        public string Src { get; set; }

        /// <summary>
        /// Returns the source of the content at 2x size<br/>
        /// Example: https://cms.nhl.bamgrid.com/images/photos/329384462/640x360/cut.jpg
        /// </summary>
        [JsonProperty("at2x")]
        public string At2x { get; set; }

        /// <summary>
        /// Returns the source of the content at 3x size<br/>
        /// Example: https://cms.nhl.bamgrid.com/images/photos/329384462/960x540/cut.jpg
        /// </summary>
        [JsonProperty("at3x")]
        public string At3x { get; set; }
    }

    /// <summary>
    /// 320x180 Content
    /// </summary>
    public class _320x180
    {
        /// <summary>
        /// Returns the aspect ratio of the content <br/>
        /// Example: 16:9
        /// </summary>
        [JsonProperty("aspectRatio")]
        public string AspectRatio { get; set; }

        /// <summary>
        /// Returns the width of the content <br/>
        /// Example: 372
        /// </summary>
        [JsonProperty("width")]
        public int Width { get; set; }

        /// <summary>
        /// Returns the height of the content <br/>
        /// Example: 210
        /// </summary>
        [JsonProperty("height")]
        public int Height { get; set; }

        /// <summary>
        /// Returns the source of the content <br/>
        /// Example: https://cms.nhl.bamgrid.com/images/photos/329384462/320x180/cut.jpg
        /// </summary>
        [JsonProperty("src")]
        public string Src { get; set; }

        /// <summary>
        /// Returns the source of the content at 2x size<br/>
        /// Example: https://cms.nhl.bamgrid.com/images/photos/329384462/640x360/cut.jpg
        /// </summary>
        [JsonProperty("at2x")]
        public string At2x { get; set; }

        /// <summary>
        /// Returns the source of the content at 3x size<br/>
        /// Example: https://cms.nhl.bamgrid.com/images/photos/329384462/960x540/cut.jpg
        /// </summary>
        [JsonProperty("at3x")]
        public string At3x { get; set; }
    }

    /// <summary>
    /// 248x140 Content
    /// </summary>
    public class _248x140
    {
        /// <summary>
        /// Returns the aspect ratio of the content <br/>
        /// Example: 16:9
        /// </summary>
        [JsonProperty("aspectRatio")]
        public string AspectRatio { get; set; }

        /// <summary>
        /// Returns the width of the content <br/>
        /// Example: 372
        /// </summary>
        [JsonProperty("width")]
        public int Width { get; set; }

        /// <summary>
        /// Returns the height of the content <br/>
        /// Example: 210
        /// </summary>
        [JsonProperty("height")]
        public int Height { get; set; }

        /// <summary>
        /// Returns the source of the content <br/>
        /// Example: https://cms.nhl.bamgrid.com/images/photos/329384462/320x180/cut.jpg
        /// </summary>
        [JsonProperty("src")]
        public string Src { get; set; }

        /// <summary>
        /// Returns the source of the content at 2x size<br/>
        /// Example: https://cms.nhl.bamgrid.com/images/photos/329384462/640x360/cut.jpg
        /// </summary>
        [JsonProperty("at2x")]
        public string At2x { get; set; }

        /// <summary>
        /// Returns the source of the content at 3x size<br/>
        /// Example: https://cms.nhl.bamgrid.com/images/photos/329384462/960x540/cut.jpg
        /// </summary>
        [JsonProperty("at3x")]
        public string At3x { get; set; }
    }


    /// <summary>
    /// Editorial Preview Token Data
    /// </summary>
    public class EditorialPreviewTokenData
    {
        /// <summary>
        /// Returns the token GUID for the preview data for the editorial <br/>
        /// Example: token-7D7621C5A6FB9C2781994
        /// </summary>
        [JsonProperty("tokenGUID")]
        public string TokenGUID { get; set; }

        /// <summary>
        /// Returns the type for the preview data for the editorial <br/>
        /// Example: playerCard
        /// </summary>
        [JsonProperty("type")]
        public string Type { get; set; }

        /// <summary>
        /// Returns the identifier of the preview data, such as NHL player identifier <br/>
        /// Example: 8475236
        /// </summary>
        [JsonProperty("id")]
        public string Id { get; set; }

        /// <summary>
        /// Returns the identifier of the NHL team identifier <br/>
        /// Example: 7
        /// </summary>
        [JsonProperty("teamId")]
        public string TeamId { get; set; }

        /// <summary>
        /// Returns the position of the NHL player <br/>
        /// Example: Center
        /// </summary>
        [JsonProperty("position")]
        public string Position { get; set; }

        /// <summary>
        /// Returns the first and last name of the NHL player <br/>
        /// Example: Cody Eakin
        /// </summary>
        [JsonProperty("name")]
        public string Name { get; set; }

        /// <summary>
        /// Returns the SEO friendly NHL player first and last name <br/>
        /// Example: cody-eakin
        /// </summary>
        [JsonProperty("seoName")]
        public string SeoName { get; set; }

        /// <summary>
        /// Returns the hyper link reference of the NHL video content if the type is video <br/>
        /// Example: <a href="https://www.nhl.com/video/c-10065853">https://www.nhl.com/video/c-10065853</a>
        /// </summary>
        [JsonProperty("href")]
        public string Href { get; set; }

        /// <summary>
        /// Returns the mobile hyper link reference of the NHL video content if the type is video <br/>
        /// Example: <a href="https://www.nhl.com/video/c-10065853">https://www.nhl.com/video/c-10065853</a>
        /// </summary>
        [JsonProperty("hrefMobile")]
        public string HrefMobile { get; set; }
    }

    /// <summary>
    /// NHL content contributor
    /// </summary>
    public class Contributor
    {
        /// <summary>
        /// Returns a collection of contributors <br/>
        /// Example: {  "name" : "Patrick Donnelly",  "twitter" : "" }
        /// </summary>
        [JsonProperty("contributors")]
        public List<ContributorInformation> Contributors { get; set; }

        /// <summary>
        /// Returns the source of the contributor <br/>
        /// Example: NHL.com Independent Correspondent
        /// </summary>
        [JsonProperty("source")]
        public string Source { get; set; }
    }


    /// <summary>
    /// Keywords Display
    /// </summary>
    public class KeywordsDisplay
    {
        /// <summary>
        /// Returns the type of the keywords type <br/>
        /// Example: language
        /// </summary>
        [JsonProperty("type")]
        public string Type { get; set; }

        /// <summary>
        /// Returns the value of the language <br/>
        /// Example: en
        /// </summary>
        [JsonProperty("value")]
        public string Value { get; set; }

        /// <summary>
        /// Returns the value of the display name <br/>
        /// Example: English
        /// </summary>
        [JsonProperty("displayName")]
        public string DisplayName { get; set; }
    }

    /// <summary>
    /// Keywords All 
    /// </summary>
    public class KeywordsAll
    {

        /// <summary>
        /// Returns the type of all the keywords <br/>
        /// Example: primaryTag
        /// </summary>
        [JsonProperty("type")]
        public string Type { get; set; }

        /// <summary>
        /// Returns the value of all the keywords <br/>
        /// Example: content|gamePreview
        /// </summary>
        [JsonProperty("value")]
        public string Value { get; set; }

        /// <summary>
        /// Returns the display name of all the keywords <br/>
        /// Example: game preview
        /// </summary>
        [JsonProperty("displayName")]
        public string DisplayName { get; set; }
    }

    /// <summary>
    /// Primary Keyword
    /// </summary>
    public class PrimaryKeyword
    {

        /// <summary>
        /// Returns the type of all the primary keywords <br/>
        /// Example: content
        /// </summary>
        [JsonProperty("type")]
        public string Type { get; set; }

        /// <summary>
        /// Returns the value of all the primary keywords <br/>
        /// Example: gamePreview
        /// </summary>
        [JsonProperty("value")]
        public string Value { get; set; }

        /// <summary>
        /// Returns the display name of all the primary keywords <br/>
        /// Example: game preview
        /// </summary>
        [JsonProperty("displayName")]
        public string DisplayName { get; set; }
    }

    /// <summary>
    /// Editorial Item
    /// </summary>
    public class EditorialItem
    {
        /// <summary>
        /// The type of the item for the editorial item <br/>
        /// Example: article
        /// </summary>
        [JsonProperty("type")]
        public string Type { get; set; }

        /// <summary>
        /// The type of the state for the editorial item <br/>
        /// Example: A
        /// </summary>
        [JsonProperty("state")]
        public string State { get; set; }

        /// <summary>
        /// The date for the editorial item <br/>
        /// Example: 2022-01-01T17:53:24-0500
        /// </summary>
        [JsonProperty("date")]
        public DateTime Date { get; set; }

        /// <summary>
        /// The identifier for the editorial item <br/>
        /// Example: 329233048
        /// </summary>
        [JsonProperty("id")]
        public string Id { get; set; }

        /// <summary>
        /// The headline of the content item <br/>
        /// Example: Avalanche rally to defeat Ducks after 16-day break
        /// </summary>
        [JsonProperty("headline")]
        public string Headline { get; set; }

        /// <summary>
        /// The sub head of the content item <br/>
        /// Example: O'Connor scores winner with 1:11 left, Landeskog gets goal in return from injury
        /// </summary>
        [JsonProperty("subhead")]
        public string Subhead { get; set; }

        /// <summary>
        /// The SEO title of the content item <br/>
        /// Example: Anaheim Ducks Colorado Avalanche game recap
        /// </summary>
        [JsonProperty("seoTitle")]
        public string SeoTitle { get; set; }

        /// <summary>
        /// The SEO description of the content item <br/>
        /// Example: Logan O'Connor scored with 1:11 left in the third period for the Colorado Avalanche, who rallied for a 4-2 win against the Anaheim Ducks at Ball Arena on Sunday.
        /// </summary>
        [JsonProperty("seoDescription")]
        public string SeoDescription { get; set; }

        /// <summary>
        /// The SEO keywords of the content item <br/>
        /// Example: Anaheim Ducks, Colorado Avalanche, game recap, NHL, hockey, news
        /// </summary>
        [JsonProperty("seoKeywords")]
        public string SeoKeywords { get; set; }

        /// <summary>
        /// The slug for the content item <br/>
        /// Example: Anaheim Ducks, Colorado Avalanche, game recap, NHL, hockey, news
        /// </summary>
        [JsonProperty("slug")]
        public string Slug { get; set; }

        /// <summary>
        /// The boolean value if commenting is available
        /// </summary>
        [JsonProperty("commenting")]
        public bool Commenting { get; set; }

        /// <summary>
        /// The tag line for the content item <br/>
        /// Example: O'Connor scores winner with 1:11 left, Landeskog gets goal in return from injury
        /// </summary>
        [JsonProperty("tagline")]
        public string Tagline { get; set; }

        /// <summary>
        /// Returns the contributor for the editorial preview
        /// </summary>
        [JsonProperty("contributor")]
        public Contributor Contributor { get; set; }

        /// <summary>
        /// The collection of token data for all of the items related to the editorial content item
        /// </summary>
        [JsonProperty("tokenData")]
        public Dictionary<string, EditorialPreviewTokenData> TokenData { get; set; }

        /// <summary>
        /// A collection of keywords display
        /// </summary>
        [JsonProperty("keywordsDisplay")]
        public List<KeywordsDisplay> KeywordsDisplay { get; set; }

        /// <summary>
        /// A collection of all keywords
        /// </summary>
        [JsonProperty("keywordsAll")]
        public List<KeywordsAll> KeywordsAll { get; set; }

        /// <summary>
        /// The content item approval
        /// </summary>
        [JsonProperty("approval")]
        public string Approval { get; set; }

        /// <summary>
        /// The URL to the content item <br/>
        /// Example: /news/anaheim-ducks-colorado-avalanche-game-recap/c-329232864?game_pk=2021020580
        /// </summary>
        [JsonProperty("url")]
        public string Url { get; set; }

        /// <summary>
        /// The data URI <br/>
        /// Example: /nhl/id/v1/329232864/details/web-v1.json
        /// </summary>
        [JsonProperty("dataURI")]
        public string DataURI { get; set; }

        /// <summary>
        /// The content item object primary key word <br/>
        /// </summary>
        [JsonProperty("primaryKeyword")]
        public PrimaryKeyword PrimaryKeyword { get; set; }

        /// <summary>
        /// The share image of content item
        /// </summary>
        [JsonProperty("shareImage")]
        public string ShareImage { get; set; }

        /// <summary>
        /// Returns a collection of media for the content item
        /// </summary>
        [JsonProperty("media")]
        public Media Media { get; set; }

        /// <summary>
        /// Returns the preview headline for the content item <br/>
        /// Example: DENVER -- Logan O'Connor scored to break a tie with 1:11 left in the third period for the Colorado Avalanche, who rallied for a 4-2 win against the Anaheim Ducks at Ball Arena on Sunday.
        /// </summary>
        [JsonProperty("preview")]
        public string Preview { get; set; }
    }

    /// <summary>
    /// Milestone Item
    /// </summary>
    public class MilestoneItem
    {
        /// <summary>
        /// Returns the title of the milestone within the NHL game <br/>
        /// Example: Broadcast Start
        /// </summary>
        [JsonProperty("title")]
        public string Title { get; set; }

        /// <summary>
        /// Returns the description of the milestone within the NHL game <br/>
        /// Example: Broadcast Start
        /// </summary>
        [JsonProperty("description")]
        public string Description { get; set; }

        /// <summary>
        /// Returns the type of the milestone within the NHL game <br/>
        /// Example: PERIOD_START
        /// </summary>
        [JsonProperty("type")]
        public string Type { get; set; }

        /// <summary>
        /// Returns the date and time the milestone within the NHL game <br/>
        /// Example: 2022-01-01T18:08:02+0000
        /// </summary>
        [JsonProperty("timeAbsolute")]
        public DateTime TimeAbsolute { get; set; }

        /// <summary>
        /// Returns the offset of time for the milestone within the NHL game <br/>
        /// Example: 472
        /// </summary>
        [JsonProperty("timeOffset")]
        public string TimeOffset { get; set; }

        /// <summary>
        /// Returns the numeric value of the period <br/>
        /// Example: 1
        /// </summary>
        [JsonProperty("period")]
        public string Period { get; set; }

        /// <summary>
        /// Returns the statistics event identifier <br/>
        /// Example: 76
        /// </summary>
        [JsonProperty("statsEventId")]
        public string StatsEventId { get; set; }

        /// <summary>
        /// Returns the team identifier <br/>
        /// Example: 7
        /// </summary>
        [JsonProperty("teamId")]
        public string TeamId { get; set; }

        /// <summary>
        /// Returns the player identifier <br/>
        /// Example: 8476994
        /// </summary>
        [JsonProperty("playerId")]
        public string PlayerId { get; set; }

        /// <summary>
        /// Returns the time of the period <br/>
        /// Example: 06:33
        /// </summary>
        [JsonProperty("periodTime")]
        public string PeriodTime { get; set; }

        /// <summary>
        /// Returns the ordinal number of the period <br/>
        /// Example: 1st
        /// </summary>
        [JsonProperty("ordinalNum")]
        public string OrdinalNum { get; set; }

        /// <summary>
        /// Returns specific information about the highlight, this includes a title, blurb, description etc.
        /// </summary>
        [JsonProperty("highlight")]
        public Highlight Highlight { get; set; }
    }

    /// <summary>
    /// HighlightItem
    /// </summary>
    public class HighlightItem
    {
        /// <summary>
        /// Returns the type of the highlight item <br/>
        /// Example: video
        /// </summary>
        [JsonProperty("type")]
        public string Type { get; set; }

        /// <summary>
        /// Returns the identifier of the highlight item <br/>
        /// Example: 10064942
        /// </summary>
        [JsonProperty("id")]
        public string Id { get; set; }

        /// <summary>
        /// Returns the date of the highlight item <br/>
        /// Example: 2022-01-01T13:00:00-0500
        /// </summary>
        [JsonProperty("date")]
        public DateTime? Date { get; set; }

        /// <summary>
        /// Returns the title of the highlight item <br/>
        /// Example: Hinostroza pots opening goal
        /// </summary>
        [JsonProperty("title")]
        public string Title { get; set; }

        /// <summary>
        /// Returns the blurb of the highlight item <br/>
        /// Example: BUF@BOS: Hinostroza kicks off scoring for Sabres
        /// </summary>
        [JsonProperty("blurb")]
        public string Blurb { get; set; }

        /// <summary>
        /// Returns the description of the highlight item <br/>
        /// Example: The Sabres cycle the puck in the offensive zone, allowing Vinnie Hinostroza to get...
        /// </summary>
        [JsonProperty("description")]
        public string Description { get; set; }

        /// <summary>
        /// Returns true or false if the authorization flow is required
        /// </summary>
        [JsonProperty("authFlow")]
        public bool? AuthFlow { get; set; }

        /// <summary>
        /// Returns the media playback identifier <br/>
        /// Example: 10064942
        /// </summary>
        [JsonProperty("mediaPlaybackId")]
        public string MediaPlaybackId { get; set; }

        /// <summary>
        /// Returns the media state for the highlight <br/>
        /// Example: MEDIA_ARCHIVE
        /// </summary>
        [JsonProperty("mediaState")]
        public string MediaState { get; set; }

        /// <summary>
        /// Returns a collection of keywords associated with the highlight
        /// </summary>
        [JsonProperty("keywords")]
        public List<Keyword> Keywords { get; set; }

        /// <summary>
        /// Returns an image associated with the highlight in various sizes and aspect ratios
        /// </summary>
        [JsonProperty("image")]
        public Image Image { get; set; }

        /// <summary>
        /// Returns values of all the video playbacks of the highlight in different formats
        /// </summary>
        [JsonProperty("playbacks")]
        public List<Playback> Playbacks { get; set; }
    }

    /// <summary>
    /// Epg Item
    /// </summary>
    public class EpgItem
    {
        /// <summary>
        /// Returns the GUID for the electronic program guide item <br/>
        /// Example: 8a80df41-5808-4b7c-bc80-0390ce2d75b0
        /// </summary>
        [JsonProperty("guid")]
        public string Guid { get; set; }

        /// <summary>
        /// Returns the media state for the electronic program guide item <br/>
        /// Example: MEDIA_ARCHIVE
        /// </summary>
        [JsonProperty("mediaState")]
        public string MediaState { get; set; }

        /// <summary>
        /// Returns the media playback identifier for the electronic program guide item <br/>
        /// Example: 2026745631
        /// </summary>
        [JsonProperty("mediaPlaybackId")]
        public string MediaPlaybackId { get; set; }

        /// <summary>
        /// Returns the media feed type for the electronic program guide item <br/>
        /// Example: HOME
        /// </summary>
        [JsonProperty("mediaFeedType")]
        public string MediaFeedType { get; set; }

        /// <summary>
        /// Returns the call letters for the electronic program guide item <br/>
        /// Example: NESN
        /// </summary>
        [JsonProperty("callLetters")]
        public string CallLetters { get; set; }

        /// <summary>
        /// Returns the event identifier for the electronic program guide item <br/>
        /// Example: 221-3001877
        /// </summary>
        [JsonProperty("eventId")]
        public string EventId { get; set; }

        /// <summary>
        /// Returns the language for the electronic program guide item <br/>
        /// Example: eng
        /// </summary>
        [JsonProperty("language")]
        public string Language { get; set; }

        /// <summary>
        /// Returns the true or false if it is a free game for the electronic program guide item
        /// </summary>
        [JsonProperty("freeGame")]
        public bool FreeGame { get; set; }

        /// <summary>
        /// Returns the feed name if it is available for the electronic program guide item <br/>
        /// Example: Unavailable
        /// </summary>
        [JsonProperty("feedName")]
        public string FeedName { get; set; }

        /// <summary>
        /// Returns true or false if it is game plus for the electronic program guide item
        /// </summary>
        [JsonProperty("gamePlus")]
        public bool GamePlus { get; set; }

    }
}
