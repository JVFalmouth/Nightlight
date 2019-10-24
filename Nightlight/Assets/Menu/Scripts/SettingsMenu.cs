using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Audio;
using UnityEngine.UI;

public class SettingsMenu : MonoBehaviour
{
    public AudioMixer audioMixer;
    Resolution[] resolutions;
    public TMPro.TMP_Dropdown resDropDown;

    private void Start()
    {
        resolutions = Screen.resolutions;

        resDropDown.ClearOptions();

        List<string> options = new List<string>();

        int currResIndex = 0;
        for (int i = 0; i < resolutions.Length; i++)
        {
            string option = resolutions[i].width + " x " + resolutions[i].height;
            options.Add(option);

            if (resolutions[i].width == Screen.width && resolutions[i].height == Screen.height)
            {
                currResIndex = i;
            }
        }

        resDropDown.AddOptions(options);
        resDropDown.value = currResIndex;
        resDropDown.RefreshShownValue();
    }

    public void SetVolume(float volume)
    {
        audioMixer.SetFloat("MainVolume", volume);
    }

    public void SetQuality(int qualityIndex)
    {
        QualitySettings.SetQualityLevel(qualityIndex);
    }

    public void SetResolution(int resolutionIndex)
    {
        Resolution res = resolutions[resolutionIndex];

        Screen.SetResolution(res.width, res.height, Screen.fullScreen);
    }
}
