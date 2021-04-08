using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Networking;

public class CanvasButtons : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void EmailButton()
    {
        string email = "santiagopemo@gmail.com";
        string subject = MyEscapeURL("Santiago AR Business Card");
        string body = MyEscapeURL("Hi I just want to say hello.");
        Application.OpenURL("mailto:" + email + "?subject=" + subject + "&body=" + body);
    }

    string MyEscapeURL (string url)
    {
        return UnityWebRequest.EscapeURL(url).Replace("+","%20");
    }

    public void LinkedInButton()
    {
        Application.OpenURL("https://www.linkedin.com/in/santiago-pe%C3%B1a-mosquera-abaa20196/");
    }

    public void GitHubButton()
    {
        Application.OpenURL("https://github.com/santiagopemo");
    }

    public void TwitterButton()
    {
        Application.OpenURL("https://twitter.com/santiagopemo");
    }
}
