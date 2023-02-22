using System.Collections;
using System.Collections.Generic;
using UnityEngine;

using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{
    // Start is called before the first frame update
   public void PlayGame ()
    {
        SceneManager.LoadScene("Level01");
    }

    // Update is called once per frame
    public void QuitGame ()
    {
        Debug.Log("Quit Done!");
        Application.Quit();
    }
}
