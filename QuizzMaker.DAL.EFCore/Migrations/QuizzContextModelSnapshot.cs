// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using QuizzMaker.DAL.EFCore;

namespace QuizzMaker.DAL.EFCore.Migrations
{
    [DbContext(typeof(QuizzContext))]
    partial class QuizzContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.13");

            modelBuilder.Entity("QuizzMaker.BO.Question", b =>
                {
                    b.Property<int>("QuestionId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<bool>("ChoixReponse")
                        .HasColumnType("INTEGER");

                    b.Property<string>("LibelleQuestion")
                        .HasColumnType("TEXT");

                    b.Property<int>("NumQuestion")
                        .HasColumnType("INTEGER");

                    b.Property<bool>("OrdreReponse")
                        .HasColumnType("INTEGER");

                    b.Property<int>("Point")
                        .HasColumnType("INTEGER");

                    b.Property<int?>("QuestionnaireId")
                        .HasColumnType("INTEGER");

                    b.Property<int>("Temps")
                        .HasColumnType("INTEGER");

                    b.HasKey("QuestionId");

                    b.HasIndex("QuestionnaireId");

                    b.ToTable("Questions");
                });

            modelBuilder.Entity("QuizzMaker.BO.Questionnaire", b =>
                {
                    b.Property<int>("QuestionnaireId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<bool>("Aleatoire")
                        .HasColumnType("INTEGER");

                    b.Property<DateTime>("DateCreation")
                        .HasColumnType("TEXT");

                    b.Property<DateTime>("DateModification")
                        .HasColumnType("TEXT");

                    b.Property<DateTime>("DatePrevue")
                        .HasColumnType("TEXT");

                    b.Property<string>("Description")
                        .HasColumnType("TEXT");

                    b.Property<string>("Nom")
                        .HasColumnType("TEXT");

                    b.HasKey("QuestionnaireId");

                    b.ToTable("Questionnaires");
                });

            modelBuilder.Entity("QuizzMaker.BO.Reponse", b =>
                {
                    b.Property<int>("ReponseId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<bool>("Correcte")
                        .HasColumnType("INTEGER");

                    b.Property<string>("LibelleReponse")
                        .HasColumnType("TEXT");

                    b.Property<int>("Ordre")
                        .HasColumnType("INTEGER");

                    b.Property<int?>("QuestionId")
                        .HasColumnType("INTEGER");

                    b.HasKey("ReponseId");

                    b.HasIndex("QuestionId");

                    b.ToTable("Reponses");
                });

            modelBuilder.Entity("QuizzMaker.BO.Question", b =>
                {
                    b.HasOne("QuizzMaker.BO.Questionnaire", "Questionnaire")
                        .WithMany("Questions")
                        .HasForeignKey("QuestionnaireId");
                });

            modelBuilder.Entity("QuizzMaker.BO.Reponse", b =>
                {
                    b.HasOne("QuizzMaker.BO.Question", "Question")
                        .WithMany("Reponses")
                        .HasForeignKey("QuestionId");
                });
#pragma warning restore 612, 618
        }
    }
}
