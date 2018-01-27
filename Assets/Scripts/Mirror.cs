﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Mirror : MonoBehaviour {

    public enum Color { White, Red, Green, Blue };
    public Color mColor = Color.White;

    const int NORTH = 0, WEST = 90, SOUTH = 180, EAST = 270; //Use with laser direction

    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }

    void OnTriggerEnter2D(Collider2D other)
    {
        
        if (other.gameObject.transform.rotation == Quaternion.Euler(0, 0, NORTH)) //if laser is travelling north
        {
            if (transform.rotation == Quaternion.Euler(0, 0, 0) || transform.rotation == Quaternion.Euler(0, 0, 360))
            {
                other.gameObject.transform.rotation = Quaternion.Euler(0, 0, EAST);
            }
            else if (transform.rotation == Quaternion.Euler(0, 0, 270))
            {
                other.gameObject.transform.rotation = Quaternion.Euler(0, 0, WEST);
            }
            else
            {
                Destroy(other.gameObject);
            }
        }
        else if (other.gameObject.transform.rotation == Quaternion.Euler(0, 0, WEST)) //if laser is travelling west
        {
            if (transform.rotation == Quaternion.Euler(0, 0, 90))
            {
                other.gameObject.transform.rotation = Quaternion.Euler(0, 0, NORTH);
            }
            else if (transform.rotation == Quaternion.Euler(0, 0, 0) || transform.rotation == Quaternion.Euler(0, 0, 360))
            {
                other.gameObject.transform.rotation = Quaternion.Euler(0, 0, SOUTH);
            }
            else
            {
                Destroy(other.gameObject);
            }
        }
        else if (other.gameObject.transform.rotation == Quaternion.Euler(0, 0, EAST)) //if laser is travelling east
        {
            if (transform.rotation == Quaternion.Euler(0, 0, 180))
            {
                other.gameObject.transform.rotation = Quaternion.Euler(0, 0, NORTH);
            }
            else if (transform.rotation == Quaternion.Euler(0, 0, 270))
            {
                other.gameObject.transform.rotation = Quaternion.Euler(0, 0, SOUTH);
            }
            else
            {
                Destroy(other.gameObject);
            }
        }
        else if (other.gameObject.transform.rotation == Quaternion.Euler(0, 0, WEST)) //if laser is travelling south
        {
            if (transform.rotation == Quaternion.Euler(0, 0, 90))
            {
                other.gameObject.transform.rotation = Quaternion.Euler(0, 0, EAST);
            }
            else if (transform.rotation == Quaternion.Euler(0, 0, 180))
            {
                other.gameObject.transform.rotation = Quaternion.Euler(0, 0, WEST);
            }
            else
            {
                Destroy(other.gameObject);
            }
        }



        /*
         
        if (other.gameObject.CompareTag("LaserWhite") ||
			other.gameObject.CompareTag("LaserRed") ||
			other.gameObject.CompareTag("LaserGreen") ||
			other.gameObject.CompareTag("LaserBlue"))
		{
			
            if (gameObject.transform.rotation == Quaternion.Euler(0, 0, 0))
			{
                other.gameObject.transform.rotation = Quaternion.Euler(0, 0, -90);
            }
            else if (gameObject.transform.rotation == Quaternion.Euler(0, 0, 270))
			{
                other.gameObject.transform.rotation = Quaternion.Euler(0, 0, 90);
            }
			else
			{
                Destroy(other.gameObject);
			}
			

		}

        */

    }

    private void OnMouseDown()
    {
        transform.Rotate(0, 0, 90);
    }
}
