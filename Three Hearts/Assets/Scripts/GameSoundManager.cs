using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameSoundManager : MonoBehaviour
{
    bool muted = false;

    [SerializeField] Button soundBtn;
    [SerializeField] Sprite muteSprite;
    [SerializeField] Sprite unmuteSprite;

    public void MuteSound()
    {
        if (muted)
        {
            AudioListener.volume = 1;
            soundBtn.GetComponent<Image>().sprite = unmuteSprite;
            muted = false;
        }
        else
        {
            AudioListener.volume = 0;
            soundBtn.GetComponent<Image>().sprite = muteSprite;
            muted = true;
        }
    }
}
