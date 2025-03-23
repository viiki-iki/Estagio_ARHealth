using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Placement2 : MonoBehaviour
{
    [SerializeField]
    private bool IsSelected;

    [SerializeField]
    private bool Co1, Co2, Co3, Co4, Co5;

    public bool Selected
    {
        get
        {
            return this.IsSelected;
        }
        set
        {
            IsSelected = value;
        }
    }

    public bool Col1
    {
        get
        {
            return this.Co1;
        }
        set
        {
            Co1 = value;
        }
    }
    public bool Col2
    {
        get
        {
            return this.Co2;
        }
        set
        {
            Co2 = value;
        }
    }
    public bool Col3
    {
        get
        {
            return this.Co3;
        }
        set
        {
            Co3 = value;
        }
    }
    public bool Col4
    {
        get
        {
            return this.Co4;
        }
        set
        {
            Co4 = value;
        }
    }
    public bool Col5
    {
        get
        {
            return this.Co5;
        }
        set
        {
            Co5 = value;
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("c1"))
        {
            Col1 = true;
        }
        if (other.CompareTag("c2"))
        {
            Col2 = true;
        }
        if (other.CompareTag("c3"))
        {
            Col3 = true;
        }
        if (other.CompareTag("c4"))
        {
            Col4 = true;
        }
        if (other.CompareTag("c5"))
        {
            Col5 = true;
        }
    }
    private void OnTriggerExit(Collider other)
    {
        if (other.CompareTag("c1"))
        {
            Col1 = false;
        }
        if (other.CompareTag("c2"))
        {
            Col2 = false;
        }
        if (other.CompareTag("c3"))
        {
            Col3 = false;
        }
        if (other.CompareTag("c4"))
        {
            Col4 = false;
        }
        if (other.CompareTag("c5"))
        {
            Col5 = false;
        }
    }
}
