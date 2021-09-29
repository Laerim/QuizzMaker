using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using QuizzMaker.BO;

namespace QuizzMaker.DAL.EFCore
{
    public class SQLite_DAO
    {
        #region ATTRIBUTS

        private static SQLite_DAO instance = null;
        private static readonly object myLock = new object();
        private QuizzContext db = new QuizzContext();


        #endregion

        #region ACCESSEURS

        public static SQLite_DAO GetInstance
        {
            get
            {
                lock (myLock)
                {
                    if (instance == null)
                        instance = new SQLite_DAO();
                    return instance;
                }
            }
        }
        #endregion

        #region MÉTHODES



        #region QUESTIONNAIRE

        public List<Questionnaire> GetAllQuestionnaires()
        {
            var Questionnaires = db.Questionnaires
                .OrderBy(c => c.Nom).ToList();
            return Questionnaires;
        }

        public Questionnaire GetQuestionnaire(int? idQuestionnaire)
        {
            Questionnaire Questionnaire = new Questionnaire();
            Questionnaire = db.Questionnaires.FirstOrDefault(d => d.QuestionnaireId == idQuestionnaire);
            return Questionnaire;
        }

        public Questionnaire SaveQuestionnaire(Questionnaire Questionnaire)
        {
            try
            {
                if(Questionnaire.QuestionnaireId == 0)
                    db.Questionnaires.Add(Questionnaire);
                db.SaveChanges();
                return Questionnaire;
            }
            catch (Exception ex)
            {
                throw new Exception("Impossible de sauvegarder le Quizz", ex);
            }
        }
        public void DeleteQuestionnaire(Questionnaire Questionnaire)
        {
            List<Question> questions = GetAllQuestions(Questionnaire.QuestionnaireId);
            questions.ForEach(x => DeleteQuestion(x));
           
            db.Questionnaires.Remove(Questionnaire);
            db.SaveChanges();
        }

        public List<Questionnaire> GetQuestionnairesByName(string sName)
        {
            try
            {
                return db.Questionnaires.Where(q => q.Nom.Contains(sName.Trim())).ToList();
            }
            catch (Exception ex)
            {

                throw new Exception(ex.Message);
            }
        }
        public List<Questionnaire> GetQuestionnairesByDate(DateTime date)
        {
            try
            {
                return db.Questionnaires.Where(q => q.DatePrevue.Equals(date)).ToList();
            }
            catch (Exception ex)
            {

                throw new Exception(ex.Message);
            }
        }
        public List<Questionnaire> GetQuestionnairesByNameAndDate(string sName, DateTime date)
        {
            try
            {
                return db.Questionnaires.Where(q => q.DatePrevue.Equals(date) && sName.Contains(sName.Trim())).ToList();
            }
            catch (Exception ex)
            {

                throw new Exception(ex.Message);
            }
        }

        #endregion

        #region QUESTION

        public List<Question> GetAllQuestions(int idQuestionnaire)
        {
            var Questions = db.Questions
                .Where(c => c.Questionnaire.QuestionnaireId == idQuestionnaire)
                .OrderBy(c => c.LibelleQuestion).ToList();
            return Questions;
        }
        public Question GetQuestion(int? idQuestion)
        {
            try
            {
                Question Question = new Question();
                Question = db.Questions.FirstOrDefault(m => m.QuestionId == idQuestion);
                return Question;
            }
            catch (Exception ex)
            {

                throw new Exception("Impossible de récupérer cette Question", ex);
            }
        }

        public Question GetQuestionByNum(int idQuestionnaire, int iNum)
        {
            var question = db.Questions.FirstOrDefault(q => q.Questionnaire.QuestionnaireId == idQuestionnaire &&  q.NumQuestion == iNum);
            return question;
        }
        public void SaveQuestion(Question Question, int idQuestionnaire)
        {
            try
            {
                Questionnaire Questionnaire = db.Questionnaires.FirstOrDefault(m => m.QuestionnaireId == idQuestionnaire);
                Question.Questionnaire = Questionnaire;
                if (Question.QuestionId == 0)
                    db.Questions.Add(Question);
                db.SaveChanges();
            }
            catch (Exception ex)
            {
                throw new Exception("Impossible de sauvegarder la Question", ex);
            }
        }
        public void DeleteQuestion(Question Question)
        {
            List<Reponse> reponses = GetAllReponses(Question.QuestionId);
            reponses.ForEach(x => DeleteReponse(x));
          
            db.Questions.Remove(Question);
            db.SaveChanges();
        }

