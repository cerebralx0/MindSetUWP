﻿#pragma checksum "C:\Users\olire\Documents\GitHub\MindSetUWP\examples\TestApp\TestApp\Views\Start.xaml" "{406ea660-64cf-4c82-b6f0-42d48172a799}" "A2466EBCD0ACEEC8D511E3EE0742F843"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace TestApp.Views
{
    partial class Start : 
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
                    this.AreaChart = (global::WinRTXamlToolkit.Controls.DataVisualization.Charting.Chart)(target);
                }
                break;
            case 2:
                {
                    this.SignalQual = (global::WinRTXamlToolkit.Controls.Gauge)(target);
                }
                break;
            case 3:
                {
                    this.MeditGauge = (global::WinRTXamlToolkit.Controls.Gauge)(target);
                }
                break;
            case 4:
                {
                    this.AttenGauge = (global::WinRTXamlToolkit.Controls.Gauge)(target);
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

