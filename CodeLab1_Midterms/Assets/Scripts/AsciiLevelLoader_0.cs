using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.IO;

public class AsciiLevelLoader_0 : MonoBehaviour
{
    public GameObject Ground;
    public GameObject Fire;
    public GameObject Wall;
    
    // Start is called before the first frame update
    void Start()
    {
        
        string filePath = Application.dataPath + "/level0.txt"; //filePath

        if (!File.Exists(filePath)) //if file the does not exists
        {
            File.WriteAllText(filePath, "X"); //make a file with a single X in it
        }

        string[] inputLines = File.ReadAllLines(filePath); //Get all the lines from the file

        for (int y = 0; y < inputLines.Length; y++) //Loop to go through all the lines
        {
            string line = inputLines[y];

            for (int x = 0; x < line.Length; x++)
            {
                if (line[x] == 'X')
                {
                    GameObject newGround = Instantiate(Ground);
                    newGround.transform.position = new Vector2(x - line.Length / 2f, inputLines.Length / 2f - y);
                }
                else if (line[x] == 'F')
                {
                    GameObject newWater = Instantiate(Fire);
                    Fire.transform.position = new Vector2(x - line.Length / 2f, inputLines.Length / 2f - y);
                }
                else if (line[x] == 'W')
                {
                    GameObject newWater = Instantiate(Wall);
                    Wall.transform.position = new Vector2(x - line.Length / 2f, inputLines.Length / 2f - y);
                }
            }
        }
    }
}
