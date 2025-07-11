﻿using Vector2 = System.Numerics.Vector2;
using Vector4 = System.Numerics.Vector4;

namespace Simulation.UserInterface.Components.Settings
{
    internal class UPSSlider(
        string id,
        Vector2 position,
        Vector2 slider,
        Vector4 barColor,
        Vector4 ballColor,
        uint interval = 1,
        uint minInterval = 1,
        uint maxInterval = 10000,
        bool visible = false,
        float domainBreak = 0.3f,
        float rangeBreak = 0.6f
        ) : Slider(
            id,
            position,
            slider,
            barColor,
            ballColor,
            interval,
            minInterval,
            maxInterval,
            visible,
            domainBreak,
            rangeBreak)
    {
        internal override void OnLeftRelease()
        {
            base.OnLeftRelease();

            Cycle.ChangeUpdateInterval(Interval);
        }

        internal override void OnHover()
        {
            base.OnHover();

            if (Clicked && !Hovered)
            {
                Cycle.ChangeUpdateInterval(Interval);
                Clicked = false;
            }
        }
    }
}
