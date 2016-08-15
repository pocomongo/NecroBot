using System.Collections.Generic;
using System.ComponentModel;
using AutoMapper;
using PoGo.NecroBot.Logic;
using POGOProtos.Enums;
using POGOProtos.Inventory.Item;
using ReactiveUI;
using ReactiveUI.Fody.Helpers;

namespace Necrui
{
    public class GlobalSettingsProxy : ReactiveObject
    {
        public GlobalSettingsProxy(GlobalSettings settings)
        {
            Mapper.Map(settings, this);
        }

        [DefaultValue("en")]
        [LocalizedDisplayName(nameof(TranslationLanguageCode), typeof(GlobalSettingsRes))]
        [LocalizedDescription(nameof(TranslationLanguageCode), typeof(GlobalSettingsDescRes))]
        [Reactive]
        public string TranslationLanguageCode { get; set; }

        [DefaultValue(true)]
        [LocalizedDisplayName(nameof(AutoUpdate), typeof(GlobalSettingsRes))]
        [LocalizedDescription(nameof(AutoUpdate), typeof(GlobalSettingsDescRes))]
        [Reactive]
        public bool AutoUpdate { get; set; }

        [DefaultValue(true)]
        [LocalizedDisplayName(nameof(TransferConfigAndAuthOnUpdate), typeof(GlobalSettingsRes))]
        [LocalizedDescription(nameof(TransferConfigAndAuthOnUpdate), typeof(GlobalSettingsDescRes))]
        [Reactive]
        public bool TransferConfigAndAuthOnUpdate { get; set; }

        [DefaultValue(false)]
        [LocalizedDisplayName(nameof(UseWebsocket), typeof(GlobalSettingsRes))]
        [LocalizedDescription(nameof(UseWebsocket), typeof(GlobalSettingsDescRes))]
        [Reactive]
        public bool UseWebsocket { get; set; }

        [DefaultValue(14251)]
        [LocalizedDisplayName(nameof(WebSocketPort), typeof(GlobalSettingsRes))]
        [LocalizedDescription(nameof(WebSocketPort), typeof(GlobalSettingsDescRes))]
        [Reactive]
        public int WebSocketPort { get; set; }

        //pressakeyshit
        [DefaultValue(false)]
        [LocalizedDisplayName(nameof(StartupWelcomeDelay), typeof(GlobalSettingsRes))]
        [LocalizedDescription(nameof(StartupWelcomeDelay), typeof(GlobalSettingsDescRes))]
        [Reactive]
        public bool StartupWelcomeDelay { get; set; }

        //Telegram
        [DefaultValue(false)]
        [LocalizedDisplayName(nameof(UseTelegramAPI), typeof(GlobalSettingsRes))]
        [LocalizedDescription(nameof(UseTelegramAPI), typeof(GlobalSettingsDescRes))]
        [Reactive]
        public bool UseTelegramAPI { get; set; }

        [DefaultValue(null)]
        [LocalizedDisplayName(nameof(TelegramAPIKey), typeof(GlobalSettingsRes))]
        [LocalizedDescription(nameof(TelegramAPIKey), typeof(GlobalSettingsDescRes))]
        [Reactive]
        public string TelegramAPIKey { get; set; }


        //console options
        [DefaultValue(10)]
        [LocalizedDisplayName(nameof(AmountOfPokemonToDisplayOnStart), typeof(GlobalSettingsRes))]
        [LocalizedDescription(nameof(AmountOfPokemonToDisplayOnStart), typeof(GlobalSettingsDescRes))]
        [Reactive]
        public int AmountOfPokemonToDisplayOnStart { get; set; }

        [DefaultValue(true)]
        [LocalizedDisplayName(nameof(DetailedCountsBeforeRecycling), typeof(GlobalSettingsRes))]
        [LocalizedDescription(nameof(DetailedCountsBeforeRecycling), typeof(GlobalSettingsDescRes))]
        [Reactive]
        public bool DetailedCountsBeforeRecycling { get; set; }


        [DefaultValue(3)]
        [LocalizedDisplayName(nameof(MaxBerriesToUsePerPokemon), typeof(GlobalSettingsRes))]
        [LocalizedDescription(nameof(MaxBerriesToUsePerPokemon), typeof(GlobalSettingsDescRes))]
        [Reactive]
        public int MaxBerriesToUsePerPokemon { get; set; }

        //pokemon
        [DefaultValue(true)]
        [LocalizedDisplayName(nameof(CatchPokemon), typeof(GlobalSettingsRes))]
        [LocalizedDescription(nameof(CatchPokemon), typeof(GlobalSettingsDescRes))]
        [Reactive]
        public bool CatchPokemon { get; set; }

        //powerup
        [DefaultValue(false)]
        [LocalizedDisplayName(nameof(AutomaticallyLevelUpPokemon), typeof(GlobalSettingsRes))]
        [LocalizedDescription(nameof(AutomaticallyLevelUpPokemon), typeof(GlobalSettingsDescRes))]
        [Reactive]
        public bool AutomaticallyLevelUpPokemon { get; set; }


