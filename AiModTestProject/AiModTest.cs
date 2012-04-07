using System;
using System.Collections.Generic;
using System.Text;
using osu.GameModes.Edit.AiMod;
using osu.GameplayElements.HitObjects;

namespace AiModTestProject
{
    /// <summary>
    /// A very simple and useless ruleset mainly to test loading/unloading functionality for the moment.
    /// More examples to come ;).
    /// </summary>
    public class AiModTest : AiModRuleset
    {
        public override AiModType Type
        {
            get { return AiModType.Errors; }
        }

        protected override void RunAllRules(List<HitObjectBase> hitObjects)
        {
            //Do your processing in here
            Reports.Add(new AiReport(Severity.Error, "This is a test error. No action needs to be taken!"));
        }
    }
}
