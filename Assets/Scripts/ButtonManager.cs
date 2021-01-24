using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ButtonManager : MonoBehaviour
{
    public void OnClick(string type)
    {
        int i=0;
        switch (type)
        {
            //MainActivePanel//
            case "ButtonsOpen":
                if (i==0)
                {
                    UImanager.Instance.ButtonsOpen();
                    i = 1;
                }
                else if (i==1)
                { //현재 실행이 안되고 있음
                    UImanager.Instance.ButtonsClose();
                    i = 0;
                }
                break;
            case "Stat":
                UImanager.Instance.StatButton();
                UImanager.Instance.ButtonsClose();
                break;
            
            case "StatExit":
                UImanager.Instance.StatExitButton();
                //tuchManager.HiteffectOnoff = false;
                //SoundManager.Instance.PlayKnockSound();
                //UiManager.MainMenuOn = true;
                //UiManager.MainMenuNum = 0;
                //EventManager.Instance.HitEffectController();
                break;
            case "Shop":
                UImanager.Instance.ShopButton();
                UImanager.Instance.ButtonsClose();
                break;
            case "ShopExit":
                UImanager.Instance.ShopExitButton();
                break;
            case "Skill":
                UImanager.Instance.SkillButton();
                UImanager.Instance.ButtonsClose();
                break;
            case "SkillExit":
                UImanager.Instance.SkillExitButton();
                break;
        }
    }
}
