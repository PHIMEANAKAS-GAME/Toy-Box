using UnityEngine;
using System.Collections;
using UnityEngine.UI;


public class LifePopup : MonoBehaviour 
{
    public Text lifeRemain;
    public Text recoveryCost;
    public GameObject recoveryButton;

    int cost;

	// Use this for initialization
	void Start () 
    {
        if (Configuration.instance.life < Configuration.instance.maxLife)
        {
            lifeRemain.text = "Life: " + Configuration.instance.life.ToString() + "/" + Configuration.instance.maxLife.ToString();

            cost = Configuration.instance.recoveryCostPerLife * (Configuration.instance.maxLife - Configuration.instance.life);

            recoveryCost.text = cost.ToString();;
        }
        else
        {
            lifeRemain.text = "Life: " + Configuration.instance.maxLife.ToString() + "/" + Configuration.instance.maxLife.ToString();
            recoveryButton.SetActive(false);
            recoveryCost.gameObject.transform.parent.gameObject.SetActive(false);
        }
	}
	
    public void ButtonClickAudio()
    {
        SFXManager.instance.ButtonClickAudio();
    }

    public void RecoveryButtonClick()
    {
		//
		//GameObject.Find("Video Ads").GetComponent<chartboostVideoAds>().showCBRewardedVid();
      
    }
}
