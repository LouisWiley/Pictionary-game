using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class LineGenerator : MonoBehaviour
{

    public GameObject linePrefab;
    public GameObject canvas;
    Line activeLine;


   void Update()
    {
        Vector3 mousePosition = Camera.main.ScreenToWorldPoint(Input.mousePosition);
        Collider2D target = Physics2D.OverlapPoint(mousePosition);

        if (Input.GetMouseButtonDown(0))
        {
           

            if (target)
            {
                GameObject newLine = Instantiate(linePrefab);
                newLine.gameObject.tag = "Line";
                activeLine = newLine.GetComponent<Line>();

            }
           
        }
        if (Input.GetMouseButtonUp(0) || !target)
        {
            activeLine = null;
        }

        if (activeLine != null)
        {
            Vector2 mousPos = Camera.main.ScreenToWorldPoint(Input.mousePosition);
            activeLine.UpdateLine(mousPos);
        }

    }


}

