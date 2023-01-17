using UnityEngine;
/** Rectangle transform rotator */
public class toyAnimation : MonoBehaviour {

    public void log(string s){
        Debug.Log(s);
    }
    RectTransform tr;

	public float range = 10f;
	public float Speed = 0.5f;

    Quaternion target;

	void Start () {
		tr = GetComponent<RectTransform>();
        target = Quaternion.Euler(0,0,range);
	}

	void Update () {

        if(
            target.Equals(Quaternion.Euler(0,0,range)) &&
            (int)(tr.rotation.eulerAngles.z +0.5f) == (int)target.eulerAngles.z
        ){
            //log("A");
            target = Quaternion.Euler(0,0,-range);
        }

        if(
            target.Equals(Quaternion.Euler(0,0,-range)) &&
            (int)(tr.rotation.eulerAngles.z +0.5f) == (int)target.eulerAngles.z
        ){
            //log("B");
            target = Quaternion.Euler(0,0,range);
        }


		tr.rotation = Quaternion.RotateTowards(tr.rotation,target,Speed);
	}
}