        public int GetCountQuestion(int idQuestionnaire)
        {
            try
            {
                
                int count = db.Questions.Count(a => a.Questionnaire.QuestionnaireId == idQuestionnaire);
                return count;
            }
            catch (Exception)
            {

                throw new Exception("Impossble de compter les questions");
            }

        }
        public void ReOrderQuestion(int iNumQuestionDelete, int idQuestionnaire)
        {
            try
            {
                List<Question> questions = GetAllQuestions(idQuestionnaire);
                questions.Where(q => q.NumQuestion > iNumQuestionDelete).ToList()
                            .ForEach(q => q.NumQuestion--);
                db.SaveChanges();
            }
            catch (Exception)
            {

                throw;
            }
        }
        #endregion

        #region REPONSE

        public List<Reponse> GetAllReponses(int idQuestion)
        {
            var Reponses = db.Reponses
                .Where(c => c.Question.QuestionId == idQuestion)
                .OrderBy(c => c.LibelleReponse).ToList();
            return Reponses;
        }
        public Reponse GetReponse(int? idReponse)
        {
            try
            {
                Reponse Reponse = new Reponse();
                Reponse = db.Reponses.FirstOrDefault(m => m.ReponseId == idReponse);
                return Reponse;
            }
            catch (Exception ex)
            {

                throw new Exception("Impossible de récupérer cette Reponse", ex);
            }
        }
        public void SaveReponse(Reponse Reponse, int idQuestion)
        {
            try
            {
                Question Question = db.Questions.FirstOrDefault(m => m.QuestionId == idQuestion);
                Reponse.Question = Question;
                if (Reponse.ReponseId == 0)
                    db.Reponses.Add(Reponse);
                db.SaveChanges();
            }
            catch (Exception ex)
            {
                throw new Exception("Impossible de sauvegarder la Reponse", ex);
            }
        }
        public void DeleteReponse(Reponse Reponse)
        {
            db.Reponses.Remove(Reponse);
            db.SaveChanges();
        }

        public int GetCountReponse(int idQuestion)
        {
            try
            {

                int count = db.Reponses.Count(r => r.Question.QuestionId == idQuestion);
                    
                return count;
            }
            catch (Exception)
            {

                throw new Exception("Impossble de compter les réponses");
            }

        }
        public void ReOrderReponse(int iNumReponseDelete, int idQuestion)
        {
            try
            {
                db.Reponses.Where(r => r.Question.QuestionId == idQuestion && r.Ordre > iNumReponseDelete).ToList()
                    .ForEach(r => r.Ordre--);
                db.SaveChanges();
            }
            catch (Exception)
            {

                throw new Exception("Impossible de réorganiser l'ordre des réponses");
            }
        }

        public Reponse GetReponseByNum(int idQuestion, int iNum)
        {
            var reponse = db.Reponses.FirstOrDefault(q => q.Question.QuestionId == idQuestion && q.Ordre == iNum);
            return reponse;
        }
        #endregion

        #region VUES

        public List<V_NbQuestionCount> GetQuestionnaireNbQuestions()
        {
            var value = from p in db.Questionnaires
                        join c in db.Questions on p.QuestionnaireId equals c.Questionnaire.QuestionnaireId into g
                        select new V_NbQuestionCount{ QuestionnaireId = p.QuestionnaireId, Nom = p.Nom, DateCreation = p.DateCreation,
                            DateModification = p.DateModification, Aleatoire = p.Aleatoire, NbQuestion = g.Count(), NbPoint = 0 };


            List<V_NbQuestionCount> myList = value.ToList();
            return myList;
        }

        #endregion

        #endregion
    }
}
