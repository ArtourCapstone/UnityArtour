using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChangeUser : MonoBehaviour
{
    Animator anim;

    // Start is called before the first frame update
    void Start()
    {
        anim = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void ChangeUserClick()
    {
        anim.SetInteger("Clicked", 1);
    }

    public void Cancel()
    {
        anim.SetInteger("Clicked", 0);
    }
}
