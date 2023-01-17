using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class UILosePopup : MonoBehaviour 
{
    public SceneTransition toMap;
    public Text coinText;
    public Text skipCost;

    public PopupOpener shopPopup;

	void Start () 
    {
        coinText.text = CoreData.instance.GetPlayerCoin().ToString();
        skipCost.text = Configuration.instance.skipLevelCost.ToString();
	}

    public void ExitButtonClick()
    {
        SFXManager.instance.ButtonClickAudio();

        toMap.PerformTransition();
    }

    public void ReplayButtonClick()
    {
        SFXManager.instance.ButtonClickAudio();

		Configuration.instance.autoPopup = StageLoader.instance.Stage;

        toMap.PerformTransition();
    }

    public void SkipButtonClick()
    {
        SFXManager.instance.ButtonClickAudio();

        var cost = Configuration.instance.skipLevelCost;

        // enough coin
        if (cost <= CoreData.instance.playerCoin)
        {
            SFXManager.instance.CoinPayAudio();

            // reduce coin
            CoreData.instance.SavePlayerCoin(CoreData.instance.playerCoin - cost);
            
			var board = GameObject.Find("Board").GetComponent<itemGrid>();

            if (board)
            {
                // save info
                board.SaveLevelInfo();
            }

            // go to map with auto popup of next level
			Configuration.instance.autoPopup = StageLoader.instance.Stage + 1;

            toMap.PerformTransition();
        }
        else
        {
            shopPopup.OpenPopup();
        }
    }

    public void KeepButtonClick()
    {

		//AdmobSetting.instance.showRV ();
		// close the popup
		var popup = GameObject.Find("LosePopup(Clone)");

		if (popup)
		{
			popup.GetComponent<Popup>().Close();
		}
        
    }
}
