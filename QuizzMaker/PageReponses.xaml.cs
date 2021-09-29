using System;
using System.Collections.Generic;
using System.ComponentModel;
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
    /// Logique d'interaction pour PageReponses.xaml
    /// </summary>
    public partial class PageReponses : Page
    {
        private QuizzMakerManager instance = QuizzMakerManager.GetInstance;
        private List<Question> questions = new List<Question>();
        private List<Reponse> reponses = new List<Reponse>();
       
        private int idReponseEnCours = 0;

        private string sTextReponse = string.Empty;
        Brush colorTxtReponse;
        FontStyle fontTxtReponse;

        public int idQuestionEnCours{ get; set; }

        public PageReponses()
        {
            InitializeComponent();
            Load();
            if (idQuestionEnCours != 0)
                LoadReponses();
        }

        private void Load()
        {
            sTextReponse = txtReponse.Text;
            colorTxtReponse = txtReponse.Foreground;
            fontTxtReponse = txtReponse.FontStyle;

            if (instance.QuestionnaireEnCours())
            {
                questions = instance.GetQuestions();

            }
            lstQuestions.ItemsSource = questions;
            lstQuestions.Items.Refresh();

            CollectionView viewQuestion = (CollectionView)CollectionViewSource.GetDefaultView(lstQuestions.ItemsSource);
            viewQuestion.SortDescriptions.Add(new SortDescription("NumQuestion", ListSortDirection.Ascending));


            InitReponse();

        }
        private void InitReponse()
        {
            txtReponse.Text = sTextReponse.Trim();
            txtReponse.FontStyle = fontTxtReponse;
            txtReponse.Foreground = colorTxtReponse;

            btnDelete.IsEnabled = false;
            chkBonneReponse.IsChecked = false;
            idReponseEnCours = 0;

        }
     

        private void LoadReponses()
        {
            reponses = instance.GetReponses(idQuestionEnCours);
            GbxReponses.IsEnabled = true;

            lstReponse.ItemsSource = reponses;
            lstReponse.Items.Refresh();
            CollectionView viewReponse = (CollectionView)CollectionViewSource.GetDefaultView(lstReponse.ItemsSource);
            viewReponse.SortDescriptions.Add(new SortDescription("Ordre", ListSortDirection.Ascending));
            InitReponse();

        }

        private void TxtReponse_LostFocus(object sender, RoutedEventArgs e)
        {
            if (txtReponse.Text.Trim() == sTextReponse.Trim() || txtReponse.Text.Trim() == string.Empty)
                InitReponse();
        }

        private void TxtReponse_GotFocus(object sender, RoutedEventArgs e)
        {
            if (txtReponse.Text.Trim() == sTextReponse.Trim())
            {
                txtReponse.Text = string.Empty;
                txtReponse.FontStyle = FontStyles.Normal;
                txtReponse.Foreground = Brushes.Black;
            }
        }

        private void BtnUpReponse_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                var curItem = ((ListBoxItem)lstReponse.ContainerFromElement((Button)sender)).Content;
                instance.MoveOrderReponse(((Reponse)curItem).ReponseId, -1);
                LoadReponses();

            }
            catch (Exception ex)
            {
                MessageBox.Show("Une erreur s'est produite :\n" + ex.Message, "Erreur", MessageBoxButton.OK, MessageBoxImage.Error);
            }
        }

        private void BtnDownReponse_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                var curItem = ((ListBoxItem)lstReponse.ContainerFromElement((Button)sender)).Content;
                instance.MoveOrderReponse(((Reponse)curItem).ReponseId, 1);
                LoadReponses();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Une erreur s'est produite :\n" + ex.Message, "Erreur", MessageBoxButton.OK, MessageBoxImage.Error);
            }
        }

        private void NewReponse_Click(object sender, RoutedEventArgs e)
        {
            InitReponse();
        }

        private void SaveReponse_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                instance.SaveReponse(idReponseEnCours, txtReponse.Text, (bool)chkBonneReponse.IsChecked, idQuestionEnCours);
                LoadReponses();
                InitReponse();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Une erreur s'est produite :\n" + ex.Message, "Erreur", MessageBoxButton.OK, MessageBoxImage.Error);
            }
        }

        private void DeleteReponse_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                if (idReponseEnCours != 0)
                {
                    instance.DeleteReponse(idReponseEnCours);
                    LoadReponses();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Une erreur s'est produite :\n" + ex.Message, "Erreur", MessageBoxButton.OK, MessageBoxImage.Error);
            }
        }

        private void LstQuestions_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if (lstQuestions.SelectedItem != null)
            {
                Question question = (lstQuestions.SelectedItem as Question);
                idQuestionEnCours = question.QuestionId;
                
                LoadReponses();
            }
        }

        private void LstReponse_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if (lstReponse.SelectedItem != null)
            {
                Reponse reponse = (lstReponse.SelectedItem as Reponse);
                idReponseEnCours = reponse.ReponseId;

                txtReponse.FontStyle = FontStyles.Normal;
                txtReponse.Foreground = Brushes.Black;
                txtReponse.Text = reponse.LibelleReponse.Trim();
                chkBonneReponse.IsChecked = reponse.Correcte;
                btnDelete.IsEnabled = true;
            }
        }
    }
}
