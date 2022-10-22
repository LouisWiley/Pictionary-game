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
        
       if (Input.GetMouseButtonDown(0))
        {
            Collider2D target = Physics2D.OverlapPoint(mousePosition);

            if (target)
            {
                GameObject newLine = Instantiate(linePrefab);
                activeLine = newLine.GetComponent<Line>();

            }
           
        }
        if (Input.GetMouseButtonUp(0) && canvas)
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

