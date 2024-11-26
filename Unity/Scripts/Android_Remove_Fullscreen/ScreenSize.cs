using UnityEngine;

public class ScreenSize : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        Screen.SetResolution(0, 0, false); // Width, Height, fullscreen
        Screen.fullScreen = false;
        ApplicationChrome.statusBarState = ApplicationChrome.navigationBarState = ApplicationChrome.States.Visible; //To have same background on status bar but not nav bar
        //ApplicationChrome.statusBarState = ApplicationChrome.navigationBarState = ApplicationChrome.States.TranslucentOverContent; //To have same background on status bar and nav bar
    }

  
}
