using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ALLCollected : MonoBehaviour
{
    public int numberOfCollectables = 10;
    public int collectedCollectables = 0;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (numberOfCollectables == collectedCollectables)
        {
            SceneManager.LoadScene("Win Scene");
        }
    }
}