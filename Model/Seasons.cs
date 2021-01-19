using System;

namespace OrderLibrary.Model
{
    [Flags]
    public enum Seasons
    {
        Winter = 1<<0,
        Spring = 1<<1,
        Summer = 1<<2,
        Fall = 1<<3
    }
}