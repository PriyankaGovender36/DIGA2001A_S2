using MyGame.Characters;
using UnityEngine;

public class Testing : MonoBehaviour
{
    public Hero myHero;
    public Enemy myEnemy;

    void Start()
    {
        myHero.PrintHealth();
        myEnemy.PrintDamage();
    }
    
}
