
using UnityEngine;

public class Quit : MonoBehaviour
{//This script is supposed to quit th application when 'Q' is pressed
    void Update()
    {
        //When the 'Q' button is pressed the application quits
        if (Input.GetKeyDown(KeyCode.Q))
        {
            Application.Quit();
        }
    }
}
