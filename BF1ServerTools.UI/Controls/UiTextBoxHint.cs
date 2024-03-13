﻿namespace BF1ServerTools.UI.Controls;

public class UiTextBoxHint : TextBox
{
    /// <summary>
    /// 提示信息
    /// </summary>
    public string Hint
    {
        get { return (string)GetValue(HintProperty); }
        set { SetValue(HintProperty, value); }
    }
    public static readonly DependencyProperty HintProperty =
        DependencyProperty.Register("Hint", typeof(string), typeof(UiTextBoxHint), new PropertyMetadata("请输入文本"));
}
