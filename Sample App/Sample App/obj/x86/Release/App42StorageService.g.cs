﻿

#pragma checksum "E:\Himanshu Test\Sample App\Sample App\App42StorageService.xaml" "{406ea660-64cf-4c82-b6f0-42d48172a799}" "5DBF222C4B6FC784A2E32A51E402655F"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Sample_App
{
    partial class App42StorageService : global::Windows.UI.Xaml.Controls.Page, global::Windows.UI.Xaml.Markup.IComponentConnector
    {
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Windows.UI.Xaml.Build.Tasks"," 4.0.0.0")]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
 
        public void Connect(int connectionId, object target)
        {
            switch(connectionId)
            {
            case 1:
                #line 43 "..\..\..\App42StorageService.xaml"
                ((global::Windows.UI.Xaml.Controls.Primitives.ButtonBase)(target)).Click += this.insert_document;
                 #line default
                 #line hidden
                break;
            case 2:
                #line 44 "..\..\..\App42StorageService.xaml"
                ((global::Windows.UI.Xaml.Controls.Primitives.ButtonBase)(target)).Click += this.find_all_document;
                 #line default
                 #line hidden
                break;
            case 3:
                #line 45 "..\..\..\App42StorageService.xaml"
                ((global::Windows.UI.Xaml.Controls.Primitives.ButtonBase)(target)).Click += this.delete_document_by_id;
                 #line default
                 #line hidden
                break;
            case 4:
                #line 46 "..\..\..\App42StorageService.xaml"
                ((global::Windows.UI.Xaml.Controls.Primitives.ButtonBase)(target)).Click += this.find_document_by_id;
                 #line default
                 #line hidden
                break;
            case 5:
                #line 47 "..\..\..\App42StorageService.xaml"
                ((global::Windows.UI.Xaml.Controls.Primitives.ButtonBase)(target)).Click += this.find_document_by_query;
                 #line default
                 #line hidden
                break;
            case 6:
                #line 48 "..\..\..\App42StorageService.xaml"
                ((global::Windows.UI.Xaml.Controls.Primitives.ButtonBase)(target)).Click += this.update_document_by_id;
                 #line default
                 #line hidden
                break;
            case 7:
                #line 49 "..\..\..\App42StorageService.xaml"
                ((global::Windows.UI.Xaml.Controls.Primitives.ButtonBase)(target)).Click += this.update_document_by_Key_value;
                 #line default
                 #line hidden
                break;
            case 8:
                #line 50 "..\..\..\App42StorageService.xaml"
                ((global::Windows.UI.Xaml.Controls.Primitives.ButtonBase)(target)).Click += this.find_document_by_Key_value;
                 #line default
                 #line hidden
                break;
            case 9:
                #line 51 "..\..\..\App42StorageService.xaml"
                ((global::Windows.UI.Xaml.Controls.Primitives.ButtonBase)(target)).Click += this.delete_document_by_Key_value;
                 #line default
                 #line hidden
                break;
            case 10:
                #line 52 "..\..\..\App42StorageService.xaml"
                ((global::Windows.UI.Xaml.Controls.Primitives.ButtonBase)(target)).Click += this.add_or_update_keys;
                 #line default
                 #line hidden
                break;
            case 11:
                #line 53 "..\..\..\App42StorageService.xaml"
                ((global::Windows.UI.Xaml.Controls.Primitives.ButtonBase)(target)).Click += this.find_all_document_paging;
                 #line default
                 #line hidden
                break;
            }
            this._contentLoaded = true;
        }
    }
}


