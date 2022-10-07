using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MenuManager : MonoBehaviour
{
    public GameObject[] menus;
    public Slider volumeSlider;
    public Toggle muteToggle;
    public Dropdown dropdown;
    bool isMute = true;
    float volume = 0f;
    string resolution = "800x600";

    public void ShowMenu(int index)
    {
        foreach(GameObject menu in menus){
            menu.SetActive(false);
        }

        menus[index].SetActive(true);
    }

    public void DebugSetting()
    {
        Debug.Log("Volume : " + volume);
        Debug.Log("Is Muted : " + isMute.ToString());
        Debug.Log("Resolution : " + resolution);
    }

    public void SetVolume()
    {
        volume = volumeSlider.value;
    }

    public void SetToggle()
    {
        isMute = muteToggle.isOn;
    }

    public void ChangeResolution()
    {
        switch (dropdown.value)
        {
            case 0:
                resolution = "800x600";
                break;
            case 1:
                resolution = "1280x720";
                break;
            default:
                resolution = "1920x1080";
                break;
        }
    }
}
