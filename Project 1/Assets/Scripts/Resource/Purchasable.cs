[System.Serializable]
public class Purchasable 
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


