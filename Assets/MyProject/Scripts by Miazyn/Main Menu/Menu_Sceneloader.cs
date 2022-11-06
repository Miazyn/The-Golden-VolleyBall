using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Menu_Sceneloader : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void OnStartClicked()
    {

        SceneManager.LoadScene("Starting_Cutscene", LoadSceneMode.Single);

    }

    public void OnQuitClicked()
    {
        Application.Quit();
    }
}
