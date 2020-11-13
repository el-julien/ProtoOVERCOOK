using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FoodPopZone : MonoBehaviour
{
  public GameObject popResource;

  void Start()
  {
    
  }

  void OnMouseDown()
  {
    OnInteraction();
  }

  public void OnInteraction()
  {
    GameObject avatar = GameObject.FindGameObjectWithTag("Player");
    GameObject resource = GameObject.Instantiate(popResource);
    resource.transform.SetParent(avatar.transform);
    resource.transform.localPosition = Vector3.forward;
  }
}
