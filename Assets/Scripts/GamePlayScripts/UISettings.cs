using UnityEngine;
using System.Collections;

public class UISettings : MonoBehaviour 
{
//	public itemBoard board;
    public PopupOpener settingsPopup;

    public void SettingsClick()
    {

		Debug.Log ("setting button clicked");
            SFXManager.instance.ButtonClickAudio();

            settingsPopup.OpenPopup();

//            board.state = GAME_STATE.OPENING_POPUP;

            // ads
              
    }
}