        [DefaultValue((true))]
        [LocalizedDisplayName(nameof(UseLevelUpList), typeof(GlobalSettingsRes))]
        [LocalizedDescription(nameof(UseLevelUpList), typeof(GlobalSettingsDescRes))]
        [Reactive]
        public bool UseLevelUpList { get; set; }

        [DefaultValue(5)]
        [LocalizedDisplayName(nameof(AmountOfTimesToUpgradeLoop), typeof(GlobalSettingsRes))]
        [LocalizedDescription(nameof(AmountOfTimesToUpgradeLoop), typeof(GlobalSettingsDescRes))]
        [Reactive]
        public int AmountOfTimesToUpgradeLoop { get; set; }

        [DefaultValue(5000)]
        [LocalizedDisplayName(nameof(GetMinStarDustForLevelUp), typeof(GlobalSettingsRes))]
        [LocalizedDescription(nameof(GetMinStarDustForLevelUp), typeof(GlobalSettingsDescRes))]
        [Reactive]
        public int GetMinStarDustForLevelUp { get; set; }

        [DefaultValue("iv")]
        [LocalizedDisplayName(nameof(LevelUpByCPorIv), typeof(GlobalSettingsRes))]
        [LocalizedDescription(nameof(LevelUpByCPorIv), typeof(GlobalSettingsDescRes))]
        [Reactive]
        public string LevelUpByCPorIv { get; set; }

        [DefaultValue(1000)]
        [LocalizedDisplayName(nameof(UpgradePokemonCpMinimum), typeof(GlobalSettingsRes))]
        [LocalizedDescription(nameof(UpgradePokemonCpMinimum), typeof(GlobalSettingsDescRes))]
        [Reactive]
        public float UpgradePokemonCpMinimum { get; set; }

        [DefaultValue(95)]
        [LocalizedDisplayName(nameof(UpgradePokemonIvMinimum), typeof(GlobalSettingsRes))]
        [LocalizedDescription(nameof(UpgradePokemonIvMinimum), typeof(GlobalSettingsDescRes))]
        [Reactive]
        public float UpgradePokemonIvMinimum { get; set; }

        [DefaultValue("and")]
        [LocalizedDisplayName(nameof(UpgradePokemonMinimumStatsOperator), typeof(GlobalSettingsRes))]
        [LocalizedDescription(nameof(UpgradePokemonMinimumStatsOperator), typeof(GlobalSettingsDescRes))]
        [Reactive]
        public string UpgradePokemonMinimumStatsOperator { get; set; }

        //position
        [DefaultValue(false)]
        [LocalizedDisplayName(nameof(DisableHumanWalking), typeof(GlobalSettingsRes))]
        [LocalizedDescription(nameof(DisableHumanWalking), typeof(GlobalSettingsDescRes))]
        [Reactive]
        public bool DisableHumanWalking { get; set; }

        [DefaultValue(40.785091)]
        [LocalizedDisplayName(nameof(DefaultLatitude), typeof(GlobalSettingsRes))]
        [LocalizedDescription(nameof(DefaultLatitude), typeof(GlobalSettingsDescRes))]
        [Reactive]
        public double DefaultLatitude { get; set; }

        [DefaultValue(-73.968285)]
        [LocalizedDisplayName(nameof(DefaultLongitude), typeof(GlobalSettingsRes))]
        [LocalizedDescription(nameof(DefaultLongitude), typeof(GlobalSettingsDescRes))]
        [Reactive]
        public double DefaultLongitude { get; set; }

        [DefaultValue(19.0)]
        [LocalizedDisplayName(nameof(WalkingSpeedInKilometerPerHour), typeof(GlobalSettingsRes))]
        [LocalizedDescription(nameof(WalkingSpeedInKilometerPerHour), typeof(GlobalSettingsDescRes))]
        [Reactive]
        public double WalkingSpeedInKilometerPerHour { get; set; }

        [DefaultValue(10)]
        [LocalizedDisplayName(nameof(MaxSpawnLocationOffset), typeof(GlobalSettingsRes))]
        [LocalizedDescription(nameof(MaxSpawnLocationOffset), typeof(GlobalSettingsDescRes))]
        [Reactive]
        public int MaxSpawnLocationOffset { get; set; }

        //softban related
        [DefaultValue(false)]
        [LocalizedDisplayName(nameof(FastSoftBanBypass), typeof(GlobalSettingsRes))]
        [LocalizedDescription(nameof(FastSoftBanBypass), typeof(GlobalSettingsDescRes))]
        [Reactive]
        public bool FastSoftBanBypass { get; set; }

        //delays
        [DefaultValue(500)]
        [LocalizedDisplayName(nameof(DelayBetweenPlayerActions), typeof(GlobalSettingsRes))]
        [LocalizedDescription(nameof(DelayBetweenPlayerActions), typeof(GlobalSettingsDescRes))]
        [Reactive]
        public int DelayBetweenPlayerActions { get; set; }

