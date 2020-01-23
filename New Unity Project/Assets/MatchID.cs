using System.Collections.Generic;
using UnityEngine;

public class MatchID : MonoBehaviour
{
    public List<NameID> nameIDList;

    private void OnTriggerEnter(Collider other)
    {
        var doWorkObj = other.GetComponent<DoWork>();
        var otherNameID = other.GetComponent<DoWork>().nameIdObj;
        
        foreach (var nameId in nameIDList)
        {
            if (nameId == otherNameID)
            {
                doWorkObj.Work();
            }
        }
    }
}
