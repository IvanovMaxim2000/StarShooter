using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Settings : MonoBehaviour
{
    private Resolution[] _rsl;
    private List<string> _resolutions;

    [SerializeField] bool isFullScreen;
    [SerializeField] Dropdown dropdown;
    [SerializeField] Slider sensivitySlider;

    public void FullScreenToggle()
    {
        isFullScreen = !isFullScreen;
        Screen.fullScreen = isFullScreen;
    }
    public void Awake()
    {
        _resolutions = new List<string>();
        _rsl = Screen.resolutions;
        foreach (var i in _rsl)
        {
            _resolutions.Add(i.width + "x" + i.height);
        }
        dropdown.ClearOptions();
        dropdown.AddOptions(_resolutions);
    }
    
    public void Select(int func)
    {
        Screen.SetResolution(_rsl[func].width, _rsl[func].height, isFullScreen);
    }
}
