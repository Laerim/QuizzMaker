#pragma checksum "..\..\..\Windows\LoadQuizz.xaml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "D522ADA7942A3748E1E6F237020BE3A02D0F5762"
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
    /// LoadQuizz
    /// </summary>
    public partial class LoadQuizz : System.Windows.Window, System.Windows.Markup.IComponentConnector {
        
        
        #line 57 "..\..\..\Windows\LoadQuizz.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox txtSearchName;
        
        #line default
        #line hidden
        
        
        #line 59 "..\..\..\Windows\LoadQuizz.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.DatePicker dpJeu;
        
        #line default
        #line hidden
        
        
        #line 64 "..\..\..\Windows\LoadQuizz.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.DataGrid dgQuestionnaires;
        
        #line default
        #line hidden
        
        
        #line 80 "..\..\..\Windows\LoadQuizz.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button btnNew;
        
        #line default
        #line hidden
        
        
        #line 81 "..\..\..\Windows\LoadQuizz.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button btnStart;
        
        #line default
        #line hidden
        
        
        #line 82 "..\..\..\Windows\LoadQuizz.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button btnUpdate;
        
        #line default
        #line hidden
        
        
        #line 83 "..\..\..\Windows\LoadQuizz.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button btnDelete;
        
        #line default
        #line hidden
        
        
        #line 84 "..\..\..\Windows\LoadQuizz.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button btnLeave;
        
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
            System.Uri resourceLocater = new System.Uri("/QuizzMaker;component/windows/loadquizz.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\Windows\LoadQuizz.xaml"
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
            this.txtSearchName = ((System.Windows.Controls.TextBox)(target));
            
            #line 57 "..\..\..\Windows\LoadQuizz.xaml"
            this.txtSearchName.TextChanged += new System.Windows.Controls.TextChangedEventHandler(this.TxtSearchName_TextChanged);
            
            #line default
            #line hidden
            return;
            case 2:
            this.dpJeu = ((System.Windows.Controls.DatePicker)(target));
            
            #line 59 "..\..\..\Windows\LoadQuizz.xaml"
            this.dpJeu.SelectedDateChanged += new System.EventHandler<System.Windows.Controls.SelectionChangedEventArgs>(this.DpJeu_SelectedDateChanged);
            
            #line default
            #line hidden
            return;
            case 3:
            this.dgQuestionnaires = ((System.Windows.Controls.DataGrid)(target));
            
            #line 63 "..\..\..\Windows\LoadQuizz.xaml"
            this.dgQuestionnaires.SelectedCellsChanged += new System.Windows.Controls.SelectedCellsChangedEventHandler(this.DgQuestionnaires_SelectedCellsChanged);
            
            #line default
            #line hidden
            return;
            case 4:
            this.btnNew = ((System.Windows.Controls.Button)(target));
            
            #line 80 "..\..\..\Windows\LoadQuizz.xaml"
            this.btnNew.Click += new System.Windows.RoutedEventHandler(this.New_Click);
            
            #line default
            #line hidden
            return;
            case 5:
            this.btnStart = ((System.Windows.Controls.Button)(target));
            
            #line 81 "..\..\..\Windows\LoadQuizz.xaml"
            this.btnStart.Click += new System.Windows.RoutedEventHandler(this.Start_Click);
            
            #line default
            #line hidden
            return;
            case 6:
            this.btnUpdate = ((System.Windows.Controls.Button)(target));
            
            #line 82 "..\..\..\Windows\LoadQuizz.xaml"
            this.btnUpdate.Click += new System.Windows.RoutedEventHandler(this.Update_Click);
            
            #line default
            #line hidden
            return;
            case 7:
            this.btnDelete = ((System.Windows.Controls.Button)(target));
            
            #line 83 "..\..\..\Windows\LoadQuizz.xaml"
            this.btnDelete.Click += new System.Windows.RoutedEventHandler(this.Delete_Click);
            
            #line default
            #line hidden
            return;
            case 8:
            this.btnLeave = ((System.Windows.Controls.Button)(target));
            
            #line 84 "..\..\..\Windows\LoadQuizz.xaml"
            this.btnLeave.Click += new System.Windows.RoutedEventHandler(this.Leave_Click);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}

