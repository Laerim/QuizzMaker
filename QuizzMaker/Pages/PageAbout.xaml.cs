using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using QuizzMaker.BLL;
using QuizzMaker.BO;

namespace QuizzMaker
{
    /// <summary>
    /// Logique d'interaction pour PageAbout.xaml
    /// </summary>
    public partial class PageAbout : Page
    {
        private QuizzMakerManager instance = QuizzMakerManager.GetInstance;
        public NewQuizz myOwner { get; set; }
        private string sTextDescription = string.Empty;
        Brush colorTxtDescription;
        FontStyle fontTxtDescription;

        private string sTextNom = string.Empty;
        Brush colorTxtNom;
        FontStyle fontTxtNom;

        public PageAbout()
        {
            InitializeComponent();
            Load();
        }

     
        private void Load()
        {
            
            colorTxtDescription = txtDescription.Foreground;
            fontTxtDescription = txtDescription.FontStyle;
            sTextDescription = txtDescription.Text.Trim();

            colorTxtNom = txtNom.Foreground;
            fontTxtNom = txtNom.FontStyle;
            sTextNom = txtNom.Text.Trim();
            try
            {
                if (instance.QuestionnaireEnCours())
                {
                    (string sNom, string sDescription, DateTime dtJeu, bool bAleatoire) = instance.GetInfoQuestionnaire();
                    txtNom.Focus();
                    txtNom.Text = sNom.Trim();
                    if (txtNom.Text.Trim() == string.Empty || txtNom.Text.Trim() == sTextNom.Trim())
                    {
                        txtNom.FontStyle = fontTxtNom;
                        txtNom.Foreground = colorTxtNom;
                        txtNom.Text = sTextNom.Trim();
                    }
                    
                    txtDescription.Focus();
                    txtDescription.Text = sDescription.Trim();
                    if (txtDescription.Text.Trim() == string.Empty || txtDescription.Text.Trim() == sTextDescription.Trim())
                    {
                        txtDescription.FontStyle = fontTxtDescription;
                        txtDescription.Foreground = colorTxtDescription;
                        txtDescription.Text = sTextDescription.Trim();
                    }
                    else
                    {
                        txtDescription.FontStyle = FontStyles.Normal;
                        txtDescription.Foreground = Brushes.Black;
                    }

                    dpJourJeu.Focus();
                    if (dtJeu != DateTime.MinValue)
                        dpJourJeu.SelectedDate = dtJeu;
                    else
                        dpJourJeu.SelectedDate = null;
                    
                    chkRandom.IsChecked = bAleatoire;
                    txtNom.Focus();
                    
                }
              //  else
                  //  (NewQuizz)Owner.
                //((NewQuizz)System.Windows.Application.Current.MainWindow).ActiveQuestionnaire();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Une erreur est survenue :\n" + ex.Message, "Erreur", MessageBoxButton.OK, MessageBoxImage.Error);
            }
        }
       
        

        public void SaveQuestionnaire_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                string sDescription = string.Empty;
                if (txtDescription.Text.Trim() != sTextDescription.Trim())
                    sDescription = txtDescription.Text.Trim();
                DateTime dtJeu = DateTime.MinValue;
                if (dpJourJeu.SelectedDate != null)
                    dtJeu = (DateTime)dpJourJeu.SelectedDate;
                instance.SaveQuestionnaire(txtNom.Text.Trim(), sDescription, dtJeu, (bool)chkRandom.IsChecked);
                myOwner.ActiveQuestionnaire();

            }
            catch (Exception ex)
            {
                MessageBox.Show("Une erreur s'est produite :\n" + ex.Message, "Erreur", MessageBoxButton.OK, MessageBoxImage.Error);
            }
        }
       

        private void TxtDescription_GotFocus(object sender, RoutedEventArgs e)
        {
    

            if (txtDescription.Text.Trim() == sTextDescription.Trim())
            {
                txtDescription.Text = string.Empty;
                txtDescription.FontStyle = FontStyles.Normal;
                txtDescription.Foreground = Brushes.Black;
            }

        }

        private void TxtDescription_LostFocus(object sender, RoutedEventArgs e)
        {
            if (txtDescription.Text.Trim() == string.Empty || txtDescription.Text.Trim() == sTextDescription.Trim())
            {
                txtDescription.FontStyle = fontTxtDescription;
                txtDescription.Foreground = colorTxtDescription;
                txtDescription.Text = sTextDescription.Trim();
            }
        }

        private void TxtNom_GotFocus(object sender, RoutedEventArgs e)
        {
            if (txtNom.Text.Trim() == sTextNom.Trim())
            {
                txtNom.Text = string.Empty;
                txtNom.FontStyle = FontStyles.Normal;
                txtNom.Foreground = Brushes.Black;
            }
        }

        private void TxtNom_LostFocus(object sender, RoutedEventArgs e)
        {
            if (txtNom.Text.Trim() == string.Empty || txtNom.Text.Trim() == sTextNom.Trim())
            {
                txtNom.FontStyle = fontTxtNom;
                txtNom.Foreground = colorTxtNom;
                txtNom.Text = sTextNom.Trim();
            }
        }
       

    }
}
