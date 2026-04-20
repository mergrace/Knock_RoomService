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
            Debug.Log("Used up rotten food. left: " + rottenFood);
        }
    }

    public void UsePlates()
    {
        if (plates > 0)
        {
            plates--;
            Debug.Log("Used up plates. left: " + plates);
        }
    }

    public void UseKnives()
    {
        if (knives > 0)
        {
            knives--;
            Debug.Log("Used up knives. left: " + knives);
        }
    }
}
