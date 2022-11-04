using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SceneSettings : MonoBehaviour
{
    private void Awake()
    {
        QualitySettings.vSyncCount = 0;
        QualitySettings.shadows = ShadowQuality.Disable;
        QualitySettings.anisotropicFiltering = AnisotropicFiltering.Disable;
        QualitySettings.antiAliasing = 0;
        QualitySettings.shadowCascades = 0;
        Application.targetFrameRate = 1000;
    }
}
