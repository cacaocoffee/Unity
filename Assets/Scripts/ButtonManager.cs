using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ButtonManager : MonoBehaviour
{
    public void OnClick(string type)
    {
        switch (type)
        {
            //MainActivePanel//
            case "Stat":
                UImanager.Instance.StatButton();
                //tuchManager.HiteffectOnoff = false;
                //SoundManager.Instance.PlayKnockSound();
                //UiManager.MainMenuOn = true;
                //UiManager.MainMenuNum = 0;
                //EventManager.Instance.HitEffectController();
                break;
            case "StatExit":
                UImanager.Instance.StatExitButton();
                //tuchManager.HiteffectOnoff = false;
                //SoundManager.Instance.PlayKnockSound();
                //UiManager.MainMenuOn = true;
                //UiManager.MainMenuNum = 0;
                //EventManager.Instance.HitEffectController();
                break;
        }
    }
}
