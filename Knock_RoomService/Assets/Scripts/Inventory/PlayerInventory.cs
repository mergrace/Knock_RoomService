using UnityEngine;

public class PlayerInventory : MonoBehaviour
{
    public int rottenFood = 20;
    public int plates = 10;
    public int knives = 3;

    // Use item
    public void UseRottenFood()
    {
        if (rottenFood > 0)
        {
            rottenFood--;
            Debug.Log("Used Rotten Food. Left: " + rottenFood);
        }
    }

    public void UsePlate()
    {
        if (plates > 0)
        {
            plates--;
            Debug.Log("Used Plate. Left: " + plates);
        }
    }

    public void UseKnife()
    {
        if (knives > 0)
        {
            knives--;
            Debug.Log("Used Knife. Left: " + knives);
        }
    }
}
