using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;
using QuizzMaker.BLL;
using QuizzMaker.BO;

namespace QuizzMaker
{
    /// <summary>
    /// Logique d'interaction pour PageQuestions.xaml
    /// </summary>

    public partial class PageQuestions : Page
    {
        private QuizzMakerManager instance = QuizzMakerManager.GetInstance;
        private List<Question> questions = new List<Question>();
        private int idQuestionEnCours = 0;

        private string sTextQuestion = string.Empty;
        Brush colorTxtQuestion;
        FontStyle fontTxtQuestion;


        public PageQuestions()
        {
            InitializeComponent();
            Load();
            
            
            RefreshAll();

        }

        private void Load()
        {
            sTextQuestion = txtQuestion.Text;
            colorTxtQuestion = txtQuestion.Foreground;
            fontTxtQuestion = txtQuestion.FontStyle;
            
        }
        private void InitQuestion()
        {
            txtQuestion.Text = sTextQuestion.Trim();
            txtQuestion.FontStyle = fontTxtQuestion;
            txtQuestion.Foreground = colorTxtQuestion;

            btnDelete.IsEnabled = false;
            idQuestionEnCours = 0;
            txtNbPoint.Text = string.Empty;
            txtTemps.Text = string.Empty;
            chkChoixReponse.IsChecked = false;

        }


        private void NewQuestion_Click(object sender, RoutedEventArgs e)
        {
            InitQuestion();
        }
        private void RefreshAll()
        {
            if (instance.QuestionnaireEnCours())
            {
                questions = instance.GetQuestions();
            }
            lstQuestions.ItemsSource = questions;
            lstQuestions.Items.Refresh();
            CollectionView view = (CollectionView)CollectionViewSource.GetDefaultView(lstQuestions.ItemsSource);
            view.SortDescriptions.Add(new SortDescription("NumQuestion", ListSortDirection.Ascending));

            InitQuestion();
        }

        private void SaveQuestion_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                instance.SaveQuestion(idQuestionEnCours, txtQuestion.Text, (bool)chkChoixReponse.IsChecked, int.Parse(txtNbPoint.Text), int.Parse(txtTemps.Text));
                RefreshAll();
                InitQuestion();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Une erreur s'est produite :\n" + ex.Message, "Erreur", MessageBoxButton.OK, MessageBoxImage.Error);
            }
        }



        private void DeleteQuestion_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                if (idQuestionEnCours != 0)
                {
                    instance.DeleteQuestion(idQuestionEnCours);
                    RefreshAll();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Une erreur s'est produite :\n" + ex.Message, "Erreur", MessageBoxButton.OK, MessageBoxImage.Error);
            }
            
        }

        private void TxtQuestion_GotFocus(object sender, RoutedEventArgs e)
        {
            if (txtQuestion.Text.Trim() == sTextQuestion.Trim())
            {
                txtQuestion.Text = string.Empty;
                txtQuestion.FontStyle = FontStyles.Normal;
                txtQuestion.Foreground = Brushes.Black;
            }
        }
        private void TxtQuestion_LostFocus(object sender, RoutedEventArgs e)
        {
            if (txtQuestion.Text.Trim() == sTextQuestion.Trim() || txtQuestion.Text.Trim() == string.Empty)
                InitQuestion();
        }

        private void LstQuestions_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if (lstQuestions.SelectedItem != null)
            {
                Question question = (lstQuestions.SelectedItem as Question);
                idQuestionEnCours = question.QuestionId;
                btnDelete.IsEnabled = true;
                txtQuestion.Text = question.LibelleQuestion.Trim();
                chkChoixReponse.IsChecked = question.ChoixReponse;
                txtTemps.Text = question.Temps.ToString();
                txtNbPoint.Text = question.Point.ToString();

                txtQuestion.FontStyle = FontStyles.Normal;
                txtQuestion.Foreground = Brushes.Black;
            }

        }

        private void BtnUpQuestion_Click(object sender, RoutedEventArgs e)
        {

            try
            {
                var curItem = ((ListBoxItem)lstQuestions.ContainerFromElement((Button)sender)).Content;
                instance.MoveOrderQuestion(((Question)curItem).QuestionId, -1);
                RefreshAll();
                
            }
            catch (Exception ex)
            {
                MessageBox.Show("Une erreur s'est produite :\n" + ex.Message, "Erreur", MessageBoxButton.OK, MessageBoxImage.Error);
            }
        }

        private void BtnDownQuestion_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                var curItem = ((ListBoxItem)lstQuestions.ContainerFromElement((Button)sender)).Content;
                instance.MoveOrderQuestion(((Question)curItem).QuestionId, 1);
                RefreshAll();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Une erreur s'est produite :\n" + ex.Message, "Erreur", MessageBoxButton.OK, MessageBoxImage.Error);
            }

        }

       

        private void TxtNbPoint_PreviewTextInput(object sender, TextCompositionEventArgs e)
        {
            Regex regex = new Regex("[^0-9]+");
            e.Handled = regex.IsMatch(e.Text);
        }

        private void TxtTemps_PreviewTextInput(object sender, TextCompositionEventArgs e)
        {
            Regex regex = new Regex("[^0-9]+");
            e.Handled = regex.IsMatch(e.Text);
        }

    }
}
