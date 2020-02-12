using UnityEngine;

public class Health : ScriptableObject
{
    public FloatData healthData;
    
    public FloatData[] damagerList;

    public void ChangeHealth(FloatData incomingDamager)
    {
        foreach (var damager in damagerList)
        {
            if (damager == incomingDamager)
            {
                healthData.UpdateValue(damager.Value);
            }
        }
    }

}
