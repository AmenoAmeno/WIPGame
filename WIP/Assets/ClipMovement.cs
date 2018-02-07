using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ClipMovement : MonoBehaviour
{
    public GameObject Char;
    public GameObject Prefab_WayPoint;

    public float Speed;
    
    Vector3 targetPosition;
    Vector3 CharCurrentPos;
    //Vector3 CharNewPos;

    void Start()
    {
        //CharCurrentPos = transform.position;
        targetPosition = transform.position;
        Speed = .9f;
    }
    void Update()
    {
       

        if (Input.GetMouseButtonDown(0))
        {
            Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
            RaycastHit hit;

            if (Physics.Raycast(ray, out hit))
            {
                
                targetPosition = hit.point;
                //CharNewPos = targetPosition;
               
                Instantiate(Prefab_WayPoint, hit.point, Quaternion.identity);

               // GameObject myObject = GameObject.FindGameObjectWithTag("Char");
               // myObject.transform.position = CharCurrentPos;
               // CharNewPos = Vector3.Lerp(CharCurrentPos, targetPosition, Speed);

                //myObject.transform.position = CharNewPos;
            }


        }
    }
}