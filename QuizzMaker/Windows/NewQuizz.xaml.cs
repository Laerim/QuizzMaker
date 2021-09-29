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
using System.Windows.Shapes;
using QuizzMaker.BLL;
using QuizzMaker.BO;

namespace QuizzMaker
{
    /// <summary>
    /// Logique d'interaction pour NewQuizz.xaml
    /// </summary>
    public partial class NewQuizz : Window
    {
        private QuizzMakerManager instance = QuizzMakerManager.GetInstance;
        
        

        public NewQuizz()
        {
            InitializeComponent();
            Load();
            
        }

        private void Load()
        {
           
            if (instance.QuestionnaireEnCours())
                ActiveQuestionnaire();
            PageAbout page = new PageAbout();
            page.myOwner = this;
            Main.Content = page;
           
        }

        public void ActiveQuestionnaire()
        {
            try
            {
                btnQuestion.IsEnabled = true;
                btnReponses.IsEnabled = true;
               // MessageBox.Show("Vous pouvez désormais créer les questions de votre quizz", "Succès", MessageBoxButton.OK, MessageBoxImage.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Une erreur est survenue :\n" + ex.Message, "Erreur", MessageBoxButton.OK, MessageBoxImage.Error);
            }
        }
        
       


        private void BtnAbout_Click(object sender, RoutedEventArgs e)
        {
            Main.Content  = new PageAbout();
        }

        private void BtnQuestion_Click(object sender, RoutedEventArgs e)
        {
            Main.Content = new PageQuestions();
        }

        private void BtnReponses_Click(object sender, RoutedEventArgs e)
        {
            Main.Content = new PageReponses();
        }

 

        private void BtnClose_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }
    }
}
