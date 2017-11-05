using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Tile
{
    public GameObject tileObj;
    public string type;
    public Tile(GameObject obj, string t)
    {
        tileObj = obj;
        type = t;
    }
}
    

public class CreateGame : MonoBehaviour {
    GameObject tile1 = null;
    GameObject tile2 = null;

    public GameObject[] tile;
    List<GameObject> tileBank = new List<GameObject>();
    static int rows = 9;
    static int cols = 6;
    Tile[,] tiles = new Tile[cols, rows];

    // Use this for initialization
    void Start () {

        int numCopies = (rows * cols)/3;
        for(int i = 0; i<numCopies; i++)
        {
            for(int j = 0; j<tile.Length; j++)
            {
                GameObject o = (GameObject)Instantiate(tile[j],
                    new Vector3(-10, -10, 0),
                    tile[j].transform.rotation);
                o.SetActive(false);
                tileBank.Add(o);
            }
        }
        //initialize tile grid
        for (int r = 0; r < rows; r++)
        {
            for(int c = 0; c < cols; c++)
            {
                Vector3 tilePos = new Vector3(c, r, 0);
                
            }
        }
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
