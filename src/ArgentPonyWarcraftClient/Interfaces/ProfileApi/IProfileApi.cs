﻿namespace ArgentPonyWarcraftClient
{
    /// <summary>
    ///     A client for the World of Warcraft Profile APIs.
    /// </summary>
    public interface IProfileApi :
        IAccountProfileApi,
        ICharacterAchievementsApi,
        ICharacterAppearanceApi,
        ICharacterCollectionsApi,
        ICharacterEncountersApi,
        ICharacterEquipmentApi,
        ICharacterHunterPetsApi,
        ICharacterMythicKeystoneProfileApi,
        ICharacterProfessionsApi,
        ICharacterProfileApi,
        ICharacterPvpApi,
        ICharacterQuestsApi,
        ICharacterReputationsApi,
        ICharacterSpecializationsApi,
        ICharacterStatisticsApi,
        ICharacterTitlesApi,
        IGuildApi
    {
    }
}
