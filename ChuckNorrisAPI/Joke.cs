using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace ChuckNorrisAPI
{
    public class Joke
    {
        [JsonProperty("id")]
        public int Id { get; set; }

        [JsonProperty("joke")]
        public string JokeText { get; set; }

        [JsonProperty("categories")]
        public IEnumerable<string> Categories { get; set; }
    }
}
