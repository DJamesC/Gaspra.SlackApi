﻿using Newtonsoft.Json;

namespace Gaspra.SlackApi.Models.MessageBlocks
{
    public class SlackMessageBlockMarkdown : ISlackMessageBlock
    {
        [JsonProperty("type")]
        protected string Type { get; } = "section";

        [JsonProperty("text")]
        public SlackMessageBlockMarkdownContent Content { get; set; }
    }
}
