using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using QuizzMaker.DAL.EFCore;
using QuizzMaker.BO;
using System.IO;

namespace QuizzMaker.BLL
{
    public class QuizzMakerManager
    {
        #region ATTRIBUTS

        private static QuizzMakerManager instance = null;
        private static readonly object myLock = new object();
      //  private RolistMakerContext db = new RolistMakerContext();
        private static SQLite_DAO _sqlModels = SQLite_DAO.GetInstance;



        #endregion

        #region ACCESSEURS
        
        private static Questionnaire Questionnaire { get; set; }

        public static QuizzMakerManager GetInstance
        {
            get
            {
                lock (myLock)
                {
                    if (instance == null)
                        instance = new QuizzMakerManager();
                    return instance;
                }
                
            }
        }

        public void SetQuestionnaire(int id)
        {
            Questionnaire = _sqlModels.GetQuestionnaire(id);
        }

     
        #endregion

        #region METHODES

        public bool QuestionnaireEnCours()
        {
            if (Questionnaire != null)
                return true;
            else
                return false;
        }

        public  (string, string, DateTime, bool) GetInfoQuestionnaire()
        {
            return (Questionnaire.Nom, Questionnaire.Description, Questionnaire.DatePrevue, Questionnaire.Aleatoire);
        }

        public List<Questionnaire> GetQuestionnaires(string sName, DateTime? dateJeu)
        {
            List<Questionnaire> questionnaires = new List<Questionnaire>();
            try
            {
                
                if (sName != string.Empty && dateJeu != null)
                    questionnaires = _sqlModels.GetQuestionnairesByNameAndDate(sName.Trim(), (DateTime)dateJeu);
                if (sName.Trim() != string.Empty && dateJeu == null)
                    questionnaires = _sqlModels.GetQuestionnairesByName(sName.Trim());
                if (sName.Trim() == string.Empty && dateJeu != null)
                    questionnaires = _sqlModels.GetQuestionnairesByDate((DateTime)dateJeu);
                if (sName.Trim() == string.Empty && dateJeu == null)
                    questionnaires = _sqlModels.GetAllQuestionnaires();
                return questionnaires;

            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public void SaveQuestionnaire(string sName, string sDescription, DateTime DateJeu, bool bRandom)
        {
            try
            {
                if (sName.Trim() == string.Empty)
                    throw new Exception("Indiquez un nom à votre fichier");
                if (Questionnaire == null)
                    Questionnaire = new Questionnaire();
                Questionnaire.Nom = sName.Trim();
                Questionnaire.Description = sDescription.Trim();
                Questionnaire.Aleatoire = bRandom;
                if (Questionnaire.QuestionnaireId == 0)
                    Questionnaire.DateCreation = DateTime.Now;
                Questionnaire.DateModification = DateTime.Now;
                Questionnaire.DatePrevue = DateJeu;

                Questionnaire myQuest = Questionnaire;
                Questionnaire = _sqlModels.SaveQuestionnaire(myQuest);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message, ex);
            }
        }
        
        public void DeleteQuestionnaire(int idQuestionnaire)
        {
            Questionnaire questionnaire = _sqlModels.GetQuestionnaire(idQuestionnaire);
            _sqlModels.DeleteQuestionnaire(questionnaire);        
        }
        
        public List<Question> GetQuestions()
        {
            try
            {
                return _sqlModels.GetAllQuestions(Questionnaire.QuestionnaireId);
            }
            catch (Exception ex)
            {

                throw new Exception(ex.Message,ex);
            }
        }

        public void SaveQuestion(int idQuestion, string sLibelle, bool bChoixReponse, int iPoints, int iTemps )
        {
            try
            {
                Question myQuest = new Question();
                if(idQuestion != 0)
                {
                    try
                    {
                        myQuest = _sqlModels.GetQuestion(idQuestion);
                    }
                    catch (Exception)
                    {

                        throw new Exception("La question modifiée est introuvable");
                    }
                }

                myQuest.LibelleQuestion = sLibelle.Trim();
                if(myQuest.NumQuestion == 0)
                    myQuest.NumQuestion = _sqlModels.GetCountQuestion(Questionnaire.QuestionnaireId)+1;
                myQuest.ChoixReponse = bChoixReponse;
                myQuest.Point = iPoints;
                myQuest.Temps =iTemps;
                _sqlModels.SaveQuestion(myQuest, Questionnaire.QuestionnaireId);
                
            }
            catch (Exception ex)
            {

                throw new Exception(ex.Message);
            }
        }
        
        public void DeleteQuestion(int idQuestion)
        {
            try
            {
                Question question = _sqlModels.GetQuestion(idQuestion);
                foreach (Reponse r in question.Reponses)
                    DeleteReponse(r.ReponseId);
                _sqlModels.DeleteQuestion(question);
                _sqlModels.ReOrderQuestion(question.NumQuestion, Questionnaire.QuestionnaireId);
            }
            catch (Exception ex)
            {

                throw new Exception(ex.Message, ex);
            }
        }
        /// <summary>
        /// Change l'ordre d'apparition d'une question dans le jeu
        /// </summary>
        /// <param name="idQuestion"></param>
        /// <param name="iMovePlace"></param>
        public void MoveOrderQuestion(int idQuestion, int iMovePlace)
        {
            try
            {
                
                Question NewQuestion = _sqlModels.GetQuestion(idQuestion);
               
               
                if ((NewQuestion.NumQuestion + iMovePlace) > _sqlModels.GetCountQuestion(Questionnaire.QuestionnaireId) || NewQuestion.NumQuestion + iMovePlace <= 0)
                    throw new Exception("Impossible de mettre la question à cette position");

                NewQuestion.NumQuestion += iMovePlace;
                Question OldQuestion = _sqlModels.GetQuestionByNum(Questionnaire.QuestionnaireId, NewQuestion.NumQuestion);
                if (OldQuestion != null)
                {
                    OldQuestion.NumQuestion -= iMovePlace;
                    _sqlModels.SaveQuestion(OldQuestion, Questionnaire.QuestionnaireId);
                }
                _sqlModels.SaveQuestion(NewQuestion, Questionnaire.QuestionnaireId);

            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message, ex);
            }
        }

