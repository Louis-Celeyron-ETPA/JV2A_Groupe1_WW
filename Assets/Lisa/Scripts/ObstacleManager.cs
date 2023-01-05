using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObstacleManager : MonoBehaviour
{
    public List<Obstacle> obstacles;
    public float speed=0.01f; 
    public float DeadZone=0.01f;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(obstacles.Count>0)
        {
            for (int i = 0; i < obstacles.Count; i++)
            {
                var obstacle = obstacles[i];
                obstacle.Move(speed);
                DestroyObstacle(obstacle);
            }
        }
    }

    private void DestroyObstacle(Obstacle obstacle)
    {
        if(obstacle.transform.localPosition.x<=DeadZone)
        {
            obstacles.Remove(obstacle);
            Destroy(obstacle.gameObject);
        }
    }
}
