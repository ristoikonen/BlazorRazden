﻿using System.Text.Json.Serialization;

namespace BlazorRazden.App.Models
{
    public class CoinModel
    {
        [JsonPropertyName("id")]
        public string? Id { get; set; }

        [JsonPropertyName("symbol")]
        public string? Symbol { get; set; }

        [JsonPropertyName("name")]
        public string? Name { get; set; }

        [JsonPropertyName("nameid")]
        public string? NameId { get; set; }

        [JsonPropertyName("rank")]
        public double Rank { get; set; }

        [JsonPropertyName("price_usd")]
        public string? Price_usd { get; set; }

        [JsonPropertyName("percent_change_24h")]
        public string? percent_change_24h { get; set; }

        [JsonPropertyName("percent_change_1h")]
        public string? Percent_change_1h { get; set; }

        [JsonPropertyName("percent_change_7d")]
        public string? Percent_change_7d { get; set; }

        [JsonPropertyName("price_btc")]
        public string? Price_btc { get; set; }

        [JsonPropertyName("market_cap_usd")]
        public string? Market_cap_usd { get; set; }

        [JsonPropertyName("volume24")]
        public double Volume24 { get; set; }

        [JsonPropertyName("volume24a")]
        public double? Volume24a { get; set; }

        [JsonPropertyName("csupply")]
        public string? Csupply { get; set; }

        [JsonPropertyName("tsupply")]
        public string? Tsupply { get; set; }

        [JsonPropertyName("msupply")]
        public string? Msupply { get; set; }

    }
}
