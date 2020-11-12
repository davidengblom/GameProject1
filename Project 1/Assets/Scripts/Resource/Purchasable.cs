using UnityEngine;

[System.Serializable]
public class Purchasable : MonoBehaviour
{
    public Resource resource;
    public int cost;

    public bool IsAffordable() {
        if (resource.Owned >= cost) {
            return true;
        }
        return false;
    }
}


