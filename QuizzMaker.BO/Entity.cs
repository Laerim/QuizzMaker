using System;
using System.Collections.Generic;

namespace QuizzMaker.BO
{
    #region ENTITES
    public class Questionnaire
    {
        public int QuestionnaireId { get; set; }
        public string Nom { get; set; }
        public DateTime DateCreation { get; set; }
        public DateTime DateModification { get; set; }
        public DateTime DatePrevue { get; set; }
        public string Description { get; set; }
        public bool Aleatoire { get; set; }
        public List<Question> Questions { get; set; }
        
        
    }

    public class Question
    {
        public int QuestionId { get; set; }
        public int NumQuestion { get; set; }
        public string LibelleQuestion { get; set; }
        public bool ChoixReponse { get; set; }
        public int Point { get; set; }
        public int Temps { get; set; }
        public bool OrdreReponse { get; set; }
        public List<Reponse> Reponses { get; set; }

        public Questionnaire Questionnaire { get; set; }
    }

    public class Reponse
    {
        public  int ReponseId { get; set; }
        public string LibelleReponse { get; set; }
        public bool Correcte { get; set; }
        public int Ordre { get; set; }

        public Question Question { get; set; }
    }

    #endregion

    #region VIEW

    public class V_NbQuestionCount
    {
        public int QuestionnaireId { get; set; }
        public string Nom { get; set; }
        public DateTime DateCreation { get; set; }
        public DateTime DateModification { get; set; }
        public bool Aleatoire { get; set; }
        public int NbQuestion { get; set; }
        public int NbPoint { get; set; }
    }

    #endregion

    

}
