using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class ClaimRoute : MonoBehaviour
{

    [SerializeField] private GenColours generalColours;
    [SerializeField] private Colouring colouringScript;

    [SerializeField] private TMP_Text Error_Text;
    [SerializeField] private GameObject Error_Obj;
    [SerializeField] private GameObject myTrainContainor;
    [SerializeField] private GameObject myButton;
    [SerializeField] private GameObject myRouteContainor;
    [SerializeField] private GameObject myCardHand;



    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void populateRouteRendArr()
    {


    }

    private void setTrainPiecesActive()
    {



    }

    private int countCardsSameColour()
    {
        Color32 currentRouteClr = myRouteContainor.GetComponentInChildren<SpriteRenderer>().color;
        int sameCard = 0;

        for (int count =0; count< myCardHand.transform.childCount;count++)
        {
            if (currentRouteClr.Equals(colouringScript.getCardColour()))
            {
                sameCard++;

            }

        }
        return sameCard;


    }

    public void claimRoute() {

        if(countCardsSameColour()>= myRouteContainor.transform.childCount)
        {
            myTrainContainor.SetActive(true);



        }
        else
        {
            Error_Obj.SetActive(true);
            Error_Text.text = $"Insufficient Like Cards";


        }
    
    }


}