        [DefaultValue(100)]
        [LocalizedDisplayName(nameof(DelayBetweenPokemonCatch), typeof(GlobalSettingsRes))]
        [LocalizedDescription(nameof(DelayBetweenPokemonCatch), typeof(GlobalSettingsDescRes))]
        [Reactive]
        public int DelayBetweenPokemonCatch { get; set; }

        //dump stats
        [DefaultValue(false)]
        [LocalizedDisplayName(nameof(DumpPokemonStats), typeof(GlobalSettingsRes))]
        [LocalizedDescription(nameof(DumpPokemonStats), typeof(GlobalSettingsDescRes))]
        [Reactive]
        public bool DumpPokemonStats { get; set; }

        //evolve
        [DefaultValue(95)]
        [LocalizedDisplayName(nameof(EvolveAboveIvValue), typeof(GlobalSettingsRes))]
        [LocalizedDescription(nameof(EvolveAboveIvValue), typeof(GlobalSettingsDescRes))]
        [Reactive]
        public float EvolveAboveIvValue { get; set; }

        [DefaultValue(false)]
        [LocalizedDisplayName(nameof(EvolveAllPokemonAboveIv), typeof(GlobalSettingsRes))]
        [LocalizedDescription(nameof(EvolveAllPokemonAboveIv), typeof(GlobalSettingsDescRes))]
        [Reactive]
        public bool EvolveAllPokemonAboveIv { get; set; }

        [DefaultValue(true)]
        [LocalizedDisplayName(nameof(EvolveAllPokemonWithEnoughCandy), typeof(GlobalSettingsRes))]
        [LocalizedDescription(nameof(EvolveAllPokemonWithEnoughCandy), typeof(GlobalSettingsDescRes))]
        [Reactive]
        public bool EvolveAllPokemonWithEnoughCandy { get; set; }

        [DefaultValue(90.0)]
        [LocalizedDisplayName(nameof(EvolveKeptPokemonsAtStorageUsagePercentage), typeof(GlobalSettingsRes))]
        [LocalizedDescription(nameof(EvolveKeptPokemonsAtStorageUsagePercentage), typeof(GlobalSettingsDescRes))]
        [Reactive]
        public double EvolveKeptPokemonsAtStorageUsagePercentage { get; set; }

        [DefaultValue(false)]
        [LocalizedDisplayName(nameof(KeepPokemonsThatCanEvolve), typeof(GlobalSettingsRes))]
        [LocalizedDescription(nameof(KeepPokemonsThatCanEvolve), typeof(GlobalSettingsDescRes))]
        [Reactive]
        public bool KeepPokemonsThatCanEvolve { get; set; }

        //keeping
        [DefaultValue(1250)]
        [LocalizedDisplayName(nameof(KeepMinCp), typeof(GlobalSettingsRes))]
        [LocalizedDescription(nameof(KeepMinCp), typeof(GlobalSettingsDescRes))]
        [Reactive]
        public int KeepMinCp { get; set; }

        [DefaultValue(90)]
        [LocalizedDisplayName(nameof(KeepMinIvPercentage), typeof(GlobalSettingsRes))]
        [LocalizedDescription(nameof(KeepMinIvPercentage), typeof(GlobalSettingsDescRes))]
        [Reactive]
        public float KeepMinIvPercentage { get; set; }

        [DefaultValue(6)]
        [LocalizedDisplayName(nameof(KeepMinLvl), typeof(GlobalSettingsRes))]
        [LocalizedDescription(nameof(KeepMinLvl), typeof(GlobalSettingsDescRes))]
        [Reactive]
        public int KeepMinLvl { get; set; }

        [DefaultValue("or")]
        [LocalizedDisplayName(nameof(KeepMinOperator), typeof(GlobalSettingsRes))]
        [LocalizedDescription(nameof(KeepMinOperator), typeof(GlobalSettingsDescRes))]
        [Reactive]
        public string KeepMinOperator { get; set; }

        [DefaultValue(false)]
        [LocalizedDisplayName(nameof(UseKeepMinLvl), typeof(GlobalSettingsRes))]
        [LocalizedDescription(nameof(UseKeepMinLvl), typeof(GlobalSettingsDescRes))]
        [Reactive]
        public bool UseKeepMinLvl { get; set; }

        [DefaultValue(false)]
        [LocalizedDisplayName(nameof(PrioritizeIvOverCp), typeof(GlobalSettingsRes))]
        [LocalizedDescription(nameof(PrioritizeIvOverCp), typeof(GlobalSettingsDescRes))]
        [Reactive]
        public bool PrioritizeIvOverCp { get; set; }

        [DefaultValue(0)]
        [LocalizedDisplayName(nameof(KeepMinDuplicatePokemon), typeof(GlobalSettingsRes))]
        [LocalizedDescription(nameof(KeepMinDuplicatePokemon), typeof(GlobalSettingsDescRes))]
        [Reactive]
        public int KeepMinDuplicatePokemon { get; set; }

        //gpx
        [DefaultValue(false)]
        [LocalizedDisplayName(nameof(UseGpxPathing), typeof(GlobalSettingsRes))]
        [LocalizedDescription(nameof(UseGpxPathing), typeof(GlobalSettingsDescRes))]
        [Reactive]
        public bool UseGpxPathing { get; set; }

