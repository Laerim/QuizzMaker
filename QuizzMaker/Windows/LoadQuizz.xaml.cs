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
using System.Windows.Shapes;
using System.Windows.Threading;
using QuizzMaker.BLL;
using QuizzMaker.BO;

namespace QuizzMaker
{
    /// <summary>
    /// Logique d'interaction pour LoaQuizz.xaml
    /// </summary>
    public partial class LoadQuizz : Window
    {
        QuizzMakerManager instance = QuizzMakerManager.GetInstance;
        private List<Questionnaire> questionnaires = new List<Questionnaire>();
        private int idQuestionnaire = 0;
        
        public LoadQuizz()
        {
            InitializeComponent();
            Load();
            
        }
        private void Load()
        {
            try
            {
                questionnaires = instance.GetQuestionnaires(txtSearchName.Text.Trim(), dpJeu.SelectedDate);
                dgQuestionnaires.ItemsSource = questionnaires;
                idQuestionnaire = 0;
                btnDelete.IsEnabled = false;
                btnStart.IsEnabled = false;
                btnUpdate.IsEnabled = false;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Une erreur est surevenue :\n" + ex.Message, "Erreur", MessageBoxButton.OK, MessageBoxImage.Error);
            }
        }

        private void New_Click(object sender, RoutedEventArgs e)
        {
            NewQuizz window = new NewQuizz();
            
            
            window.ShowDialog();
            Load();
            
        }

        private void Start_Click(object sender, RoutedEventArgs e)
        {

        }

        private void Update_Click(object sender, RoutedEventArgs e)
        {
            if (idQuestionnaire != 0)
            {
                instance.SetQuestionnaire(idQuestionnaire);
                NewQuizz window = new NewQuizz();
                window.ShowDialog();
            }
        }

        private void Delete_Click(object sender, RoutedEventArgs e)
        {
            if (idQuestionnaire != 0)
            {
                instance.DeleteQuestionnaire(idQuestionnaire);
                Load();
            }
        }

        private void Leave_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        private void TxtSearchName_TextChanged(object sender, TextChangedEventArgs e)
        {
            
            Load();
        }

        private void DpJeu_SelectedDateChanged(object sender, SelectionChangedEventArgs e)
        {
            Load();
        }

        private void DgQuestionnaires_SelectedCellsChanged(object sender, SelectedCellsChangedEventArgs e)
        {
            if (dgQuestionnaires.SelectedItem != null)
            {
                idQuestionnaire = ((Questionnaire)dgQuestionnaires.SelectedItem).QuestionnaireId;
                btnUpdate.IsEnabled = true;
                btnDelete.IsEnabled = true;
                btnStart.IsEnabled = true;
            }
            

        }
    }
}
