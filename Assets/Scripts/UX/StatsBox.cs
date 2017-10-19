using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class StatsBox : TileData
{
    public GameObject windowManagerPrefab;
    //public GameObject tileContentsPrefab;
    public GameObject infoPanelPrefab;
    public Text berryFoodPrefab;
    public Text biomePrefab;
    public GameObject noClickPrefab;
    public GameObject exitButtonPrefab;

    public void Awake()
    {
        /*
        GameObject tileContents = Instantiate(tileContentsPrefab, new Vector2(0, 0), Quaternion.identity);
        tileContents.transform.SetParent(GameObject.FindGameObjectWithTag("BaseTile").transform, false);
        TileData instanceData = tileContents.GetComponent<TileData>();
        private string replacementText = "Scott has berries: " + tileContents.getNumBerries();
        */
        




    }

    public void OnMouseDown()
    {
        // if (toggle == false)
        // {
        int numBerries = getNumBerries();
        int numGrass = getNumGrass();
        int numNuts = getNumNuts();
        int numLeaves = getNumLeaves();
        int numMeat = getNumAmbientMeat();
        string biome = getTileType();

        GameObject windowManager = Instantiate(windowManagerPrefab, new Vector3(0, 0, 5), Quaternion.identity) as GameObject;
        windowManager.transform.SetParent(GameObject.FindGameObjectWithTag("Canvas").transform, false);
        windowManager.gameObject.tag = "WindowManager";

        string foodTypes = "Berries: " + numBerries.ToString() + "\nGrass: " + numGrass.ToString() + "\nNuts: " + numNuts.ToString() + "\nLeaves: " + numLeaves.ToString() + "\nMeat: " + numMeat.ToString();
        string biomeType = biome;

        Text foods = Instantiate(berryFoodPrefab, new Vector3(-200, -50, -5), Quaternion.identity) as Text;
        foods.transform.SetParent(GameObject.FindGameObjectWithTag("WindowManager").transform, false);

        Text biomeTitle = Instantiate(biomePrefab, new Vector3(0, 125, -5), Quaternion.identity) as Text;
        biomeTitle.transform.SetParent(GameObject.FindGameObjectWithTag("WindowManager").transform, false);

        GameObject infoPanel = Instantiate(infoPanelPrefab, new Vector3(0, 0, 5), Quaternion.identity) as GameObject;
        infoPanel.transform.SetParent(GameObject.FindGameObjectWithTag("WindowManager").transform, false);

        GameObject noClick = Instantiate(noClickPrefab, new Vector3(500, 300, -1), Quaternion.identity) as GameObject;
        noClick.gameObject.tag = "WindowManager";

        GameObject exitButton = Instantiate(exitButtonPrefab, new Vector3(335, 150, -5), Quaternion.identity) as GameObject;
        exitButton.transform.SetParent(GameObject.FindGameObjectWithTag("WindowManager").transform, false);

        //berryFood = GetComponent<Text>();
        foods.text = foodTypes;
        biomeTitle.text = biomeType;


        // }
    }


}
























    /*
    private bool clickedOn = false;

    private void OnGUI()
    {
        if(!clickedOn)
        {
            return;
        }

        Vector3 screenPos = transform.position;
        Rect menuRect = new Rect(screenPos.x, screenPos.y, 1, 1);

        GUI.Label(menuRect, "Fuck you.");
        clickedOn = false;
    }
    private void OnMouseDown()
    {
        clickedOn = true;
    }
    */

