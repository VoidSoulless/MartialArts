using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Kinect = Windows.Kinect;

public class SaveTest : MonoBehaviour
{   

    public SaveObject so;
    //private float timeDel=0f;
    private void Update()
    {
        
    
         if(Input.GetKeyDown(KeyCode.Space))
         {
            SaveManager.Save(so);
            
            if (SaveObject.timeDel != 0f && Time.time >= SaveObject.timeDel + 0.9f)
            {
                SaveManager.Save(so);
            }
        }

      

        if (Input.GetKeyDown(KeyCode.Return))
         {
          so = SaveManager.Load();
         }
    }
}
