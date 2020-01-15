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
    //Para barrar completa
    //    public float maxLife = 50;
    public float maxLife = 10;
    public float _currentLife;
    //=============================================================
    //Para barrar como megaman
    public RectTransform backBar;
    public RectTransform bar;
    private float width;


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
        //Para barrar completa
        //_currentLife = maxLife;


        _currentLife = 0;
        width = bar.sizeDelta.x;
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.K)) {
            //RemoveLife();
            ClearLife();
        }

    }
    //Para barrar completa
    /*
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

    }*/
    //=============================== Para barras de a uno como megaman

    void UpdateBar()
    {
        ClearLife();


            AddFile();
        

    }

    void ClearLife() {
        for(int i=0; i < backBar.childCount; i++) {
            Destroy(backBar.GetChild(i).gameObject);
        }
    }

    void AddFile() {

        for(int i = 0; i < currentLife; i++)
        {
            RectTransform point = Instantiate<RectTransform>(bar);
            point.parent = backBar;
            point.localScale = Vector3.one;
            point.localPosition = new Vector3(width * i,0,0);
        }
    }

    void RemoveLife() {
        //Debug.Log(backBar.childCount);
        Destroy(backBar.GetChild(backBar.childCount - 1).gameObject);
    }


    }
