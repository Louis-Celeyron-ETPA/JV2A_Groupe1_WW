using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Lisa_RecupCarrot : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Player")
        {
            other.GetComponent<Lisa_ScoreKeeper>().RaiseScore(1);
            Destroy(gameObject);
        }
    }
}