        [DefaultValue("GPXPath.GPX")]
        [LocalizedDisplayName(nameof(GpxFile), typeof(GlobalSettingsRes))]
        [LocalizedDescription(nameof(GpxFile), typeof(GlobalSettingsDescRes))]
        [Reactive]
        public string GpxFile { get; set; }

        //recycle
        [DefaultValue(true)]
        [LocalizedDisplayName(nameof(VerboseRecycling), typeof(GlobalSettingsRes))]
        [LocalizedDescription(nameof(VerboseRecycling), typeof(GlobalSettingsDescRes))]
        [Reactive]
        public bool VerboseRecycling { get; set; }

        [DefaultValue(90.0)]
        [LocalizedDisplayName(nameof(RecycleInventoryAtUsagePercentage), typeof(GlobalSettingsRes))]
        [LocalizedDescription(nameof(RecycleInventoryAtUsagePercentage), typeof(GlobalSettingsDescRes))]
        [Reactive]
        public double RecycleInventoryAtUsagePercentage { get; set; }

        [DefaultValue(false)]
        [LocalizedDisplayName(nameof(RandomizeRecycle), typeof(GlobalSettingsRes))]
        [LocalizedDescription(nameof(RandomizeRecycle), typeof(GlobalSettingsDescRes))]
        [Reactive]
        public bool RandomizeRecycle { get; set; }

        [DefaultValue(5)]
        [LocalizedDisplayName(nameof(RandomRecycleValue), typeof(GlobalSettingsRes))]
        [LocalizedDescription(nameof(RandomRecycleValue), typeof(GlobalSettingsDescRes))]
        [Reactive]
        public int RandomRecycleValue { get; set; }

        [DefaultValue(false)]
        [LocalizedDisplayName(nameof(DelayBetweenRecycleActions), typeof(GlobalSettingsRes))]
        [LocalizedDescription(nameof(DelayBetweenRecycleActions), typeof(GlobalSettingsDescRes))]
        [Reactive]
        public bool DelayBetweenRecycleActions { get; set; }

        //lucky, incense and berries
        [DefaultValue(true)]
        [LocalizedDisplayName(nameof(UseEggIncubators), typeof(GlobalSettingsRes))]
        [LocalizedDescription(nameof(UseEggIncubators), typeof(GlobalSettingsDescRes))]
        [Reactive]
        public bool UseEggIncubators { get; set; }

        [DefaultValue(false)]
        [LocalizedDisplayName(nameof(UseLuckyEggConstantly), typeof(GlobalSettingsRes))]
        [LocalizedDescription(nameof(UseLuckyEggConstantly), typeof(GlobalSettingsDescRes))]
        [Reactive]
        public bool UseLuckyEggConstantly { get; set; }

        [DefaultValue(30)]
        [LocalizedDisplayName(nameof(UseLuckyEggsMinPokemonAmount), typeof(GlobalSettingsRes))]
        [LocalizedDescription(nameof(UseLuckyEggsMinPokemonAmount), typeof(GlobalSettingsDescRes))]
        [Reactive]
        public int UseLuckyEggsMinPokemonAmount { get; set; }

        [DefaultValue(false)]
        [LocalizedDisplayName(nameof(UseLuckyEggsWhileEvolving), typeof(GlobalSettingsRes))]
        [LocalizedDescription(nameof(UseLuckyEggsWhileEvolving), typeof(GlobalSettingsDescRes))]
        [Reactive]
        public bool UseLuckyEggsWhileEvolving { get; set; }

        [DefaultValue(false)]
        [LocalizedDisplayName(nameof(UseIncenseConstantly), typeof(GlobalSettingsRes))]
        [LocalizedDescription(nameof(UseIncenseConstantly), typeof(GlobalSettingsDescRes))]
        [Reactive]
        public bool UseIncenseConstantly { get; set; }

        [DefaultValue(1000)]
        [LocalizedDisplayName(nameof(UseBerriesMinCp), typeof(GlobalSettingsRes))]
        [LocalizedDescription(nameof(UseBerriesMinCp), typeof(GlobalSettingsDescRes))]
        [Reactive]
        public int UseBerriesMinCp { get; set; }

        [DefaultValue(90)]
        [LocalizedDisplayName(nameof(UseBerriesMinIv), typeof(GlobalSettingsRes))]
        [LocalizedDescription(nameof(UseBerriesMinIv), typeof(GlobalSettingsDescRes))]
        [Reactive]
        public float UseBerriesMinIv { get; set; }

        [DefaultValue(0.20)]
        [LocalizedDisplayName(nameof(UseBerriesBelowCatchProbability), typeof(GlobalSettingsRes))]
        [LocalizedDescription(nameof(UseBerriesBelowCatchProbability), typeof(GlobalSettingsDescRes))]
        [Reactive]
        public double UseBerriesBelowCatchProbability { get; set; }

