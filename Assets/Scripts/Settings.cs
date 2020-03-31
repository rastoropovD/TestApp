using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UniRx;
using UniRx.Triggers;
using Zenject;


public class Settings : MonoBehaviour
{
    [Inject]
    private ISettingsService _settingsService;

    public Button SoundButton;
    public Sprite SoundOn;
    public Sprite SoundOff;

    public Button MusicButton;
    public Sprite MusicOn;
    public Sprite MusicOff;

    // Start is called before the first frame update
    void Start()
    {
        var config = _settingsService.Get();
        config.IsSoundEnabled.Subscribe(enabled => SoundButton.image.sprite = enabled ? SoundOn : SoundOff);
        config.IsMusicEnabled.Subscribe(enabled => MusicButton.image.sprite = enabled ? MusicOn : MusicOff);
        SoundButton.onClick.AddListener(() => _settingsService.Update(SettingsType.Sound));
        MusicButton.onClick.AddListener(() => _settingsService.Update(SettingsType.Music));
    }
}
