using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class Collectablescollected : MonoBehaviour
{
    public GameObject scoreText;
    public int theScore = 0;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
         
    }

    void OnTriggerEnter(Collider other)
    {
        scoreText.GetComponent<Text>().text = "Collectibles:" + theScore + "/10";
        theScore += 1;
    }
}
 