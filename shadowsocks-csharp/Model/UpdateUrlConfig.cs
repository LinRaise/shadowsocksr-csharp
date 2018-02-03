using System;

namespace Shadowsocks.Model
{
    /*
     * Data for update 
     */

    [Serializable]
    public class UpdateUrlConfig
    {
        /// <summary>
        /// //"https://raw.githubusercontent.com/gfwlist/gfwlist/master/gfwlist.txt";
        /// </summary>
        public string GFWLIST_URL = null;
        /// <summary>
        /// // "https://raw.githubusercontent.com/breakwa11/breakwa11.github.io/master/ssr/gfwlist.txt";
        /// </summary>
        public string GFWLIST_BACKUP_URL = null;
        /// <summary>
        /// // "https://raw.githubusercontent.com/breakwa11/breakwa11.github.io/master/ssr/ss_gfw.pac";
        /// </summary>
        public string GFWLIST_TEMPLATE_URL = null;
        /// <summary>
        /// // "https://raw.githubusercontent.com/breakwa11/breakwa11.github.io/master/update/ssr-win-4.0.xml";
        /// </summary>
        public string UpdateNodeURL = null;
        /// <summary>
        /// // "https://raw.githubusercontent.com/breakwa11/breakwa11.github.io/master/free/freenodeplain.txt";
        /// </summary>
        public string DEFAULT_FEED_URL = null;
        /// <summary>
        /// // "https://github.com/breakwa11/shadowsocks-rss/wiki";
        /// </summary>
        public string WikiURL = null;
        /// <summary>
        /// // "https://github.com/shadowsocksr/shadowsocksr-csharp/issues/new";
        /// </summary>
        public string FeedbackURL = null;
        /// <summary>
        /// // "https://breakwa11.github.io";
        /// </summary>
        public string ProjectURL = null;
        /// <summary>
        /// // "https://raw.githubusercontent.com/breakwa11/breakwa11.github.io/master/ssr/ss_lanip.pac";
        /// </summary>
        public string PACFromLanIPListURL = null;
        /// <summary>
        /// // "https://raw.githubusercontent.com/breakwa11/breakwa11.github.io/master/ssr/ss_white.pac";
        /// </summary>
        public string PACFromCNWhiteListURL = null;
        /// <summary>
        /// // "https://raw.githubusercontent.com/breakwa11/breakwa11.github.io/master/ssr/ss_white_r.pac";
        /// </summary>
        public string PACFromCNOnlyListURL = null;
        /// <summary>
        /// // "https://raw.githubusercontent.com/breakwa11/breakwa11.github.io/master/ssr/ss_cnip.pac";
        /// </summary>
        public string PACFromCNIPListURL = null;

        public UpdateUrlConfig()
        {
            GFWLIST_URL = "https://raw.githubusercontent.com/gfwlist/gfwlist/master/gfwlist.txt";
            GFWLIST_BACKUP_URL = "https://raw.githubusercontent.com/shadowsocksrr/breakwa11.github.io/master/ssr/gfwlist.txt";
            GFWLIST_TEMPLATE_URL = "https://raw.githubusercontent.com/shadowsocksrr/breakwa11.github.io/master/ssr/ss_gfw.pac";
            UpdateNodeURL = "https://raw.githubusercontent.com/shadowsocksrr/breakwa11.github.io/master/update/ssr-win-4.0.xml";
            DEFAULT_FEED_URL = "https://raw.githubusercontent.com/shadowsocksrr/breakwa11.github.io/master/free/freenodeplain.txt";
            WikiURL = "https://github.com/shadowsocksrr/shadowsocks-rss/wiki";
            FeedbackURL = "https://github.com/shadowsocksr/shadowsocksr-csharp/issues/new";
            ProjectURL = "https://breakwa11.github.io";
            PACFromLanIPListURL = "https://raw.githubusercontent.com/shadowsocksrr/breakwa11.github.io/master/ssr/ss_lanip.pac";
            PACFromCNWhiteListURL = "https://raw.githubusercontent.com/shadowsocksrr/breakwa11.github.io/master/ssr/ss_white.pac";
            PACFromCNOnlyListURL = "https://raw.githubusercontent.com/shadowsocksrr/breakwa11.github.io/master/ssr/ss_white_r.pac";
            PACFromCNIPListURL = "https://raw.githubusercontent.com/shadowsocksrr/breakwa11.github.io/master/ssr/ss_cnip.pac";
        }
    }
}