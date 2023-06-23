using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GenColours : MonoBehaviour
{
    [SerializeField] private GameObject Error_Message_Obj;

    [SerializeField] private Color32 selectPink = new Color32(180, 20, 90, 255);
    [SerializeField] private Color32 selectBlack = new Color32(0, 0, 0, 255);
    [SerializeField] private Color32 selectBlue = new Color32(0, 90, 255, 255);
    [SerializeField] private Color32 selectRed = new Color32(255, 0, 0, 255);
    [SerializeField] private Color32 selectOrange = new Color32(254, 161, 0, 255);
    [SerializeField] private Color32 selectWhite = new Color32(250, 250, 255, 255);
    [SerializeField] private Color32 selectGreen = new Color32(0, 254, 111, 255);
    [SerializeField] private Color32 selectYellow = new Color32(254, 224, 0, 255);
    [SerializeField] private Color32 selectGold = new Color32(152, 120, 59, 255);



    private Color32[] gameColours;

    private void Awake()
    {
        addColours();
    }


    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }


    public void addColours()
    {

        gameColours = new Color32[] { selectWhite, selectBlack, selectBlue, selectGreen, selectOrange, selectRed, selectPink, selectYellow, selectGold };

    }

    public Color32[] getColourArr()
    {
        return gameColours;

    }

    public void closeError()
    {
        Error_Message_Obj.SetActive(false);
    }


}
