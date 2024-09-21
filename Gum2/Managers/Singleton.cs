﻿namespace Gum2.Managers;

public class Singleton<T> where T : new()
{
    static T mSelf;

    public static T Self
    {
        get
        {
            if (mSelf == null)
            {
                mSelf = new T();
            }
            return mSelf;
        }
    }
}
