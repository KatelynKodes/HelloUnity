using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GoalHealthTextBehavior : MonoBehaviour
{
    [SerializeField]
    private Text _healthText;

    [SerializeField]
    private GoalBehavior _goal;

    private void Update()
    {
        float health = (_goal.Health);

        if (health < 0)
        {
            health = 0;
        }

        _healthText.text = "Health: " + health; 
    }
}
