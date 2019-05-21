﻿using System.Reflection;

namespace ChoppedEVA.Settings
{
    public class ChoppedEvaSettings : GameParameters.CustomParameterNode
    {
        public const string ResourceName = "EvaLS";
        public override string Title { get; } = "Chopping Rules";
        public override string Section { get; } = "Chopped EVA";
        public override string DisplaySection { get; } = "Chopped EVA";
        public override int SectionOrder { get; } = 3;
        public override GameParameters.GameMode GameMode { get; } = GameParameters.GameMode.ANY;
        public override bool HasPresets { get; } = false;

        [GameParameters.CustomParameterUI("Enable EVA chopping", toolTip = "Can kerbals be chopped during EVA", autoPersistance = true, gameMode = GameParameters.GameMode.ANY)]
        public bool EnableChopping = false;

        [GameParameters.CustomIntParameterUI("Max EVA time (minutes)", maxValue = 15, minValue = 1, stepSize = 1, toolTip = "How many minutes can a kerbal be on EVA, before being chopped", autoPersistance = true)]
        public int MaxEvaTime = 10;

        [GameParameters.CustomParameterUI("Missing kerbals", toolTip = "Kerbals will be marked as missing, instead of dead", autoPersistance = true, gameMode = GameParameters.GameMode.ANY)]
        public bool ReportMissing = false;

        public override bool Enabled(MemberInfo member, GameParameters parameters)
        {
            return member.Name == nameof(EnableChopping) || EnableChopping;
        }
    }
}