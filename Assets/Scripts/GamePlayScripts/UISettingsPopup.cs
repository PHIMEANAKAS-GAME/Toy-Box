using UnityEngine;
using System.Collections;

public class UISettingsPopup : MonoBehaviour 
{
    public SceneTransition toMap;
    public void GoToMap()
    {
        SFXManager.instance.ButtonClickAudio();

        toMap.PerformTransition();
    }

    public void Replay()
    {
        SFXManager.instance.ButtonClickAudio();

		Configuration.instance.autoPopup = StageLoader.instance.Stage;

        toMap.PerformTransition();
    }
	
	public void ButtonClickAudio()
    {
        SFXManager.instance.ButtonClickAudio();
    }

    public void CloseButtonClick()
    {
        SFXManager.instance.ButtonClickAudio();
		PlayerPrefs.SetInt ("canvas", 1);
        if (GameObject.Find("Board"))
        {
			GameObject.Find("Board").GetComponent<itemGrid>().state = GAME_STATE.WAITING_USER_SWAP;
        }
    }
}
