﻿#pragma checksum "C:\Users\zerin\Desktop\Grupa9-DiabetesTracker\Projekat\DiabetesTracker\View\Registracija1.xaml" "{406ea660-64cf-4c82-b6f0-42d48172a799}" "97CF8745C88A56E64E28730EF1374AEF"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace DiabetesTracker
{
    partial class BlankPage1 : 
        global::Windows.UI.Xaml.Controls.Page, 
        global::Windows.UI.Xaml.Markup.IComponentConnector,
        global::Windows.UI.Xaml.Markup.IComponentConnector2
    {
        /// <summary>
        /// Connect()
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Windows.UI.Xaml.Build.Tasks"," 14.0.0.0")]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        public void Connect(int connectionId, object target)
        {
            switch(connectionId)
            {
            case 1:
                {
                    this.VisualStateGroup = (global::Windows.UI.Xaml.VisualStateGroup)(target);
                }
                break;
            case 2:
                {
                    this.Wide = (global::Windows.UI.Xaml.VisualState)(target);
                }
                break;
            case 3:
                {
                    this.Narrow = (global::Windows.UI.Xaml.VisualState)(target);
                }
                break;
            case 4:
                {
                    this.panel = (global::Windows.UI.Xaml.Controls.StackPanel)(target);
                }
                break;
            case 5:
                {
                    this.ImeTextBox = (global::Windows.UI.Xaml.Controls.TextBox)(target);
                }
                break;
            case 6:
                {
                    this.PrezimeTextBox = (global::Windows.UI.Xaml.Controls.TextBox)(target);
                }
                break;
            case 7:
                {
                    this.UserNameIPasswordTextBox = (global::DiabetesTracker.UsernameIPasswordUserControl)(target);
                }
                break;
            case 8:
                {
                    this.PotvrdaPasswordaTextBox = (global::Windows.UI.Xaml.Controls.PasswordBox)(target);
                }
                break;
            case 9:
                {
                    this.EmailTextBox = (global::Windows.UI.Xaml.Controls.TextBox)(target);
                }
                break;
            case 10:
                {
                    this.JMBGTextBox = (global::Windows.UI.Xaml.Controls.TextBox)(target);
                }
                break;
            case 11:
                {
                    this.panelDugmadi = (global::Windows.UI.Xaml.Controls.StackPanel)(target);
                }
                break;
            case 12:
                {
                    this.DatumRodjenja = (global::Windows.UI.Xaml.Controls.CalendarDatePicker)(target);
                }
                break;
            case 13:
                {
                    this.dalje = (global::Windows.UI.Xaml.Controls.Button)(target);
                    #line 87 "..\..\..\View\Registracija1.xaml"
                    ((global::Windows.UI.Xaml.Controls.Button)this.dalje).Click += this.dalje_Click;
                    #line default
                }
                break;
            case 14:
                {
                    this.muskiButton = (global::Windows.UI.Xaml.Controls.RadioButton)(target);
                }
                break;
            case 15:
                {
                    this.zenskiButton = (global::Windows.UI.Xaml.Controls.RadioButton)(target);
                }
                break;
            default:
                break;
            }
            this._contentLoaded = true;
        }

        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Windows.UI.Xaml.Build.Tasks"," 14.0.0.0")]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        public global::Windows.UI.Xaml.Markup.IComponentConnector GetBindingConnector(int connectionId, object target)
        {
            global::Windows.UI.Xaml.Markup.IComponentConnector returnValue = null;
            return returnValue;
        }
    }
}

