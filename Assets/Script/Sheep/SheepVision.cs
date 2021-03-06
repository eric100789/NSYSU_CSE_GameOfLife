using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SheepVision : MonoBehaviour
{
    [SerializeField] private string targetObjectTag;
    public bool findTarget = false;
    public GameObject targetObject;

    private void OnTriggerStay2D(Collider2D other) 
    {
        if(other.gameObject.tag == targetObjectTag)
        {
            findTarget = true;
            targetObject = other.gameObject;
        }
    }

    private void OnTriggerExit2D(Collider2D other) 
    {
        if(other.gameObject.tag == targetObjectTag)
        {
            findTarget = false;
        }
    }
}
