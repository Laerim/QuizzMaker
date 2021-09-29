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

namespace QuizzMaker.Windows
{
    /// <summary>
    /// Logique d'interaction pour PlayGame.xaml
    /// </summary>
    public partial class PlayGame : Window
    {
        private QuizzMakerManager instance = QuizzMakerManager.GetInstance;
        public Question question;
        private List<Reponse> reponses;
        private DispatcherTimer timer = new DispatcherTimer();
        private int iTempsPasse = 0;
        public PlayGame()
        {
            InitializeComponent();
            Load();
        }
        private void Load()
        {
            reponses = instance.GetReponses(question.QuestionId);
            timer.Interval = TimeSpan.FromSeconds(1);
            timer.Tick += timer_Tick;
            //timer.Start();

            int nbColonne = 2;
            if (reponses.Count > 6)
                nbColonne = 3;
            if (reponses.Count > 21)
                nbColonne = 4;

            int indColonne = 0;
            for (int i = 0; i < reponses.Count; i++)
            {
                if(indColonne==0)
                {
                    StackPanel stackPanel = new StackPanel();
                }

            }
        }
        void timer_Tick(object sender, EventArgs e)
        {
            iTempsPasse++;
            lblChrono.Text = (question.Temps - iTempsPasse).ToString();
            if (iTempsPasse == question.Temps)
                StopQuestion();
        }

        private void StopQuestion()
        {
            timer.Stop();
        }
       

        /*Considérant que le StackPanel s'appelle sp
         * for(int i=0; i<5; i++)
{
    System.Windows.Controls.Button newBtn = new Button();

    newBtn.Content = i.ToString();
    newBtn.Name = "Button" + i.ToString();

    sp.Children.Add(newBtn);
}*/
    }
}
