using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cutscene_Management : MonoBehaviour
{
    public GameObject WhereAmIText;
    private Animation anim;
    // Start is called before the first frame update
    void Start()
    {
        anim = GameObject.GetComponent<Animation>();   
    }

    // Update is called once per frame
    void Update()
    {
        
    }


    public void WhereAmI()
    {
        
        WhereAmIText.SetActive(true);
        Invoke("CutscenePartTwo", 3f);
    }

    public void CutscenePartTwo()
    {
        Debug.LogError("Start second cutscene");
        anim.play();
    }
}
