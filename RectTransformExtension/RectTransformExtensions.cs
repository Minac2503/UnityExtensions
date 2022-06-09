using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace NS
{
    public static class RectTransformExtensions
    {
        public static RectTransform Left(this RectTransform rt, float x)
        {
            rt.offsetMin = new Vector2(x, rt.offsetMin.y);
            return rt;
        }

        public static RectTransform Right(this RectTransform rt, float x)
        {
            rt.offsetMax = new Vector2(-x, rt.offsetMax.y);
            return rt;
        }

        public static RectTransform Bottom(this RectTransform rt, float y)
        {
            rt.offsetMin = new Vector2(rt.offsetMin.x, y);
            return rt;
        }

        public static RectTransform Top(this RectTransform rt, float y)
        {
            rt.offsetMax = new Vector2(rt.offsetMax.x, -y);
            return rt;
        }

        public static void SetRect(RectTransform trs, float left, float top, float right, float bottom)
        {
            trs.offsetMin = new Vector2(left, bottom);
            trs.offsetMax = new Vector2(-right, -top);
        }

        public static void SetWidth(RectTransform rt, float width)
        {
            rt.sizeDelta = new Vector2(width, rt.sizeDelta.y);
        }

        public static void SetHeight(RectTransform rt, float height)
        {
            rt.sizeDelta = new Vector2(rt.sizeDelta.x, height);
        }

        public static void SetSize(RectTransform rt, float width, float height)
        {
            rt.sizeDelta = new Vector2(width, height);
        }

        public static void SetSize(RectTransform rt, Vector2 size)
        {
            rt.sizeDelta = size;
        }

        public static float GetWidth(RectTransform rt, float width)
        {
            return rt.sizeDelta.x;
        }

        public static float GetHeight(RectTransform rt, float height)
        {
            return rt.sizeDelta.x;
        }

        public static Vector2 GetSize(RectTransform rt)
        {
            return rt.sizeDelta;
        }
    }
}
