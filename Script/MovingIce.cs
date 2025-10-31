using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;

public class MovingIce : MonoBehaviour
{
    
    [SerializeField] private WaypointPath waypointPath;
    [SerializeField] private float speed;
    
    private int targetWaypointIndex;
    Vector3 playerScale;
    Vector3 oldParent;

    private Transform previousWaypoint;
    private Transform targetWaypoint;

    private float timeToWayPoint;
    private float elapsedTime;
    // Start is called before the first frame update
    void Start()
    {
        TargetNextWaypoint();
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        elapsedTime += Time.deltaTime;
        float elapsedPercentage = elapsedTime / timeToWayPoint;
        elapsedPercentage = Mathf.SmoothStep(0, 1, elapsedPercentage);      
        transform.position = Vector3.Lerp(previousWaypoint.position, targetWaypoint.position, elapsedPercentage);
        transform.rotation= Quaternion.Lerp(previousWaypoint.rotation, targetWaypoint.rotation, elapsedPercentage);

        if(elapsedPercentage >= 1)
        {
            TargetNextWaypoint();
        }
    }

    private void TargetNextWaypoint()
    {
        previousWaypoint = waypointPath.GetWaypoint(targetWaypointIndex);
        targetWaypointIndex = waypointPath.GetNextWaypointIndex(targetWaypointIndex);
        targetWaypoint = waypointPath.GetWaypoint(targetWaypointIndex);

        elapsedTime = 0;

        float distanceToWaypoint = Vector3.Distance(previousWaypoint.position, targetWaypoint.position);
        timeToWayPoint = distanceToWaypoint / speed;
    }

    private void OnTriggerEnter(Collider other)
    {
        
      
         other.transform.SetParent(transform);
          
        
    }

    private void OnTriggerExit(Collider other)
    {
        other.transform.SetParent(null);
        other.transform.localScale = new Vector3(1f,1f,1f);

    }

}
