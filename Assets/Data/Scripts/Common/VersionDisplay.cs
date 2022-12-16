using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class VersionDisplay : MonoBehaviour
{
   private void Awake()
   {
      if (TryGetComponent(out Text output))
         output.text = Application.version;
   }
}
