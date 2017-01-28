using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class LoadingPanelScript : MonoBehaviour {

    [SerializeField]
    private Text loadText;

	
	// Update is called once per frame
	void Update () {
	
	}

    public void AnimationStep()
    {
        loadText.text += ".";
        if(loadText.text == "Now Loading ....")
        {
            loadText.text = "Now Loading ";
        }
    }
}
