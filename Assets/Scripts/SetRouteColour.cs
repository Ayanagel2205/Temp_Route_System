using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SetRouteColour : MonoBehaviour
{
    public enum ColourOptions{

        White,
        Black,
        Blue,
        Green,
        Orange,
        Red,
        Purple,
        Yellow,
        Gold
         
}



    [SerializeField] private GenColours gameColours;
    [SerializeField] private ColourOptions routeColour;
    [SerializeField] private GameObject routeContainor;
    
    private SpriteRenderer[] routeRenderers;

    private void Awake()
    {
        routeRenderers = new SpriteRenderer [routeContainor.transform.childCount];
        //setRouteColour();
    }


    // Start is called before the first frame update
    void Start()
    {
        setRouteColour(); 
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    /*public void popRouteRendArr()
    {
        for (int populate=0; populate< routeContainor.transform.childCount; populate++)
        {
            routeRenderers[populate] = routeContainor.transform.GetChild(populate).GetComponentInChildren<SpriteRenderer>();

        }


    }*/




    public void changeRouteColour(GameObject containRoute,Color32 colour)
    {
        for (int populate = 0; populate < containRoute.transform.childCount; populate++)
        {
            routeRenderers[populate] = containRoute.transform.GetChild(populate).GetComponentInChildren<SpriteRenderer>();

        }

        for (int change=0; change< routeRenderers.Length; change++)
        {
            routeRenderers[change].color = colour;


        }




    }


    public void setRouteColour()
    {

        switch (routeColour)
        {

            case ColourOptions.White:
                changeRouteColour(routeContainor,gameColours.getColourArr()[0]);
                break;

            case ColourOptions.Black:
                changeRouteColour(routeContainor, gameColours.getColourArr()[1]);
                break;

            case ColourOptions.Blue:
                changeRouteColour(routeContainor, gameColours.getColourArr()[2]);
                break;

            case ColourOptions.Green:
                changeRouteColour(routeContainor, gameColours.getColourArr()[3]);
                break;

            case ColourOptions.Orange:
                changeRouteColour(routeContainor, gameColours.getColourArr()[4]);
                break;

            case ColourOptions.Red:
                changeRouteColour(routeContainor, gameColours.getColourArr()[5]);
                break;

            case ColourOptions.Purple:
                changeRouteColour(routeContainor, gameColours.getColourArr()[6]);
                break;

            case ColourOptions.Yellow:
                changeRouteColour(routeContainor, gameColours.getColourArr()[7]);
                break;

            case ColourOptions.Gold:
                changeRouteColour(routeContainor, gameColours.getColourArr()[8]);
                break;




        }




    }

    




}
