﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnityEngine;
using UnityEngine.UI;

namespace BeatSaberMarkupLanguage.Tags
{
    public class VerticalLayoutTag : BSMLTag
    {
        public override string[] Aliases => new[] { "vertical" };

        public override GameObject CreateObject(Transform parent)
        {
            GameObject gameObject = new GameObject();
            gameObject.name = "BSMLVerticalLayoutGroup";
            gameObject.transform.SetParent(parent, false);
            VerticalLayoutGroup layoutGroup = gameObject.AddComponent<VerticalLayoutGroup>();
            RectTransform rectTransform = gameObject.transform as RectTransform;
            rectTransform.sizeDelta = new Vector2(BSMLParser.SCREEN_WIDTH, BSMLParser.SCREEN_HEIGHT);
            return gameObject;
        }
    }
}