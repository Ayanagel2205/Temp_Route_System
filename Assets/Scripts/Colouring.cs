using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Colouring : MonoBehaviour
{
    // Start is called before the first frame update

    [SerializeField] private GenColours genColours;
    [SerializeField] private GameObject cardObj;
    [SerializeField] private GameObject routeObj;

    private Color32[] gameColours;
   
    private SpriteRenderer[] myCardSpriteRend;
    private SpriteRenderer[] myRouteSpriteRend;

    private Color32 currentCardButton;
    private Color32 chosenRouteColour;

    private void Awake()
    {

        myCardSpriteRend = new SpriteRenderer[cardObj.transform.childCount];
        myRouteSpriteRend = new SpriteRenderer[routeObj.transform.childCount];
        
    }



    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void populateCardArr()
    {
        
        for (int loop = 0; loop < cardObj.transform.childCount; loop++)
        {
            myCardSpriteRend[loop] = cardObj.transform.GetChild(loop).GetComponentInChildren<SpriteRenderer>();

        }


    }
   
 
    public void colourCards()
    {
        int endNum = genColours.getColourArr().Length + 1;
        int index = Random.Range(-1, endNum);
        Color32 currentCardColour = genColours.getColourArr()[index];
        populateCardArr();
        

        for (int i = 0; i < myCardSpriteRend.Length; i++)
        {

            myCardSpriteRend[i].color = currentCardColour;

            currentCardButton = currentCardColour;

        }



    }

    public void populateRouteArr()
    {

        for (int value = 0; value < routeObj.transform.childCount; value++)
        {
            myRouteSpriteRend[value] = routeObj.transform.GetChild(value).GetComponentInChildren<SpriteRenderer>();

        }

    }



    public void colourRoute()
    {
        int lastNum = genColours.getColourArr().Length + 1;
        int colourIndex = Random.Range(-1, lastNum);
        Color32 currentRouteColour = genColours.getColourArr()[colourIndex];

        populateRouteArr();

        for (int j = 0; j < myCardSpriteRend.Length; j++)
        {

            myRouteSpriteRend[j].color = currentRouteColour;

            chosenRouteColour = currentRouteColour;

        }




    }

    public Color32 getCardColour()
    {
        return currentCardButton;

    }

    public Color32 getRouteColour()
    {

        return chosenRouteColour;

    }




}