        [DefaultValue("or")]
        [LocalizedDisplayName(nameof(UseBerriesOperator), typeof(GlobalSettingsRes))]
        [LocalizedDescription(nameof(UseBerriesOperator), typeof(GlobalSettingsDescRes))]
        [Reactive]
        public string UseBerriesOperator { get; set; }

        //snipe
        [DefaultValue(false)]
        [LocalizedDisplayName(nameof(UseSnipeLocationServer), typeof(GlobalSettingsRes))]
        [LocalizedDescription(nameof(UseSnipeLocationServer), typeof(GlobalSettingsDescRes))]
        [Reactive]
        public bool UseSnipeLocationServer { get; set; }

        [DefaultValue("localhost")]
        [LocalizedDisplayName(nameof(SnipeLocationServer), typeof(GlobalSettingsRes))]
        [LocalizedDescription(nameof(SnipeLocationServer), typeof(GlobalSettingsDescRes))]
        [Reactive]
        public string SnipeLocationServer { get; set; }

        [DefaultValue(16969)]
        [LocalizedDisplayName(nameof(SnipeLocationServerPort), typeof(GlobalSettingsRes))]
        [LocalizedDescription(nameof(SnipeLocationServerPort), typeof(GlobalSettingsDescRes))]
        [Reactive]
        public int SnipeLocationServerPort { get; set; }

        [DefaultValue(true)]
        [LocalizedDisplayName(nameof(GetSniperInfoFromPokezz), typeof(GlobalSettingsRes))]
        [LocalizedDescription(nameof(GetSniperInfoFromPokezz), typeof(GlobalSettingsDescRes))]
        [Reactive]
        public bool GetSniperInfoFromPokezz { get; set; }

        [DefaultValue(true)]
        [LocalizedDisplayName(nameof(GetOnlyVerifiedSniperInfoFromPokezz), typeof(GlobalSettingsRes))]
        [LocalizedDescription(nameof(GetOnlyVerifiedSniperInfoFromPokezz), typeof(GlobalSettingsDescRes))]
        [Reactive]
        public bool GetOnlyVerifiedSniperInfoFromPokezz { get; set; }

        [DefaultValue(true)]
        [LocalizedDisplayName(nameof(GetSniperInfoFromPokeSnipers), typeof(GlobalSettingsRes))]
        [LocalizedDescription(nameof(GetSniperInfoFromPokeSnipers), typeof(GlobalSettingsDescRes))]
        [Reactive]
        public bool GetSniperInfoFromPokeSnipers { get; set; }

        [DefaultValue(true)]
        [LocalizedDisplayName(nameof(GetSniperInfoFromPokeWatchers), typeof(GlobalSettingsRes))]
        [LocalizedDescription(nameof(GetSniperInfoFromPokeWatchers), typeof(GlobalSettingsDescRes))]
        [Reactive]
        public bool GetSniperInfoFromPokeWatchers { get; set; }

        [DefaultValue(true)]
        [LocalizedDisplayName(nameof(GetSniperInfoFromSkiplagged), typeof(GlobalSettingsRes))]
        [LocalizedDescription(nameof(GetSniperInfoFromSkiplagged), typeof(GlobalSettingsDescRes))]
        [Reactive]
        public bool GetSniperInfoFromSkiplagged { get; set; }

        [DefaultValue(20)]
        [LocalizedDisplayName(nameof(MinPokeballsToSnipe), typeof(GlobalSettingsRes))]
        [LocalizedDescription(nameof(MinPokeballsToSnipe), typeof(GlobalSettingsDescRes))]
        [Reactive]
        public int MinPokeballsToSnipe { get; set; }

        [DefaultValue(0)]
        [LocalizedDisplayName(nameof(MinPokeballsWhileSnipe), typeof(GlobalSettingsRes))]
        [LocalizedDescription(nameof(MinPokeballsWhileSnipe), typeof(GlobalSettingsDescRes))]
        [Reactive]
        public int MinPokeballsWhileSnipe { get; set; }

        [DefaultValue(60000)]
        [LocalizedDisplayName(nameof(MinDelayBetweenSnipes), typeof(GlobalSettingsRes))]
        [LocalizedDescription(nameof(MinDelayBetweenSnipes), typeof(GlobalSettingsDescRes))]
        [Reactive]
        public int MinDelayBetweenSnipes { get; set; }

        [DefaultValue(0.005)]
        [LocalizedDisplayName(nameof(SnipingScanOffset), typeof(GlobalSettingsRes))]
        [LocalizedDescription(nameof(SnipingScanOffset), typeof(GlobalSettingsDescRes))]
        [Reactive]
        public double SnipingScanOffset { get; set; }

        [DefaultValue(false)]
        [LocalizedDisplayName(nameof(SnipeAtPokestops), typeof(GlobalSettingsRes))]
        [LocalizedDescription(nameof(SnipeAtPokestops), typeof(GlobalSettingsDescRes))]
        [Reactive]
        public bool SnipeAtPokestops { get; set; }

        [DefaultValue(false)]
        [LocalizedDisplayName(nameof(SnipeIgnoreUnknownIv), typeof(GlobalSettingsRes))]
        [LocalizedDescription(nameof(SnipeIgnoreUnknownIv), typeof(GlobalSettingsDescRes))]
        [Reactive]
        public bool SnipeIgnoreUnknownIv { get; set; }

