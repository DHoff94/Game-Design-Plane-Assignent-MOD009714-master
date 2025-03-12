using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
using UnityEngine.SceneManagement;


public class Collectablescollected : MonoBehaviour
{
    public  TextMeshProUGUI pilots;
    public int collectible = 0;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
         if (collectible == 10)
        {
            SceneManager.LoadScene("WinScene");
        }
    }

    void OnTriggerEnter(Collider other)
    {
        if (other.transform.tag == ("Obstacle"))
        {
            collectible++;
            pilots.text = collectible.ToString();

        }
    }
}
 