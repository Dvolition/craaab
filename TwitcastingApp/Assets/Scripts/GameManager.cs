using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class GameManager : MonoBehaviour {

    public Player myPlayer;

    public List<Player> players;

	// Use this for initialization
	void Start () {
	
	}


}

[System.Serializable]
public class Player{
    public string name;
    public Sprite iconImage; 
    public string job; //役職
    public string log; //最後の行動履歴
    public bool isLive; //今生きているか
}