        [DefaultValue(false)]
        [LocalizedDisplayName(nameof(UseTransferIvForSnipe), typeof(GlobalSettingsRes))]
        [LocalizedDescription(nameof(UseTransferIvForSnipe), typeof(GlobalSettingsDescRes))]
        [Reactive]
        public bool UseTransferIvForSnipe { get; set; }

        [DefaultValue(false)]
        [LocalizedDisplayName(nameof(SnipePokemonNotInPokedex), typeof(GlobalSettingsRes))]
        [LocalizedDescription(nameof(SnipePokemonNotInPokedex), typeof(GlobalSettingsDescRes))]
        [Reactive]
        public bool SnipePokemonNotInPokedex { get; set; }

        //rename
        [DefaultValue(false)]
        [LocalizedDisplayName(nameof(RenamePokemon), typeof(GlobalSettingsRes))]
        [LocalizedDescription(nameof(RenamePokemon), typeof(GlobalSettingsDescRes))]
        [Reactive]
        public bool RenamePokemon { get; set; }

        [DefaultValue(true)]
        [LocalizedDisplayName(nameof(RenameOnlyAboveIv), typeof(GlobalSettingsRes))]
        [LocalizedDescription(nameof(RenameOnlyAboveIv), typeof(GlobalSettingsDescRes))]
        [Reactive]
        public bool RenameOnlyAboveIv { get; set; }

        [DefaultValue("{1}_{0}")]
        [LocalizedDisplayName(nameof(RenameTemplate), typeof(GlobalSettingsRes))]
        [LocalizedDescription(nameof(RenameTemplate), typeof(GlobalSettingsDescRes))]
        [Reactive]
        public string RenameTemplate { get; set; }

        //amounts
        [DefaultValue(6)]
        [LocalizedDisplayName(nameof(MaxPokeballsPerPokemon), typeof(GlobalSettingsRes))]
        [LocalizedDescription(nameof(MaxPokeballsPerPokemon), typeof(GlobalSettingsDescRes))]
        [Reactive]
        public int MaxPokeballsPerPokemon { get; set; }

        [DefaultValue(1000)]
        [LocalizedDisplayName(nameof(MaxTravelDistanceInMeters), typeof(GlobalSettingsRes))]
        [LocalizedDescription(nameof(MaxTravelDistanceInMeters), typeof(GlobalSettingsDescRes))]
        [Reactive]
        public int MaxTravelDistanceInMeters { get; set; }

        [DefaultValue(120)]
        [LocalizedDisplayName(nameof(TotalAmountOfPokeballsToKeep), typeof(GlobalSettingsRes))]
        [LocalizedDescription(nameof(TotalAmountOfPokeballsToKeep), typeof(GlobalSettingsDescRes))]
        [Reactive]
        public int TotalAmountOfPokeballsToKeep { get; set; }

        [DefaultValue(80)]
        [LocalizedDisplayName(nameof(TotalAmountOfPotionsToKeep), typeof(GlobalSettingsRes))]
        [LocalizedDescription(nameof(TotalAmountOfPotionsToKeep), typeof(GlobalSettingsDescRes))]
        [Reactive]
        public int TotalAmountOfPotionsToKeep { get; set; }

        [DefaultValue(60)]
        [LocalizedDisplayName(nameof(TotalAmountOfRevivesToKeep), typeof(GlobalSettingsRes))]
        [LocalizedDescription(nameof(TotalAmountOfRevivesToKeep), typeof(GlobalSettingsDescRes))]
        [Reactive]
        public int TotalAmountOfRevivesToKeep { get; set; }

        [DefaultValue(50)]
        [LocalizedDisplayName(nameof(TotalAmountOfBerriesToKeep), typeof(GlobalSettingsRes))]
        [LocalizedDescription(nameof(TotalAmountOfBerriesToKeep), typeof(GlobalSettingsDescRes))]
        [Reactive]
        public int TotalAmountOfBerriesToKeep { get; set; }

        //balls
        [DefaultValue(1000)]
        [LocalizedDisplayName(nameof(UseGreatBallAboveCp), typeof(GlobalSettingsRes))]
        [LocalizedDescription(nameof(UseGreatBallAboveCp), typeof(GlobalSettingsDescRes))]
        [Reactive]
        public int UseGreatBallAboveCp { get; set; }

        [DefaultValue(1250)]
        [LocalizedDisplayName(nameof(UseUltraBallAboveCp), typeof(GlobalSettingsRes))]
        [LocalizedDescription(nameof(UseUltraBallAboveCp), typeof(GlobalSettingsDescRes))]
        [Reactive]
        public int UseUltraBallAboveCp { get; set; }

        [DefaultValue(1500)]
        [LocalizedDisplayName(nameof(UseMasterBallAboveCp), typeof(GlobalSettingsRes))]
        [LocalizedDescription(nameof(UseMasterBallAboveCp), typeof(GlobalSettingsDescRes))]
        [Reactive]
        public int UseMasterBallAboveCp { get; set; }

