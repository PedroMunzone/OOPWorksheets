using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{

    private GameObject myprefab;
    private float xpos = 0;
    private float ypos = 0;
    private float xmin, xmax, ymin, ymax;
    private Camera mycamera;

    // Start is called before the first frame update
    void Start()
    {
        myprefab = Resources.Load("Ball") as GameObject;
        mycamera = Camera.main;
        xmin = mycamera.ViewportToWorldPoint(new Vector3(0f, 0f, 0f)).x;
        xmax = mycamera.ViewportToWorldPoint(new Vector3(1f, 0f, 0f)).x;
        ymin = mycamera.ViewportToWorldPoint(new Vector3(0f, 0f, 0f)).y;
        ymax = mycamera.ViewportToWorldPoint(new Vector3(0f, 1f, 0f)).y;
        //creating random balls and storing into xpos, ypos
        //xpos = Random.Range(xmin, xmax);
        //ypos = Random.Range(ymin, ymax);
        Instantiate(myprefab, new Vector3(xmin, ymax, 0f), Quaternion.identity);
        Instantiate(myprefab, new Vector3(ymax, xmin, 0f), Quaternion.identity);
        Instantiate(myprefab, new Vector3(xmax, ymax, 0f), Quaternion.identity);
        Instantiate(myprefab, new Vector3(xmin, ymin, 0f), Quaternion.identity);

    }

    // Update is called once per frame
    void Update()
    {
        


    }
}
