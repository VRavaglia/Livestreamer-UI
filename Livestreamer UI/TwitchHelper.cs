using System;
using System.Net;
using System.Collections.Generic;
using Newtonsoft.Json.Linq;


namespace Livestreamer_UI
{
    public class TwitchHelper
    {
        private WebClient wc = new WebClient();

        public delegate void AreOnlineCallbackHandler(object sender, AreOnlineCallbackEventArgs e);
        public event AreOnlineCallbackHandler Callback;

        public TwitchHelper()
        {
            this.wc.DownloadStringCompleted += DownloadStringCompleted;
        }

        private void DownloadStringCompleted(object sender, DownloadStringCompletedEventArgs e)
        {
            if (!e.Cancelled && e.Error == null)
            {
                var onlineStreams = new List<string>();

                string retStr = e.Result;

                dynamic json = JValue.Parse(retStr);

                foreach (dynamic stream in json.streams)
                {
                    onlineStreams.Add((string)stream.channel.name);
                }
                Callback(this, new AreOnlineCallbackEventArgs(onlineStreams.ToArray()));
            }
        }

        public void AreOnline(string[] streams)
        {
            wc.DownloadStringAsync(new Uri("https://api.twitch.tv/kraken/streams?stream_type=live&channel=" + String.Join(",", streams)));
        }

        public class AreOnlineCallbackEventArgs : EventArgs
        {
            public string[] Streams { get; internal set; }

            public AreOnlineCallbackEventArgs(string[] streams)
            {
                this.Streams = streams;
            }
        }
    }
}
