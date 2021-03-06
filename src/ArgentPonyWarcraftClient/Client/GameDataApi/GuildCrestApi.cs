﻿using System.Threading.Tasks;

namespace ArgentPonyWarcraftClient
{
    public partial class WarcraftClient
    {
        /// <inheritdoc />
        public async Task<RequestResult<GuildCrestComponentsIndex>> GetGuildCrestComponentsIndexAsync(string @namespace)
        {
            return await GetGuildCrestComponentsIndexAsync(@namespace, _region, _locale);
        }

        /// <inheritdoc />
        public async Task<RequestResult<GuildCrestComponentsIndex>> GetGuildCrestComponentsIndexAsync(string @namespace, Region region, Locale locale)
        {
            string host = GetHost(region);
            return await Get<GuildCrestComponentsIndex>(region, $"{host}/data/wow/guild-crest/index?namespace={@namespace}&locale={locale}");
        }

        /// <inheritdoc />
        public async Task<RequestResult<GuildCrestBorderMedia>> GetGuildCrestBorderMediaAsync(int borderId, string @namespace)
        {
            return await GetGuildCrestBorderMediaAsync(borderId, @namespace, _region, _locale);
        }

        /// <inheritdoc />
        public async Task<RequestResult<GuildCrestBorderMedia>> GetGuildCrestBorderMediaAsync(int borderId, string @namespace, Region region, Locale locale)
        {
            string host = GetHost(region);
            return await Get<GuildCrestBorderMedia>(region, $"{host}/data/wow/media/guild-crest/border/{borderId}?namespace={@namespace}&locale={locale}");
        }

        /// <inheritdoc />
        public async Task<RequestResult<GuildCrestEmblemMedia>> GetGuildCrestEmblemMediaAsync(int emblemId, string @namespace)
        {
            return await GetGuildCrestEmblemMediaAsync(emblemId, @namespace, _region, _locale);
        }

        /// <inheritdoc />
        public async Task<RequestResult<GuildCrestEmblemMedia>> GetGuildCrestEmblemMediaAsync(int emblemId, string @namespace, Region region, Locale locale)
        {
            string host = GetHost(region);
            return await Get<GuildCrestEmblemMedia>(region, $"{host}/data/wow/media/guild-crest/emblem/{emblemId}?namespace={@namespace}&locale={locale}");
        }
    }
}
