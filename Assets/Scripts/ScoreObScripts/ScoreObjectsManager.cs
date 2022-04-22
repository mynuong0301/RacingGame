using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScoreObjectsManager : MonoBehaviour
{
    public List<Mesh> scoreMeshes; //0:cube.005; 1:cube.007; 2: cube.014
    public List<Material> colors; //0: Red; 1: Blue; 2: Yellow
    public GameObject[] scoreObjects;

    // Start is called before the first frame update
    void Start()
    {
        InitScoreObjects();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void InitScoreObjects()
    {
        for (int i = 0; i < scoreObjects.Length; i++)
        {
            int colorId = Random.Range(0, colors.Count);
            scoreObjects[i].GetComponent<MeshRenderer>().material = colors[colorId];
            scoreObjects[i].GetComponent<MeshRenderer>().enabled = true;

            Material material = scoreObjects[i].GetComponent<MeshRenderer>().material;

            switch (colorId)
            {
                case 0:
                    scoreObjects[i].GetComponent<MeshFilter>().mesh = scoreMeshes[colorId];
                    scoreObjects[i].AddComponent<RedObjects>();
                    break;
                case 1:
                    scoreObjects[i].GetComponent<MeshFilter>().mesh = scoreMeshes[colorId];
                    scoreObjects[i].AddComponent<BlueObjects>();
                    break;
                case 2:
                    scoreObjects[i].GetComponent<MeshFilter>().mesh = scoreMeshes[colorId];
                    scoreObjects[i].AddComponent<YellowObjects>();
                    break;
            }

            //if (colorId == 0)
            //{
            //    Debug.Log(material.name + colors[0].name);
            //    scoreObjects[i].GetComponent<MeshFilter>().mesh = scoreMeshes[0];
            //    //scoreObjects[i].AddComponent<RedObjects>();
            //    scoreObjects[i].GetComponent<BlueObjects>().enabled = false;
            //    scoreObjects[i].GetComponent<YellowObjects>().enabled = false;
            //}
            //else
            //    if (material == colors[1])
            //    {
            //        scoreObjects[i].GetComponent<MeshFilter>().mesh = scoreMeshes[1];
            //    //scoreObjects[i].AddComponent<BlueObjects>();
            //    scoreObjects[i].GetComponent<RedObjects>().enabled = false;
            //    scoreObjects[i].GetComponent<YellowObjects>().enabled = false;
            //}
            //else
            //    if (material == colors[2])
            //    {
            //        scoreObjects[i].GetComponent<MeshFilter>().mesh = scoreMeshes[2];
            //    //scoreObjects[i].AddComponent<YellowObjects>();
            //    scoreObjects[i].GetComponent<RedObjects>().enabled = false;
            //    scoreObjects[i].GetComponent<BlueObjects>().enabled = false;
            //}
            //Debug.Log(i + ": " + material.name + " - " + scoreObjects[i].GetComponent<MeshFilter>().mesh.name);
        }
    }
}
