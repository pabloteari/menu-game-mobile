using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Navigation : MonoBehaviour
{

   [SerializeField] GameObject [] panels;

   public void NavigationBarClick(GameObject activePanel)
   {
        foreach (var panel in panels)
        {
            panel.SetActive(false);
        }
        activePanel.SetActive(true);
   }    
   
}
