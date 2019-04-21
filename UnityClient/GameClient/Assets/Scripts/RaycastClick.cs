using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RaycastClick : MonoBehaviour
{

    public TestSocketIO socket;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetButtonDown("Fire1")){
            //Debug.Log("click");
            var ray = Camera.main.ScreenPointToRay(Input.mousePosition);

            RaycastHit hit = new RaycastHit();

            if(Physics.Raycast(ray,out hit)){
                //Debug.Log(hit.collider.gameObject.name);

                var clickMove = hit.collider.gameObject.GetComponent<ClickMove>();
                clickMove.OnClick(hit.point);

            }
        }
    }
}
