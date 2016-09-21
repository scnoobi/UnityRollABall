using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CheckPointSystem : MonoBehaviour {

    public static CheckPointSystem instance;

    public Rigidbody player;
    

    public List<Transform> listOfCheckPoints = new List<Transform>();
    private int currentResetPoint = 0;

    void Awake()
    {
        instance = this;
    }


    public void ResetPlayer()
    {

        if (currentResetPoint > listOfCheckPoints.Count - 1) 
            currentResetPoint = listOfCheckPoints.Count - 1;

        player.velocity = Vector3.zero;
        player.angularVelocity = Vector3.zero;
        player.transform.position = listOfCheckPoints[currentResetPoint].position;
    }

    public void SetResetPoint(int resetPoint)
    {
        if(currentResetPoint < resetPoint)
        {
            currentResetPoint = resetPoint;
        }
    }
}
