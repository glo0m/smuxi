﻿#if JABBR_SERVER
namespace Smuxi.Engine.JabbR
{
    public class ClientNotification
    {
        public string Room { get; set; }
        public string ImageUrl { get; set; }
        public string Source { get; set; }
        public string Content { get; set; }
    }
}
#endif