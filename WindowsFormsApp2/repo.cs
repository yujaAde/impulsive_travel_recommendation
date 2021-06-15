using System;
using System.Text.Json.Serialization;
using System.Collections.Generic;

namespace ImpsvRcmd
{
    public class Repository
    {
        [JsonPropertyName("name")]
        public string Name {get; set;}

        [JsonPropertyName("description")]
        public string Description {get; set;}

        [JsonPropertyName("html_url")]
        public Uri GitHubHomeUrl {get; set;}

        [JsonPropertyName("homepage")]
        public Uri Homepage {get; set;}

        [JsonPropertyName("watchers")]
        public int Watchers {get; set;}

        
        [JsonPropertyName("pushed_at")]
        public DateTime LastPushUtc {get; set;}
        
        public DateTime LastPush => LastPushUtc.ToLocalTime();
    }

   
    public class touristAttraction
    {
        [JsonPropertyName("id")]
        public string id {get; set;}

        [JsonPropertyName("place_name")]
        public string place_name {get; set;}

        [JsonPropertyName("category_name")]
        public string category_name {get; set;}

        [JsonPropertyName("category_group_code")]
        public string category_group_code {get; set;}

        [JsonPropertyName("category_group_name")]
        public string category_group_name {get; set;}

        [JsonPropertyName("phone")]
        public string phone {get; set;}

        [JsonPropertyName("address_name")]
        public string address_name {get; set;}

        [JsonPropertyName("road_address_name")]
        public string road_address_name {get; set;}

        [JsonPropertyName("x")]
        public string x {get; set;}

        [JsonPropertyName("y")]
        public string y {get; set;}

        [JsonPropertyName("place_url")]
        public string place_url {get; set;}

        [JsonPropertyName("distance")]
        public string distance {get; set;}
    }
    public class ta_docs
    {
        [JsonPropertyName("documents")]
        public List<touristAttraction> touristAttractions {get; set;}
    }

    public class region
    {
        [JsonPropertyName("address_name")]
        public string address_name {get; set;}

        [JsonPropertyName("region_type")]   // H(행정동) OR B(법정동)
        public string region_type {get; set;}
        
        [JsonPropertyName("region_1depth_name")]    // 시, 도
        public string region_1depth_name {get; set;}
        
        [JsonPropertyName("region_2depth_name")]    // 구
        public string region_2depth_name {get; set;}

        [JsonPropertyName("region_3depth_name")]    // 동
        public string region_3depth_name {get; set;}

        [JsonPropertyName("region_4depth_name")]    // 법정동이면서 '리'인 경우 존재
        public string region_4depth_name {get; set;}

        [JsonPropertyName("code")]
        public string code {get; set;}

        [JsonPropertyName("x")]
        public double x {get; set;}

        [JsonPropertyName("y")]
        public double y {get; set;}
    }

    public class c2r_docs
    {
        [JsonPropertyName("documents")]
        public List<region> c2r {get; set;}
    }
}