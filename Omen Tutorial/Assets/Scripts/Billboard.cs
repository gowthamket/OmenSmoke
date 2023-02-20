using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Billboard : MonoBehaviour
{

    [SerializeField] private Var_Camera m_camera;
    private void Update()
    {
        if (m_camera.Value != null)
            transform.rotation = Quaternion.LookRotation(m_camera.Value.transform.forward);
    }

}