        [DefaultValue(85.0)]
        [LocalizedDisplayName(nameof(UseGreatBallAboveIv), typeof(GlobalSettingsRes))]
        [LocalizedDescription(nameof(UseGreatBallAboveIv), typeof(GlobalSettingsDescRes))]
        [Reactive]
        public double UseGreatBallAboveIv { get; set; }

        [DefaultValue(95.0)]
        [LocalizedDisplayName(nameof(UseUltraBallAboveIv), typeof(GlobalSettingsRes))]
        [LocalizedDescription(nameof(UseUltraBallAboveIv), typeof(GlobalSettingsDescRes))]
        [Reactive]
        public double UseUltraBallAboveIv { get; set; }

        [DefaultValue(0.2)]
        [LocalizedDisplayName(nameof(UseGreatBallBelowCatchProbability), typeof(GlobalSettingsRes))]
        [LocalizedDescription(nameof(UseGreatBallBelowCatchProbability), typeof(GlobalSettingsDescRes))]
        [Reactive]
        public double UseGreatBallBelowCatchProbability { get; set; }

        [DefaultValue(0.1)]
        [LocalizedDisplayName(nameof(UseUltraBallBelowCatchProbability), typeof(GlobalSettingsRes))]
        [LocalizedDescription(nameof(UseUltraBallBelowCatchProbability), typeof(GlobalSettingsDescRes))]
        [Reactive]
        public double UseUltraBallBelowCatchProbability { get; set; }

        [DefaultValue(0.05)]
        [LocalizedDisplayName(nameof(UseMasterBallBelowCatchProbability), typeof(GlobalSettingsRes))]
        [LocalizedDescription(nameof(UseMasterBallBelowCatchProbability), typeof(GlobalSettingsDescRes))]
        [Reactive]
        public double UseMasterBallBelowCatchProbability { get; set; }

        //customizable catch
        [DefaultValue(false)]
        [LocalizedDisplayName(nameof(EnableHumanizedThrows), typeof(GlobalSettingsRes))]
        [LocalizedDescription(nameof(EnableHumanizedThrows), typeof(GlobalSettingsDescRes))]
        [Reactive]
        public bool EnableHumanizedThrows { get; set; }

        [DefaultValue(40)]
        [LocalizedDisplayName(nameof(NiceThrowChance), typeof(GlobalSettingsRes))]
        [LocalizedDescription(nameof(NiceThrowChance), typeof(GlobalSettingsDescRes))]
        [Reactive]
        public int NiceThrowChance { get; set; }

        [DefaultValue(30)]
        [LocalizedDisplayName(nameof(GreatThrowChance), typeof(GlobalSettingsRes))]
        [LocalizedDescription(nameof(GreatThrowChance), typeof(GlobalSettingsDescRes))]
        [Reactive]
        public int GreatThrowChance { get; set; }

        [DefaultValue(10)]
        [LocalizedDisplayName(nameof(ExcellentThrowChance), typeof(GlobalSettingsRes))]
        [LocalizedDescription(nameof(ExcellentThrowChance), typeof(GlobalSettingsDescRes))]
        [Reactive]
        public int ExcellentThrowChance { get; set; }

        [DefaultValue(90)]
        [LocalizedDisplayName(nameof(CurveThrowChance), typeof(GlobalSettingsRes))]
        [LocalizedDescription(nameof(CurveThrowChance), typeof(GlobalSettingsDescRes))]
        [Reactive]
        public int CurveThrowChance { get; set; }

        [DefaultValue(90.00)]
        [LocalizedDisplayName(nameof(ForceGreatThrowOverIv), typeof(GlobalSettingsRes))]
        [LocalizedDescription(nameof(ForceGreatThrowOverIv), typeof(GlobalSettingsDescRes))]
        [Reactive]
        public double ForceGreatThrowOverIv { get; set; }

        [DefaultValue(95.00)]
        [LocalizedDisplayName(nameof(ForceExcellentThrowOverIv), typeof(GlobalSettingsRes))]
        [LocalizedDescription(nameof(ForceExcellentThrowOverIv), typeof(GlobalSettingsDescRes))]
        [Reactive]
        public double ForceExcellentThrowOverIv { get; set; }

        [DefaultValue(1000)]
        [LocalizedDisplayName(nameof(ForceGreatThrowOverCp), typeof(GlobalSettingsRes))]
        [LocalizedDescription(nameof(ForceGreatThrowOverCp), typeof(GlobalSettingsDescRes))]
        [Reactive]
        public int ForceGreatThrowOverCp { get; set; }

        [DefaultValue(1500)]
        [LocalizedDisplayName(nameof(ForceExcellentThrowOverCp), typeof(GlobalSettingsRes))]
        [LocalizedDescription(nameof(ForceExcellentThrowOverCp), typeof(GlobalSettingsDescRes))]
        [Reactive]
        public int ForceExcellentThrowOverCp { get; set; }

