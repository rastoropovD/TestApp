using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Zenject;

public class MenuBehavior : MonoBehaviour
{
    [Inject]
    private ISettingsService _settingsService;

    public Sprite SoundOnSprite;
    public Sprite SoundOffSprite;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
