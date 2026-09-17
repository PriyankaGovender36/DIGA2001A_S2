using UnityEngine;
using UnityEngine.InputSystem;

public class DamageTester : MonoBehaviour
{
    public GameObject[] enemies;
    public int damageAmount = 10;
   public  void OnDamage(InputAction.CallbackContext context)
    {
        if (!context.performed) return;

        foreach (GameObject enemy in enemies)
        { 
            IDamageable TakeDamage = GetComponent<IDamageable>();
            if(damageables != null)
            {
                Damageables.TakeDamage;
            }

    
