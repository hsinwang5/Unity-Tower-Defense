using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Waypoint1 : MonoBehaviour
{
    [SerializeField] Tower towerPrefab;

    [SerializeField] bool isPlaceable;

    public bool IsPlaceable {get {return isPlaceable; } } 

    private void Start() 
    {
        Debug.Log("I'm running Waypoints script")    ;
    }

    // private void OnMouseDown() 
    // {
    //     if (isPlaceable) 
    //     {
    //         bool isPlaced = towerPrefab.CreateTower(towerPrefab, transform.position);
    //         //Instantiate(towerPrefab, transform.position, Quaternion.identity);
    //         isPlaceable = !isPlaced;
    //         Debug.Log("Tower Created!");
    //     }
    // }

    
}
