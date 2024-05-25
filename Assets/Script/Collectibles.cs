using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Collectibles : MonoBehaviour
{
    public virtual void Collected()
    {
        var player = GetComponent<StarterAssets.FirstPersonController>();
        if (player != null)
        {
            player.MoveSpeed += 5;
            Debug.Log("speed increased");
        }
    }
}

public class JumpCollectibles : Collectibles
{
    public override void Collected()
    {
        var player = GetComponent<StarterAssets.FirstPersonController>();
        if (player != null)
        {
            player.JumpHeight += 2;
            Debug.Log("jump height increased");
        }
    }

}
