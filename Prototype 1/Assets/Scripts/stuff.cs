using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class stuff : MonoBehaviour
{
    public int m_bullets;
    public int m_grenades;
    public int m_rockets;
    public stuff(int bullets, int grenades, int rockets)
    {
        m_bullets = bullets;
        m_grenades = grenades;
        m_rockets = rockets;
    }
    public stuff(int bullets)
    {
        m_bullets=bullets;
    }
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
