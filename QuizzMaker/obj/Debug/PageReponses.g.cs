#pragma checksum "..\..\PageReponses.xaml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "4883670E235A685DC898125A5239AFFAAD7BB3D8"
//------------------------------------------------------------------------------
// <auto-generated>
//     Ce code a été généré par un outil.
//     Version du runtime :4.0.30319.42000
//
//     Les modifications apportées à ce fichier peuvent provoquer un comportement incorrect et seront perdues si
//     le code est régénéré.
// </auto-generated>
//------------------------------------------------------------------------------

using QuizzMaker;
using System;
using System.Diagnostics;
using System.Windows;
using System.Windows.Automation;
using System.Windows.Controls;
using System.Windows.Controls.Primitives;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Ink;
using System.Windows.Input;
using System.Windows.Markup;
using System.Windows.Media;
using System.Windows.Media.Animation;
using System.Windows.Media.Effects;
using System.Windows.Media.Imaging;
using System.Windows.Media.Media3D;
using System.Windows.Media.TextFormatting;
using System.Windows.Navigation;
using System.Windows.Shapes;
using System.Windows.Shell;


namespace QuizzMaker {
    
    
    /// <summary>
    /// PageReponses
    /// </summary>
    public partial class PageReponses : System.Windows.Controls.Page, System.Windows.Markup.IComponentConnector, System.Windows.Markup.IStyleConnector {
        
        
        #line 23 "..\..\PageReponses.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ListBox lstQuestions;
        
        #line default
        #line hidden
        
        
        #line 41 "..\..\PageReponses.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.GroupBox GbxReponses;
        
        #line default
        #line hidden
        
        
        #line 44 "..\..\PageReponses.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox txtReponse;
        
        #line default
        #line hidden
        
        
        #line 48 "..\..\PageReponses.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.CheckBox chkBonneReponse;
        
        #line default
        #line hidden
        
        
        #line 53 "..\..\PageReponses.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button btnSave;
        
        #line default
        #line hidden
        
        
        #line 54 "..\..\PageReponses.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button btnDelete;
        
        #line default
        #line hidden
        
        
        #line 56 "..\..\PageReponses.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ListBox lstReponse;
        
        #line default
        #line hidden
        
        private bool _contentLoaded;
        
        /// <summary>
        /// InitializeComponent
        /// </summary>
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "4.0.0.0")]
        public void InitializeComponent() {
            if (_contentLoaded) {
                return;
            }
            _contentLoaded = true;
            System.Uri resourceLocater = new System.Uri("/QuizzMaker;component/pagereponses.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\PageReponses.xaml"
            System.Windows.Application.LoadComponent(this, resourceLocater);
            
            #line default
            #line hidden
        }
        
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "4.0.0.0")]
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Design", "CA1033:InterfaceMethodsShouldBeCallableByChildTypes")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Maintainability", "CA1502:AvoidExcessiveComplexity")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1800:DoNotCastUnnecessarily")]
        void System.Windows.Markup.IComponentConnector.Connect(int connectionId, object target) {
            switch (connectionId)
            {
            case 1:
            this.lstQuestions = ((System.Windows.Controls.ListBox)(target));
            
            #line 23 "..\..\PageReponses.xaml"
            this.lstQuestions.SelectionChanged += new System.Windows.Controls.SelectionChangedEventHandler(this.LstQuestions_SelectionChanged);
            
            #line default
            #line hidden
            return;
            case 2:
            this.GbxReponses = ((System.Windows.Controls.GroupBox)(target));
            return;
            case 3:
            this.txtReponse = ((System.Windows.Controls.TextBox)(target));
            
            #line 44 "..\..\PageReponses.xaml"
            this.txtReponse.LostFocus += new System.Windows.RoutedEventHandler(this.TxtReponse_LostFocus);
            
            #line default
            #line hidden
            
            #line 44 "..\..\PageReponses.xaml"
            this.txtReponse.GotFocus += new System.Windows.RoutedEventHandler(this.TxtReponse_GotFocus);
            
            #line default
            #line hidden
            return;
            case 4:
            this.chkBonneReponse = ((System.Windows.Controls.CheckBox)(target));
            return;
            case 5:
            
            #line 52 "..\..\PageReponses.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.NewReponse_Click);
            
            #line default
            #line hidden
            return;
            case 6:
            this.btnSave = ((System.Windows.Controls.Button)(target));
            
            #line 53 "..\..\PageReponses.xaml"
            this.btnSave.Click += new System.Windows.RoutedEventHandler(this.SaveReponse_Click);
            
            #line default
            #line hidden
            return;
            case 7:
            this.btnDelete = ((System.Windows.Controls.Button)(target));
            
            #line 54 "..\..\PageReponses.xaml"
            this.btnDelete.Click += new System.Windows.RoutedEventHandler(this.DeleteReponse_Click);
            
            #line default
            #line hidden
            return;
            case 8:
            this.lstReponse = ((System.Windows.Controls.ListBox)(target));
            
            #line 56 "..\..\PageReponses.xaml"
            this.lstReponse.SelectionChanged += new System.Windows.Controls.SelectionChangedEventHandler(this.LstReponse_SelectionChanged);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
        
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "4.0.0.0")]
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Design", "CA1033:InterfaceMethodsShouldBeCallableByChildTypes")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1800:DoNotCastUnnecessarily")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Maintainability", "CA1502:AvoidExcessiveComplexity")]
        void System.Windows.Markup.IStyleConnector.Connect(int connectionId, object target) {
            switch (connectionId)
            {
            case 9:
            
            #line 70 "..\..\PageReponses.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.BtnUpReponse_Click);
            
            #line default
            #line hidden
            break;
            case 10:
            
            #line 71 "..\..\PageReponses.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.BtnDownReponse_Click);
            
            #line default
            #line hidden
            break;
            }
        }
    }
}

