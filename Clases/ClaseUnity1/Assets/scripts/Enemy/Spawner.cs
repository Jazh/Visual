using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Platformer { 
public class Spawner : MonoBehaviour
{

        public Enemy enemy;
        static private Spawner instance;
        private Coroutine coroutine;
        
        static public void Spawn(float delay) {
                
 
                    instance.Create(delay);
                

            }
        // Start is called before the first frame update
        void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

        public void Awake() {
            instance = this;
        }

        public void Create(float delay) {

           coroutine = StartCoroutine(CreateEnemy(delay));
            //StopCoroutine(coroutine);
        }

        public IEnumerator CreateEnemy(float delay)
        {
            yield return new WaitForSecondsRealtime(delay);//reloj de procesador
            Instantiate<Enemy>(enemy);
        }

    }
}