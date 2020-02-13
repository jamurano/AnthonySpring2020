using System;
using System.Collections.Generic;
using UnityEngine;

public class MatchIDBehaviour : MonoBehaviour
{
    public List<NameID> NameIds;
    private NameID otherIDObj;

    public List<DoWork> DoWorks;

    private void OnTriggerEnter(Collider other)
    {
        otherIDObj = other.GetComponent<IDBehaviour>().nameIDObjs;
    }

    private void CheckID()
    {
        foreach (var obj in NameIds)
        {
            if (obj == otherIDObj)
            {
                if (obj == otherIDObj)
                {
                    foreach (var job in DoWorks)
                    {
                        job.Work();
                    }
                }
            }  
        }
    }
}
