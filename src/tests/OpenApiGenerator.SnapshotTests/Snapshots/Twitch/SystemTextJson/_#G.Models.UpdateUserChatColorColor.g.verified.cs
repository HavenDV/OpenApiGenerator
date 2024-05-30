﻿//HintName: G.Models.UpdateUserChatColorColor.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public enum UpdateUserChatColorColor
    {
        /// <summary>
        /// 
        /// </summary>
        Blue,
        /// <summary>
        /// 
        /// </summary>
        BlueViolet,
        /// <summary>
        /// 
        /// </summary>
        CadetBlue,
        /// <summary>
        /// 
        /// </summary>
        Chocolate,
        /// <summary>
        /// 
        /// </summary>
        Coral,
        /// <summary>
        /// 
        /// </summary>
        DodgerBlue,
        /// <summary>
        /// 
        /// </summary>
        Firebrick,
        /// <summary>
        /// 
        /// </summary>
        GoldenRod,
        /// <summary>
        /// 
        /// </summary>
        Green,
        /// <summary>
        /// 
        /// </summary>
        HotPink,
        /// <summary>
        /// 
        /// </summary>
        OrangeRed,
        /// <summary>
        /// 
        /// </summary>
        Red,
        /// <summary>
        /// 
        /// </summary>
        SeaGreen,
        /// <summary>
        /// 
        /// </summary>
        SpringGreen,
        /// <summary>
        /// 
        /// </summary>
        YellowGreen,
    }

    public static class UpdateUserChatColorColorExtensions
    {
        public static string ToValueString(this UpdateUserChatColorColor value)
        {
            return value switch
            {
                UpdateUserChatColorColor.Blue => "blue",
                UpdateUserChatColorColor.BlueViolet => "blue_violet",
                UpdateUserChatColorColor.CadetBlue => "cadet_blue",
                UpdateUserChatColorColor.Chocolate => "chocolate",
                UpdateUserChatColorColor.Coral => "coral",
                UpdateUserChatColorColor.DodgerBlue => "dodger_blue",
                UpdateUserChatColorColor.Firebrick => "firebrick",
                UpdateUserChatColorColor.GoldenRod => "golden_rod",
                UpdateUserChatColorColor.Green => "green",
                UpdateUserChatColorColor.HotPink => "hot_pink",
                UpdateUserChatColorColor.OrangeRed => "orange_red",
                UpdateUserChatColorColor.Red => "red",
                UpdateUserChatColorColor.SeaGreen => "sea_green",
                UpdateUserChatColorColor.SpringGreen => "spring_green",
                UpdateUserChatColorColor.YellowGreen => "yellow_green",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        public static UpdateUserChatColorColor ToEnum(string value)
        {
            return value switch
            {
                "blue" => UpdateUserChatColorColor.Blue,
                "blue_violet" => UpdateUserChatColorColor.BlueViolet,
                "cadet_blue" => UpdateUserChatColorColor.CadetBlue,
                "chocolate" => UpdateUserChatColorColor.Chocolate,
                "coral" => UpdateUserChatColorColor.Coral,
                "dodger_blue" => UpdateUserChatColorColor.DodgerBlue,
                "firebrick" => UpdateUserChatColorColor.Firebrick,
                "golden_rod" => UpdateUserChatColorColor.GoldenRod,
                "green" => UpdateUserChatColorColor.Green,
                "hot_pink" => UpdateUserChatColorColor.HotPink,
                "orange_red" => UpdateUserChatColorColor.OrangeRed,
                "red" => UpdateUserChatColorColor.Red,
                "sea_green" => UpdateUserChatColorColor.SeaGreen,
                "spring_green" => UpdateUserChatColorColor.SpringGreen,
                "yellow_green" => UpdateUserChatColorColor.YellowGreen,
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        public static UpdateUserChatColorColor ToEnum(int value)
        {
            return value switch
            {
                0 => UpdateUserChatColorColor.Blue,
                1 => UpdateUserChatColorColor.BlueViolet,
                2 => UpdateUserChatColorColor.CadetBlue,
                3 => UpdateUserChatColorColor.Chocolate,
                4 => UpdateUserChatColorColor.Coral,
                5 => UpdateUserChatColorColor.DodgerBlue,
                6 => UpdateUserChatColorColor.Firebrick,
                7 => UpdateUserChatColorColor.GoldenRod,
                8 => UpdateUserChatColorColor.Green,
                9 => UpdateUserChatColorColor.HotPink,
                10 => UpdateUserChatColorColor.OrangeRed,
                11 => UpdateUserChatColorColor.Red,
                12 => UpdateUserChatColorColor.SeaGreen,
                13 => UpdateUserChatColorColor.SpringGreen,
                14 => UpdateUserChatColorColor.YellowGreen,
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
    }
}