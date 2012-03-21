using System;
using System.Collections.Generic;

namespace osu.GameplayElements.HitObjects
{
    [Flags]
    public enum HitObjectType
    {
        Normal = 1,
        Slider = 2,
        NewCombo = 4,
        NormalNewCombo = 5,
        SliderNewCombo = 6,
        Spinner = 8,
        ColourHax = 112,
        Hold = 128
    } ;

    [Flags]
    public enum HitObjectSoundType
    {
        None = 0,
        Normal = 1,
        Whistle = 2,
        Finish = 4,
        WhistleFinish = 6,
        Clap = 8
    } ;

    public abstract class HitObjectBase
    {
        public int StartTime;

        public int EndTime;

        public HitObjectType Type;

        /// <summary>
        /// If this object has a New Combo marker, how many additional colours do we cycle by?
        /// </summary>
        public int ComboOffset = 0;

        /// <summary>
        /// The zero-based index for which combo colour to use.
        /// Needed where an RGB triple is insufficient.
        /// </summary>
        public int ComboColourIndex;
    }
}