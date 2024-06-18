using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Rendering;

[System.Serializable, VolumeComponentMenu("TK_PostProcessing/RayMarching_VolumeticLight")]
public class VolumeticLight_Volume : VolumeComponent
{
    [HideInInspector]
    public BoolParameter isActive = new BoolParameter(false);

    private void OnValidate()
    {
        isActive.value = active;
    }

    [Header("ǿ��")]
    [Range(0, 1)]
    public FloatParameter intensity = new FloatParameter(0.7f);
    [Header("��������")]
    [Range(1, 64)]
    public FloatParameter stepTimes = new FloatParameter(16f);
    [Header("ģ����Χ")]
    [Range(0.1f, 10)]
    public FloatParameter blurRange = new FloatParameter(1f);
}
