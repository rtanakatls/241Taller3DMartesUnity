using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MinimapController : MonoBehaviour
{
    [SerializeField] private List<IconLink> iconLinks;

    private void Update()
    {
        foreach (IconLink iconLink in iconLinks)
        {
            iconLink.Icon.localPosition= new Vector3(iconLink.OriginalObject.position.x, iconLink.OriginalObject.position.z)*2;
        }
    }

}
