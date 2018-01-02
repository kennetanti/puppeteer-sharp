﻿using System.Collections.Generic;
using System.Net;

namespace PuppeteerSharp
{
    public class MessageEventArgs
    {
        public string MessageID { get; set; }
        public TargetInfo TargetInfo { get; set; }
        public bool AuthChallenge { get; internal set; }
        public string InterceptionId { get; internal set; }
        public string RedirectUrl { get; internal set; }
        public HttpStatusCode ResponseStatusCode { get; internal set; }
        public Dictionary<string, object> ResponseHeaders { get; internal set; }
        public string ResourceType { get; internal set; }
        public RequestData Request { get; internal set; }
    }
}