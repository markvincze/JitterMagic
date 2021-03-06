﻿using System;

namespace JitterMagic
{
    /// <summary>
    /// Used when needing separate instances of Jitter class with different settings; otherwise use the static class and methods.
    /// </summary>
    public interface IJitterInstance
    {
        /// <summary>
        /// Settings for this instance.
        /// </summary>
        /// <value>The settings.</value>
        JitterSettings Settings { get; }

        /// <summary>
        /// Updates the settings.
        /// </summary>
        /// <param name="settings">Settings.</param>
        void UpdateSettings(JitterSettings settings);

        /// <summary>
        /// Applies jitter to the <see cref="input" /> using the settings set in the constructor.
        /// </summary>
        /// <param name="input">A double you want to apply jitter to.</param>
        /// <returns>A random number between <see cref="input" /> +/- percentage.</returns>
        int Apply(int input);

        /// <summary>
        /// Applies jitter to the <see cref="input" /> using the settings set in the constructor.
        /// </summary>
        /// <param name="input">A double you want to apply jitter to.</param>
        /// <returns>A random number between <see cref="input" /> +/- percentage.</returns>
        double Apply(double input);
    }
}