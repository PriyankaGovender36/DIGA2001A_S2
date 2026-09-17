using UnityEngine;

public class Orc : MonoBehaviour, IDamageable
{
    public int health = 80;
    public void TakeDamage(int amount)
    {
        health -= amount;
        Debug.Log("damage was taken");
    }
}
