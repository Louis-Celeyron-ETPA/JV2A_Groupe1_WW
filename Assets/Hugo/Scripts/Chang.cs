using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Hugo
{
    public class Chang : MonoBehaviour
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
            Trajectoire trajectoireQuiMeTraverse = other.GetComponent<Trajectoire>();
            if (trajectoireQuiMeTraverse != null)
            {
                if (trajectoireQuiMeTraverse.direction == "haut")
                {
                    trajectoireQuiMeTraverse.transform.position = new Vector3(trajectoireQuiMeTraverse.transform.position.x, trajectoireQuiMeTraverse.transform.position.y, -51);
                    //trajectoireQuiMeTraverse.direction = "bas";
                }
                else
                {
                    trajectoireQuiMeTraverse.transform.position = new Vector3(trajectoireQuiMeTraverse.transform.position.x, trajectoireQuiMeTraverse.transform.position.y, 37);
                    //trajectoireQuiMeTraverse.direction = "haut";
                }
            }
        }
    }
}

