using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HealthBarController : MonoBehaviour
{

    private float min = 0f;
    private float max = 30f;


    public RectTransform middleBar;
    public RectTransform endBar;
    public float maxLife = 50;
    public float _currentLife;

    public float currentLife
    {
        set {
            _currentLife = Mathf.Clamp(value,0,maxLife);
            UpdateBar();
        }

        get {
            return _currentLife;
        }
    }


    // Start is called before the first frame update
    void Start()
    {
        _currentLife = maxLife;
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.O))
        {
            currentLife--;
        }

        if(Input.GetKeyDown(KeyCode.P))
        {
            currentLife++;
        }
    }

    void UpdateBar() {
       
        float lifePercent = currentLife / maxLife;
        float scalePercent = max * lifePercent;

        //middleBar.localScale
        Vector3 scale = middleBar.localScale;
        scale.x = Mathf.Clamp(scalePercent,min,max);
        Vector3 pos = endBar.localPosition;
        pos.x = middleBar.localPosition.x + (middleBar.sizeDelta.x * scale.x);
        endBar.localPosition = pos;

        middleBar.localScale = scale;

    }
}
