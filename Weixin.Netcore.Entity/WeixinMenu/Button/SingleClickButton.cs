﻿namespace Weixin.Netcore.Entity.WeixinMenu.Button
{
    /// <summary>
    /// Click按钮
    /// </summary>
    public class SingleClickButton : SingleButton
    {
        public SingleClickButton(string name) : base(name)
        {
            type = "click";
        }

        public string key { get; set; }
    }
}
