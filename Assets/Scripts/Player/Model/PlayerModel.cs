using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerModel : MonoBehaviour
{
    public int MaxHealth { get; private set; }
    public int CurrentHealth { get; private set; }

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        CurrentHealth -= 1;
    }

    public void InitPlayer(int maxHealth)
    {
        MaxHealth = maxHealth;
        CurrentHealth = MaxHealth;
    }
}
