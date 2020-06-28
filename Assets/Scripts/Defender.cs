using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Defender : MonoBehaviour
{
    [SerializeField] int starCost = 100;
    [SerializeField] GameObject starVFX;


    public void AddStars(int amount)
    {
        FindObjectOfType<StarDisplay>().AddStars(amount);
        GameObject starVFXObject = Instantiate(starVFX, transform.position + (transform.right * 0.0f) + (transform.up * .1f), transform.rotation);
    }

    public int GetStarCost()
    {
        return starCost;
    }
}
