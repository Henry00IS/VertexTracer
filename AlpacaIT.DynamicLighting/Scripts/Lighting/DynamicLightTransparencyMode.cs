﻿using UnityEngine;

namespace AlpacaIT.DynamicLighting
{
    public enum DynamicLightTransparencyMode
    {
        /// <summary>
        /// Disables light shining through alpha transparent textures. These shadows are faster to
        /// calculate and more precise, especially over long distances (default).
        /// <para>This option does not affect real-time shadows.</para>
        /// </summary>
        [Tooltip("Disables light shining through alpha transparent textures. These shadows are faster to calculate and more precise, especially over long distances (default).\n\nThis option does not affect real-time shadows.")]
        Disabled = 0,

        /// <summary>
        /// Enables light shining through alpha transparent textures, where alpha is &gt; 0.5. These
        /// shadows are slower to calculate and less precise, especially over long distances. It
        /// uses the graphics card to help with the raytracing process and takes a moment longer to
        /// prepare. There is no runtime performance impact. Please note that this feature may yield
        /// some noisy shadows as the feature is experimental.
        /// <para>This option does not affect real-time shadows.</para>
        /// </summary>
        [Tooltip("Enables light shining through alpha transparent textures, where alpha is > 0.5. These shadows are slower to calculate and less precise, especially over long distances. It uses the graphics card to help with the raytracing process and takes a moment longer to prepare. There is no runtime performance impact. Please note that this feature may yield some noisy shadows as the feature is experimental.\n\nThis option does not affect real-time shadows.")]
        Enabled = 1,
    }
}