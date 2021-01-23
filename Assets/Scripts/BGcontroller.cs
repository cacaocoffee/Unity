using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BGcontroller : Singleton<BGcontroller>
{
    private MeshRenderer render;


    public float speed;
    private float offset;

    public int stop;
    
    

    // Start is called before the first frame update
    void Start()
    {
        stop = 1;
        render = GetComponent<MeshRenderer>();
    }

    // Update is called once per frame
    void Update()
    {
        if(render.material.mainTextureOffset.x < stop)
        {
            offset += Time.deltaTime * speed;
            render.material.mainTextureOffset = new Vector2(offset, 0);
        }
    }
    
    
}

