using UnityEngine;
using System.Collections;

public class Managers : MonoBehaviour {

    public static Managers instance;

    public HTTPMethodScript httpMethodScript;



	// Use this for initialization
	void Start () {
        if( instance == null ){
            instance = this;
            DontDestroyOnLoad(gameObject);
        }else{
            GameObject.Destroy(gameObject);
        }

	}

}
