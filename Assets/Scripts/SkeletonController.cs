using UnityEngine;

public class SkeletonController : Health
{
    [SerializeField] SphereCollider headHitBox;
    [SerializeField] CapsuleCollider bodyHitBox;  

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
       Debug.Log(getHP());
    }
}
