using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Link : MonoBehaviour
{
    string email = "fatinzaimi998@gmail.com";
    string subject, body;
    void Start()
    {

    }

    void Update()
    {

    }
    /*
    public void phone()
    {
        Application.OpenURL("tel://0350366980");
    }
    */
    public void emails()
    {
        Application.OpenURL("mailto:" + email + "?subject=" + subject + "&body=" + body);
    }
    /*
    
    
    public void maps()
    {
        Application.OpenURL("https://goo.gl/maps/4dTPF98UsswEAwCR9");
    }

   
    public void SendMessage()
    {
        string mobile_num = "60193827782";
        string message = "BizzAR View";

#if UNITY_ANDROID
        string URL = string.Format("sms:{0}?body={1}", mobile_num, message);
#endif

#if UNITY_IOS
            string URL = string.Format("sms:{0}?&body={1}",mobile_num,WWW.EscapeURL(message));
#endif

        //Execute Text Message
        Application.OpenURL(URL);
    }
    */
    public void Location()
    {
        Application.OpenURL("https://goo.gl/maps/f4zVAqBp7g8wB9uv5");
    }
    
    public void Whatsapp()
    {
        Application.OpenURL("http://www.wassap.my/+601113399178/Greeting");
    }
    
    public void Insta()
    {
        Application.OpenURL("https://instagram.com/atinsyu?utm_medium=copy_link");
    }
    
    public void YT()
    {
        Application.OpenURL("https://www.youtube.com/channel/UCZ-T97dUkqkG4H1b3Af2owQ");
    }
    public void Linkedin()
    {
        Application.OpenURL("https://www.linkedin.com/in/nurul-fatin-syuhada-mohamad-zaimi-486a191a2/");
    }
}
