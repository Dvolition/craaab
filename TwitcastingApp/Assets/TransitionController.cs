using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TransitionController : MonoBehaviour {

	public GameObject[] to;
	public int curIndex = 0;
	private int preIndex = -1;


	void Update() {

		if (Input.GetKeyDown (KeyCode.RightArrow)) {
			Next ();
		}

		if (Input.GetKeyDown (KeyCode.LeftArrow)) {
			Prev ();
		}
	
		if (curIndex != preIndex) {

			for (int i = 0; i < to.Length; i++) {
				to [i].gameObject.SetActive (false);
			}

			to [curIndex].gameObject.SetActive (true);
			preIndex = curIndex;
			
		}


	}

	public void Next() {

		if (curIndex < to.Length - 1) {
			curIndex++;
		}
	}

	public void Prev() {
		if (curIndex > 0) {
			curIndex--;
		}
	}

	public void GoTo(int index) {

		if (index < to.Length) {
			curIndex = index;
		}
	}
}
