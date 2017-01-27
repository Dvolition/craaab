using UnityEngine;
using System.Collections;

public class HTTPMethodScript : MonoBehaviour {

    public string msg;
    public GameObject LoadingPanel;


    public void SendMessageMethod(string name)
    {
        msg = name;
        StartCoroutine(SendMessage());
        LoadingPanel.SetActive(true);
    }

    public IEnumerator SendMessage()
    {

        string url = "https://script.google.com/macros/s/AKfycbzRiGiNiUJRjx1Gmi5cxzwYZpXfBwH7KZvhLz6JuZ3jHy2ha5E/exec";

        WWWForm form = new WWWForm();
        form.AddField("user_name",msg);


        WWW www = new WWW(url, form);
        yield return www;

        yield return new WaitForSeconds(2f);
        LoadingPanel.SetActive(false);
    }
}
