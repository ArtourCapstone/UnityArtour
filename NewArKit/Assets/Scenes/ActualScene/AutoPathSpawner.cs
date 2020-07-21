using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AutoPathSpawner : MonoBehaviour
{
    public GameObject breadcrumb;

    public Transform target,target2,target3;

    // Start is called before the first frame update
    void Start()
    {
       // InvokeRepeating("CreateAutoPath", 1f, 3f);
       // InvokeRepeating("CreateAutoPath2", 1f, 3f);

    }

    // Update is called once per frame
    void Update()
    {
       /** if (Input.GetKeyDown(KeyCode.E))
        {
           
            CreateAutoPath();
        }**/
    }

    public void buttons1()
    {
        InvokeRepeating("CreateAutoPath", 1f, 3f);
        CancelInvoke("CreateAutoPath2");
        CancelInvoke("CreateAutoPath3");
        Debug.Log("pressed");
    }

    public void buttons2()
    {
        CancelInvoke("CreateAutoPath");
        CancelInvoke("CreateAutoPath3");
        InvokeRepeating("CreateAutoPath2", 1f, 3f);
    }

    public void buttons3()
    {
        CancelInvoke("CreateAutoPath");
        CancelInvoke("CreateAutoPath2");
        InvokeRepeating("CreateAutoPath3", 1f, 3f);
    }

    void CreateAutoPath()
    {
            if (target != null)
            {
                var newObj = Instantiate(breadcrumb, transform.position, transform.rotation);
                newObj.GetComponent<AutoPathing>().target = target;
            } 
    }

    void CreateAutoPath2()
    {
        if (target != null)
        {
            var newObj = Instantiate(breadcrumb, transform.position, transform.rotation);
            newObj.GetComponent<AutoPathing>().target = target2;
        }
    }

    void CreateAutoPath3()
    {
        if (target != null)
        {
            var newObj = Instantiate(breadcrumb, transform.position, transform.rotation);
            newObj.GetComponent<AutoPathing>().target = target3;
        }
    }
}
