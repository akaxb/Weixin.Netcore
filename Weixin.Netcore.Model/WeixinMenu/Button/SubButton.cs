﻿using System.Collections.Generic;

namespace Weixin.Netcore.Model.WeixinMenu.Button
{
    /// <summary>
    /// 子菜单按钮
    /// </summary>
    public class SubButton : ButtonBase, IButton
    {
        public SubButton(string name) : base(name)
        {
            sub_button = new List<SingleButton>();
        }

        public List<SingleButton> sub_button { get; set; }
    }
}
