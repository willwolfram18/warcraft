﻿using Newtonsoft.Json;

namespace ArgentPonyWarcraftClient
{
    /// <summary>
    /// An azerite essence.
    /// </summary>
    public class AzeriteEssence
    {
        /// <summary>
        /// Gets links for the azerite essence.
        /// </summary>
        [JsonProperty("_links")]
        public Links Links { get; set; }

        /// <summary>
        /// Gets the ID of the azerite essence.
        /// </summary>
        [JsonProperty("id")]
        public long Id { get; set; }

        /// <summary>
        /// Gets the name of the azerite essence.
        /// </summary>
        [JsonProperty("name")]
        public string Name { get; set; }

        /// <summary>
        /// Gets references to the allowed specializations for the azerite essence.
        /// </summary>
        [JsonProperty("allowed_specializations")]
        public PlayableSpecializationReference[] AllowedSpecializations { get; set; }

        /// <summary>
        /// Gets the powers for the azerite essence.
        /// </summary>
        [JsonProperty("powers")]
        public Power[] Powers { get; set; }

        /// <summary>
        /// Gets the media associated with the azerite essence.
        /// </summary>
        [JsonProperty("media")]
        public Media Media { get; set; }
    }
}
