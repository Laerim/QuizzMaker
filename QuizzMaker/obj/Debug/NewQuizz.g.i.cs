#pragma checksum "..\..\NewQuizz.xaml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "1FEC4DF2DAC912B17C6CB1443A3C442C4D049EE4"
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
    /// NewQuizz
    /// </summary>
    public partial class NewQuizz : System.Windows.Window, System.Windows.Markup.IComponentConnector, System.Windows.Markup.IStyleConnector {
        
        
        #line 36 "..\..\NewQuizz.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox txtQuestion;
        
        #line default
        #line hidden
        
        
        #line 39 "..\..\NewQuizz.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.CheckBox chkChoixReponse;
        
        #line default
        #line hidden
        
        
        #line 44 "..\..\NewQuizz.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox txtTemps;
        
        #line default
        #line hidden
        
        
        #line 48 "..\..\NewQuizz.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox txtNbPoint;
        
        #line default
        #line hidden
        
        
        #line 65 "..\..\NewQuizz.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button btnSave;
        
        #line default
        #line hidden
        
        
        #line 66 "..\..\NewQuizz.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button btnReponses;
        
        #line default
        #line hidden
        
        
        #line 67 "..\..\NewQuizz.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button btnDelete;
        
        #line default
        #line hidden
        
        
        #line 82 "..\..\NewQuizz.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ListBox lstQuestions;
        
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
            System.Uri resourceLocater = new System.Uri("/QuizzMaker;component/newquizz.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\NewQuizz.xaml"
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
            this.txtQuestion = ((System.Windows.Controls.TextBox)(target));
            
            #line 36 "..\..\NewQuizz.xaml"
            this.txtQuestion.LostFocus += new System.Windows.RoutedEventHandler(this.TxtQuestion_LostFocus);
            
            #line default
            #line hidden
            
            #line 36 "..\..\NewQuizz.xaml"
            this.txtQuestion.GotFocus += new System.Windows.RoutedEventHandler(this.TxtQuestion_GotFocus);
            
            #line default
            #line hidden
            return;
            case 2:
            this.chkChoixReponse = ((System.Windows.Controls.CheckBox)(target));
            return;
            case 3:
            this.txtTemps = ((System.Windows.Controls.TextBox)(target));
            return;
            case 4:
            this.txtNbPoint = ((System.Windows.Controls.TextBox)(target));
            return;
            case 5:
            
            #line 64 "..\..\NewQuizz.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.NewQuestion_Click);
            
            #line default
            #line hidden
            return;
            case 6:
            this.btnSave = ((System.Windows.Controls.Button)(target));
            
            #line 65 "..\..\NewQuizz.xaml"
            this.btnSave.Click += new System.Windows.RoutedEventHandler(this.SaveQuestion_Click);
            
            #line default
            #line hidden
            return;
            case 7:
            this.btnReponses = ((System.Windows.Controls.Button)(target));
            
            #line 66 "..\..\NewQuizz.xaml"
            this.btnReponses.Click += new System.Windows.RoutedEventHandler(this.ReponsesQuestion_Click);
            
            #line default
            #line hidden
            return;
            case 8:
            this.btnDelete = ((System.Windows.Controls.Button)(target));
            
            #line 67 "..\..\NewQuizz.xaml"
            this.btnDelete.Click += new System.Windows.RoutedEventHandler(this.DeleteQuestion_Click);
            
            #line default
            #line hidden
            return;
            case 9:
            this.lstQuestions = ((System.Windows.Controls.ListBox)(target));
            
            #line 82 "..\..\NewQuizz.xaml"
            this.lstQuestions.SelectionChanged += new System.Windows.Controls.SelectionChangedEventHandler(this.LstQuestions_SelectionChanged);
            
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
            case 10:
            
            #line 96 "..\..\NewQuizz.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.BtnUpQuestion_Click);
            
            #line default
            #line hidden
            break;
            case 11:
            
            #line 97 "..\..\NewQuizz.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.BtnDownQuestion_Click);
            
            #line default
            #line hidden
            break;
            }
        }
    }
}