        //transfer
        [DefaultValue(false)]
        [LocalizedDisplayName(nameof(TransferWeakPokemon), typeof(GlobalSettingsRes))]
        [LocalizedDescription(nameof(TransferWeakPokemon), typeof(GlobalSettingsDescRes))]
        [Reactive]
        public bool TransferWeakPokemon { get; set; }

        [DefaultValue(true)]
        [LocalizedDisplayName(nameof(TransferDuplicatePokemon), typeof(GlobalSettingsRes))]
        [LocalizedDescription(nameof(TransferDuplicatePokemon), typeof(GlobalSettingsDescRes))]
        [Reactive]
        public bool TransferDuplicatePokemon { get; set; }

        [DefaultValue(true)]
        [LocalizedDisplayName(nameof(TransferDuplicatePokemonOnCapture), typeof(GlobalSettingsRes))]
        [LocalizedDescription(nameof(TransferDuplicatePokemonOnCapture), typeof(GlobalSettingsDescRes))]
        [Reactive]
        public bool TransferDuplicatePokemonOnCapture { get; set; }

        //favorite
        [DefaultValue(95)]
        [LocalizedDisplayName(nameof(FavoriteMinIvPercentage), typeof(GlobalSettingsRes))]
        [LocalizedDescription(nameof(FavoriteMinIvPercentage), typeof(GlobalSettingsDescRes))]
        [Reactive]
        public float FavoriteMinIvPercentage { get; set; }

        [DefaultValue(false)]
        [LocalizedDisplayName(nameof(AutoFavoritePokemon), typeof(GlobalSettingsRes))]
        [LocalizedDescription(nameof(AutoFavoritePokemon), typeof(GlobalSettingsDescRes))]
        [Reactive]
        public bool AutoFavoritePokemon { get; set; }

        //notcatch
        [DefaultValue(false)]
        [LocalizedDisplayName(nameof(UsePokemonToNotCatchFilter), typeof(GlobalSettingsRes))]
        [LocalizedDescription(nameof(UsePokemonToNotCatchFilter), typeof(GlobalSettingsDescRes))]
        [Reactive]
        public bool UsePokemonToNotCatchFilter { get; set; }

        [DefaultValue(false)]
        [LocalizedDisplayName(nameof(UsePokemonSniperFilterOnly), typeof(GlobalSettingsRes))]
        [LocalizedDescription(nameof(UsePokemonSniperFilterOnly), typeof(GlobalSettingsDescRes))]
        [Reactive]
        public bool UsePokemonSniperFilterOnly { get; set; }

        [LocalizedDisplayName(nameof(ItemRecycleFilter), typeof(GlobalSettingsRes))]
        [LocalizedDescription(nameof(ItemRecycleFilter), typeof(GlobalSettingsDescRes))]
        [Reactive]
        public List<KeyValuePair<ItemId, int>> ItemRecycleFilter { get; set; }

        [LocalizedDisplayName(nameof(PokemonsNotToTransfer), typeof(GlobalSettingsRes))]
        [LocalizedDescription(nameof(PokemonsNotToTransfer), typeof(GlobalSettingsDescRes))]
        [Reactive]
        public List<PokemonId> PokemonsNotToTransfer { get; set; }


        [LocalizedDisplayName(nameof(PokemonsToEvolve), typeof(GlobalSettingsRes))]
        [LocalizedDescription(nameof(PokemonsToEvolve), typeof(GlobalSettingsDescRes))]
        [Reactive]
        public List<PokemonId> PokemonsToEvolve { get; set; }

        [LocalizedDisplayName(nameof(PokemonsToLevelUp), typeof(GlobalSettingsRes))]
        [LocalizedDescription(nameof(PokemonsToLevelUp), typeof(GlobalSettingsDescRes))]
        [Reactive]
        public List<PokemonId> PokemonsToLevelUp { get; set; }

        [LocalizedDisplayName(nameof(PokemonsToIgnore), typeof(GlobalSettingsRes))]
        [LocalizedDescription(nameof(PokemonsToIgnore), typeof(GlobalSettingsDescRes))]
        [Reactive]
        public List<PokemonId> PokemonsToIgnore { get; set; }


        [LocalizedDisplayName(nameof(PokemonsTransferFilter), typeof(GlobalSettingsRes))]
        [LocalizedDescription(nameof(PokemonsTransferFilter), typeof(GlobalSettingsDescRes))]
        [Reactive]
        public Dictionary<PokemonId, TransferFilter> PokemonsTransferFilter { get; set; }

        [LocalizedDisplayName(nameof(PokemonToSnipe), typeof(GlobalSettingsRes))]
        [LocalizedDescription(nameof(PokemonToSnipe), typeof(GlobalSettingsDescRes))]
        [Reactive]
        public SnipeSettings PokemonToSnipe { get; set; }


        [LocalizedDisplayName(nameof(PokemonToUseMasterball), typeof(GlobalSettingsRes))]
        [LocalizedDescription(nameof(PokemonToUseMasterball), typeof(GlobalSettingsDescRes))]
        [Reactive]
        public List<PokemonId> PokemonToUseMasterball { get; set; }
    }
}