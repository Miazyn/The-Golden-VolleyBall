using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Cutscene_Management : MonoBehaviour
{
    public GameObject WhereAmIText;
    Animator anima;
    public GameObject topLiner, bottomLiner;

    bool IsTextOnScreen = false;
    // Start is called before the first frame update
    void Start()
    {
        anima = gameObject.GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        WhereAmIText.SetActive(IsTextOnScreen);
        bottomLiner.SetActive(IsTextOnScreen);
        topLiner.SetActive(IsTextOnScreen);
    }

    public void TextFalse()
    {
        IsTextOnScreen = false;

    }
    //TEXT 1st Cutscene Part
    public void WhereAmI()
    {

        IsTextOnScreen = true;
        Invoke("CutscenePartTwo", 5f);
    }
    //Play 2nd Cutscene Part
    public void CutscenePartTwo()
    {
        

        anima.Play("Cutscene_Part_Two", 0, 0f);
        

    }
    //TEXT 2ND Cutscene Part
    public void Cutscene_Two_Text()
    {
        WhereAmIText.GetComponent<Text>().text = "But I found a note. It confused me but it was my only lead.";
        IsTextOnScreen = true;
    }
}
