using UnityEngine;

public static class Helpers
{
    #region Transform

    public static void SetPositionX(this Transform tr, float value)
    {
        var pos = tr.position;
        pos.x = value;
        tr.position = pos;
    }
    
    public static void SetPositionY(this Transform tr, float value)
    {
        var pos = tr.position;
        pos.y = value;
        tr.position = pos;
    }
    
    public static void SetPositionZ(this Transform tr, float value)
    {
        var pos = tr.localPosition;
        pos.z = value;
        tr.localPosition = pos;
    }
    
    public static void SetLocalPositionX(this Transform tr, float value)
    {
        var pos = tr.localPosition;
        pos.x = value;
        tr.localPosition = pos;
    }
    
    public static void SetLocalPositionY(this Transform tr, float value)
    {
        var pos = tr.localPosition;
        pos.y = value;
        tr.localPosition = pos;
    }
    
    public static void SetLocalPositionZ(this Transform tr, float value)
    {
        var pos = tr.localPosition;
        pos.z = value;
        tr.localPosition = pos;
    }

    public static void SetLocalScale(this Transform tr, float value)
    {
        tr.localScale = Vector3.one * value;
    }
    
    #endregion
}
