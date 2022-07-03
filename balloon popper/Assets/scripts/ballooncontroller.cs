using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ballooncontroller : MonoBehaviour
{
    //how many clicks to pop
    public int clicksToPop = 5;
    
    void OnMouseDown ()
    {
        clicksToPop --;

        transform.localScale += new Vector3(0.2f,0.2f,0.2f);

        if(clicksToPop == 0)
        {
            Destroy(gameObject);
        }
    }
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
