﻿using Newtonsoft.Json;

namespace ArgentPonyWarcraftClient
{
    /// <summary>
    /// A party member for a Mythic Keystone dungeon.
    /// </summary>
    public class MythicKeystonePartyMember
    {
        /// <summary>
        /// Gets details about the character.
        /// </summary>
        [JsonProperty("character")]
        public MemberCharacter Character { get; set; }

        /// <summary>
        /// Gets a reference to the specialization of the character.
        /// </summary>
        [JsonProperty("specialization")]
        public PlayableSpecializationReference Specialization { get; set; }

        /// <summary>
        /// Gets a reference to the race of the character.
        /// </summary>
        [JsonProperty("race")]
        public PlayableRaceReference Race { get; set; }

        /// <summary>
        /// Gets the equipped item level of the character.
        /// </summary>
        [JsonProperty("equipped_item_level")]
        public long EquippedItemLevel { get; set; }
    }
}
