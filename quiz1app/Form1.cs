using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace quiz1app
{
    public partial class Form1 : Form
    {

        // quiz game variable


        int correctAnswer;
        int questionNumber = 1;
        int score;
        int percentage;
        int totalQuestions;


        public Form1()
        {
            InitializeComponent();

            askQuestion(questionNumber);

            totalQuestions = 6;
        }

        private void checkAnswerEvent(object sender, EventArgs e)
        {
            var senderObject = (Button)sender;

            int buttonTag = Convert.ToInt32(senderObject.Tag);

            if (buttonTag == correctAnswer)
            {
                score++;
            }

            if (questionNumber == totalQuestions)
            {
                // work out the percentage

                percentage = (int)Math.Round((double)(score * 100) / totalQuestions);

                MessageBox.Show(
                    "Quizz sesat selesai" + Environment.NewLine +
                    "kamu telah menjawab " + score + " soal benar,,, horeeeee" + Environment.NewLine +
                    "nilai kamu adalah " + percentage +"%" + Environment.NewLine +
                    "selamat kamu mendapatkan tiket kenerapa jalur VIP" + Environment.NewLine +
                    "klik OK untuk mencoba kembali dan dapatkan kesempatan foto gratis bersama lucifer"
                    );
                score = 0;
                questionNumber = 0;
                askQuestion(questionNumber);

            }

            questionNumber++;
            askQuestion(questionNumber);
        }

        private void askQuestion(int qnum)
        {

            switch (qnum)
            {
                case 1 :
                    pictureBox1.Image = Properties.Resources.lapar;
                    lblQuestion.Text = "Apa yang sedang mereka makan?";

                    button1.Text = "Batu dan Tanah";
                    button2.Text = "kfc";
                    button3.Text = "daging babi";
                    button4.Text = "sari roti";


                    correctAnswer = 1;

                    break;


                case 2:
                    pictureBox1.Image = Properties.Resources.lapar;
                    lblQuestion.Text = "kenapa tubuh mereka kurus dan kering kerontang?";

                    button1.Text = "karena kekurangan makanan";
                    button2.Text = "karena kekurangan air";
                    button3.Text = "karena wilayah mereka kering";
                    button4.Text = "semua jawaban benar";


                    correctAnswer = 4;

                    break;

                case 3:
                    pictureBox1.Image = Properties.Resources.war;
                    lblQuestion.Text = "sedang apakah mereka berlarian memegang senjata diantara bangunan yang telah di bomb?";

                    button1.Text = "main free fire di real life";
                    button2.Text = "perang di palestina";
                    button3.Text = "main pubg real life";
                    button4.Text = "berburu ";


                    correctAnswer = 2;

                    break;

                case 4:
                    pictureBox1.Image = Properties.Resources.buntung;
                    lblQuestion.Text = "jika kita amati, mutan itu telah menciptakan sesuatu, sesuatu apakah itu?";

                    button1.Text = "kaki palsu (dari kayu lagi)";
                    button2.Text = "asbak rokok";
                    button3.Text = "tongkat kera sakti";
                    button4.Text = "tongkat yahud*";


                    correctAnswer = 1;

                    break;

                case 5 :
                    pictureBox1.Image = Properties.Resources.rudal;
                    lblQuestion.Text = "benda ini sering kita jumpai di?";

                    button1.Text = "indonesia";
                    button2.Text = "timur tengah";
                    button3.Text = "eropa";
                    button4.Text = "burundi";


                    correctAnswer = 2;

                    break;

                case 6 :
                    pictureBox1.Image = Properties.Resources.kursiroda;
                    lblQuestion.Text = "apa sedang yang beliau naiki?";

                    button1.Text = "jet israel";
                    button2.Text = "buroq";
                    button3.Text = "kereta kencana";
                    button4.Text = "kursi roda mode tidur";

                    correctAnswer = 4;

                    break;
            }




        
        }
    }
}