        public List<Reponse> GetReponses(int idQuestion)
        {
            try
            {
                return _sqlModels.GetAllReponses(idQuestion);
            }
            catch (Exception ex)
            {

                throw new Exception(ex.Message, ex);
            }
        }

        public void SaveReponse(int idReponse, string sLibelle, bool bBonneReponse, int idQuestion)
        {
            try
            {
                Reponse r = new Reponse();
                if (idReponse != 0)
                {
                    try
                    {
                        r = _sqlModels.GetReponse(idReponse);
                    }
                    catch (Exception)
                    {
                        throw new Exception("La réponse modifiée est introuvable");
                    }
                }

                r.LibelleReponse = sLibelle.Trim();
                if (r.Ordre == 0)
                    r.Ordre = _sqlModels.GetCountReponse(idQuestion) + 1;
                r.Correcte = bBonneReponse;
                _sqlModels.SaveReponse(r, idQuestion);

            }
            catch (Exception ex)
            {

                throw new Exception("Impossible de sauvegarder la réponse - " + ex.Message);
            }
        }

        public void DeleteReponse(int idReponse)
        {
            try
            {
                Reponse r = _sqlModels.GetReponse(idReponse);
                _sqlModels.DeleteReponse(r);
                _sqlModels.ReOrderReponse(r.Ordre, r.Question.QuestionId);
            }
            catch (Exception ex)
            {

                throw new Exception(ex.Message, ex);
            }
        }
        /// <summary>
        /// Change l'ordre d'apparition d'une reponse dans le jeu
        /// </summary>
        /// <param name="idReponse"></param>
        /// <param name="iMovePlace"></param>
        public void MoveOrderReponse(int idReponse, int iMovePlace)
        {
            try
            {
                Reponse NewReponse = _sqlModels.GetReponse(idReponse);
                if ((NewReponse.Ordre + iMovePlace) > _sqlModels.GetCountReponse(NewReponse.Question.QuestionId) || NewReponse.Ordre + iMovePlace <= 0)
                    throw new Exception("Impossible de mettre la Reponse à cette position");

                NewReponse.Ordre += iMovePlace;
                Reponse OldReponse = _sqlModels.GetReponseByNum(NewReponse.Question.QuestionId, NewReponse.Ordre);
                if (OldReponse != null)
                {
                    OldReponse.Ordre -= iMovePlace;
                    _sqlModels.SaveReponse(OldReponse, OldReponse.Question.QuestionId);
                }
                _sqlModels.SaveReponse(NewReponse, NewReponse.Question.QuestionId);

            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message, ex);
            }
        }

        #region METHODES DE TEST



        #endregion
        #endregion

    }
}
