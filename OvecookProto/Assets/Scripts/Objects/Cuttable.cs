using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cuttable : MonoBehaviour
{
    Droppable usedObject;
    // Start is called before the first frame update
    void Start()
    {
        usedObject = GetComponent<Droppable>();
    }

    public void Cut()
    {
        if (usedObject.currentLegume != Droppable.ObjectType.Assiette)
        {
            GameObject tempCut = Resources.Load("Cuttables/" + usedObject.currentLegume.ToString() + "_tranche") as GameObject;
            Destroy(usedObject.inGameObject);
            usedObject.inGameObject = Instantiate(tempCut);
            usedObject.inGameObject.transform.parent = transform;

        }
    }

}
