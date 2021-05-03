using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Unity;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.Rendering;
namespace ClassLibrary3
{
    [KSPAddon]
    public class Class1 : MonoBehaviour
    {
        private static ClassLibrary3.Class1 Instance;
        public void Awake()
        {
             ClassLibrary3.Class1.Instance = this;
            DontDestroyOnLoad(this);
    }
        public void Start() 
        {
            
            Debug.Log("trying to set frameratess");
            Application.targetFrameRate = 60;
            Debug.Log("FPS SET TO 60");
            
            ScreenMessages.PostScreenMessage("trying to set frameratess", 10f);
        }
    }
}
