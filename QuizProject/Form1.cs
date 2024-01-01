using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuizProject
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }


        private void buttonColorDefault()
        {
            buttonA.BackColor = Color.White;
            buttonB.BackColor = Color.White;
            buttonC.BackColor = Color.White;
            buttonD.BackColor = Color.White;
        }

        private void disabledAllButtons()
        {
            buttonA.Enabled = false;
            buttonB.Enabled = false;
            buttonC.Enabled = false;
            buttonD.Enabled = false;
        }

        private void enabledAllButtons()
        {
            buttonA.Enabled = true;
            buttonB.Enabled = true;
            buttonC.Enabled = true;
            buttonD.Enabled = true;
        }

        public int questionNumber = 1;
        public int trueNumber = 0;
        public int falseNumber = 0;
        private void buttonNext_Click(object sender, EventArgs e)
        {
                       
            buttonNext.Enabled = false;
            buttonColorDefault(); 
            pictureBoxGreen.Visible = false;
            pictureBoxRed.Visible = false;
            enabledAllButtons();
            questionNumber++;
            labelQuestionNumber.Text = questionNumber.ToString();

            

            if (questionNumber == 2){

                richTextBoxQuestion.Text = "2. Bağlaç olan de kanayan yaramız :) Hangi cümlede de bağlacının/ -de ekinin yazımı doğrudur?" +
                    "\n\nA - Kuralı şöyle değiştirmekte mümkün." +
                    "\n\nB - Eğer sizde öyle düşüyorsanız beni ve bu kuralı desteklemek adına yazıyı paylaşın." +
                    "\n\nC - Bulunma hali de aslında diğerine nazaran daha kolay tespit edilebilen bir şey ama o da kafa karıştırabiliyor." + //**
                    "\n\nD - Bu kuralı bana yıllar önce, ilköğretim okulun da Türkçe öğretmenim öğretmişti.";
            }

            else if (questionNumber == 3)
            {

                richTextBoxQuestion.Text = "3. Peki hangi ki bağlacı/ - ki ekinin yazımı doğrudur?" +
                    "\n\nA - Onun ne kabahati varki!" +
                    "\n\nB - Bana öylesine yakındıki kardeşimden ayıramazdım." +
                    "\n\nC - Akşam ki toplantı çok şiddetliydi." +
                    "\n\nD - Mademki dün gelmedin bugün gelmesen de olur."; //**
            }

            else if (questionNumber == 4)
            {

                richTextBoxQuestion.Text = "4. Aşağıdaki kelime gruplarından hangisindeki tüm kelimeler doğru yazılmıştır? (TDK)" +
                    "\n\nA - Pantalon - Tıraş - Yalnız - Kravat - Maydanoz - Çikolata" +
                    "\n\nB - Kibrit - Konservatuar - Kirpik - Kılavuz - Pardösü - Sarj" +
                    "\n\nC - Travma - İddia - Sarımsak - Dinozor - Zarafet - Akşamüstü" + //**
                    "\n\nD - Entelektüel - Azerbaycan - Egzoz - Orjinal - Hristiyan - İskonto";
            }
            
            else if (questionNumber == 5)
            {

                richTextBoxQuestion.Text = "5. Bu dizelerde aşağıdaki ses olaylarından hangisi yoktur?" +
                    "\n\nKoca şehrin üstünde ipi kopmuş bir uçurtmayım;\n" +
                    "Rüzgârlara kayıyor göğsüm sarsıla sarsıla.\n" +
                    "Koca şehrin üstünden ipi kopmuş bir uçurtmayım\n" +
                    "Ki uçurtmuştu beni çocukluğum, hülayalarıyla;";

                buttonA.Text = "Ünlü daralması"; //**
                buttonB.Text = "Ünsüz yumuşaması";
                buttonC.Text = "Ulama";
                buttonD.Text = "Ünlü düşmesi";
            }

            else if (questionNumber == 6)
            {

                richTextBoxQuestion.Text = "6. Aşağıdaki roman kahraman eşleştirmelerinden hangisi yanlıştır?";

                buttonA.Text = "Araba Sevdası – Bihruz Bey"; //**
                buttonB.Text = "İntibah – Ali Bey";
                buttonC.Text = "Eylül – Necip";
                buttonD.Text = "Şıpsevdi – Aliye";
            }

            else if (questionNumber == 7)
            {

                richTextBoxQuestion.Text = "7. Bu cümlede aşağıdaki ögelerden hangisi bulunmamaktadır?" +
                    "\n\nTürkiye'nin ulu dağlarını, ıssız koylarını, göç dışında kimsenin ayak basmadığı sarp geçitlerini anlatan renkler; en az kendileri kadar etkileyici motif ve desenlerde yer yer boy gösteriyor.";
                    
                buttonA.Text = "Dolaylı tümleç";
                buttonB.Text = "Zarf tümleci";
                buttonC.Text = "Özne";
                buttonD.Text = "Belirtili nesne"; //**
            }

            else if (questionNumber == 8)
            {

                richTextBoxQuestion.Text = "8. Ünlü sanatçı, yaşadığı deneyimlerini okurlarıyla paylaştığı son yapıtını oldukça samimi, içten bir söyleyişle kaleme almış.\r\nBu cümlede gereksiz yere kullanılmış sözcükler aşağıdakilerin hangisinde bir arada verilmiştir?" +
                    "\n\nA - yaşadığı - deneyimlerini" +
                    "\n\nB - okurlarıyla - oldukça" +
                    "\n\nC - yaşadığı - samimi" + //**
                    "\n\nD - okurlarıyla - içten";

                buttonA.Text = "A";
                buttonB.Text = "B";
                buttonC.Text = "C";
                buttonD.Text = "D";
            }

            else if (questionNumber == 9)
            {

                richTextBoxQuestion.Text = "9. Aşağıdaki cümlelerin hangisinde yazım yanlışı yoktur?" +
                    "\n\nA - Yıllar geçsede sana olan sevgim bitmeyecek." +
                    "\n\nB - Bana kalırsa kardeşime yirmi lirada yeter." +
                    "\n\nC - Ya sunumu hazırlarsın yada toplantıya katılamazsın." +
                    "\n\nD - Çorum'da giderken yakıt bittiği için yolda kaldı."; //**

                buttonA.Text = "A";
                buttonB.Text = "B";
                buttonC.Text = "C";
                buttonD.Text = "D";
            }

            else if (questionNumber == 10)
            {

                richTextBoxQuestion.Text = "10. Hangi kelime dilimize yabancı bir dilden geçmiştir?" +
                    "\n\nA - Angarya" + //**
                    "\n\nB - Akım" +
                    "\n\nC - Boğa" +
                    "\n\nD - Bıdık";

                buttonA.Text = "A";
                buttonB.Text = "B";
                buttonC.Text = "C";
                buttonD.Text = "D";
            }

            if (questionNumber == 11)
            {
                             
                FormEnd frmEnd = new FormEnd();               
                frmEnd.Show();
                this.Close();
                
                

                
            }
        }

        private void buttonA_Click(object sender, EventArgs e)
        {
            disabledAllButtons();

            if (labelQuestionNumber.Text == "5")
            {
                buttonA.BackColor = Color.Green;
                pictureBoxGreen.Visible = true;
                trueNumber++;
                labelTrue.Text = trueNumber.ToString();
                buttonNext.Enabled = true;
            }

            if (labelQuestionNumber.Text == "6")
            {
                buttonA.BackColor = Color.Green;
                pictureBoxGreen.Visible = true;
                trueNumber++;
                labelTrue.Text = trueNumber.ToString();
                buttonNext.Enabled = true;
            }

            if (labelQuestionNumber.Text == "10")
            {
                buttonA.BackColor = Color.Green;
                pictureBoxGreen.Visible = true;
                trueNumber++;
                labelTrue.Text = trueNumber.ToString();
                buttonNext.Enabled = true;
                
            }

            if (labelQuestionNumber.Text == "1")
            {
                pictureBoxRed.Visible = true;
                buttonA.BackColor = Color.Red;
                buttonNext.Enabled = true;
            }

            if (labelQuestionNumber.Text == "2")
            {
                pictureBoxRed.Visible = true;
                buttonA.BackColor = Color.Red;
                buttonNext.Enabled = true;
            }

            if (labelQuestionNumber.Text == "3")
            {
                pictureBoxRed.Visible = true;
                buttonA.BackColor = Color.Red;
                buttonNext.Enabled = true;
            }

            if (labelQuestionNumber.Text == "4")
            {
                pictureBoxRed.Visible = true;
                buttonA.BackColor = Color.Red;
                buttonNext.Enabled = true;
            }

            if (labelQuestionNumber.Text == "7")
            {
                pictureBoxRed.Visible = true;
                buttonA.BackColor = Color.Red;
                buttonNext.Enabled = true;
            }

            if (labelQuestionNumber.Text == "8")
            {
                pictureBoxRed.Visible = true;
                buttonA.BackColor = Color.Red;
                buttonNext.Enabled = true;
            }

            if (labelQuestionNumber.Text == "9")
            {
                pictureBoxRed.Visible = true;
                buttonA.BackColor = Color.Red;
                buttonNext.Enabled = true;
            }

            if (labelQuestionNumber.Text == "10")
            {
                pictureBoxGreen.Visible = true;
                trueNumber++;
                labelTrue.Text = trueNumber.ToString();
                buttonNext.Enabled = true;
                buttonNext.Text = "Sınavı Bitir";                
                
                
            }
           

            if (labelQuestionNumber.Text == "1")
            {
                pictureBoxRed.Visible = true;
                falseNumber++;
                labelFalse.Text = falseNumber.ToString();
                buttonNext.Enabled = true;
            }

            if (labelQuestionNumber.Text == "2")
            {
                pictureBoxRed.Visible = true;
                falseNumber++;
                labelFalse.Text = falseNumber.ToString();
                buttonNext.Enabled = true;
            }

            if (labelQuestionNumber.Text == "3")
            {
                pictureBoxRed.Visible = true;
                falseNumber++;
                labelFalse.Text = falseNumber.ToString();
                buttonNext.Enabled = true;
            }

            if (labelQuestionNumber.Text == "4")
            {
                pictureBoxRed.Visible = true;
                falseNumber++;
                labelFalse.Text = falseNumber.ToString();
                buttonNext.Enabled = true;
            }

            if (labelQuestionNumber.Text == "7")
            {
                pictureBoxRed.Visible = true;
                falseNumber++;
                labelFalse.Text = falseNumber.ToString();
                buttonNext.Enabled = true;
            }

            if (labelQuestionNumber.Text == "8")
            {
                pictureBoxRed.Visible = true;
                falseNumber++;
                labelFalse.Text = falseNumber.ToString();
                buttonNext.Enabled = true;
            }

            if (labelQuestionNumber.Text == "9")
            {
                pictureBoxRed.Visible = true;
                falseNumber++;
                labelFalse.Text = falseNumber.ToString();
                buttonNext.Enabled = true;
            }
        }

        private void buttonD_Click(object sender, EventArgs e)
        {
            disabledAllButtons();


            if (labelQuestionNumber.Text == "1")
            {
                buttonD.BackColor = Color.Green;
                pictureBoxGreen.Visible = true;
                trueNumber++;
                labelTrue.Text = trueNumber.ToString();
                buttonNext.Enabled = true;
            }

            if (labelQuestionNumber.Text == "3")
            {
                buttonD.BackColor = Color.Green;
                pictureBoxGreen.Visible = true;
                trueNumber++;
                labelTrue.Text = trueNumber.ToString();
                buttonNext.Enabled = true;
            }

            if (labelQuestionNumber.Text == "7")
            {
                buttonD.BackColor = Color.Green;
                pictureBoxGreen.Visible = true;
                trueNumber++;
                labelTrue.Text = trueNumber.ToString();
                buttonNext.Enabled = true;
            }

            if (labelQuestionNumber.Text == "2")
            {
                pictureBoxRed.Visible = true;
                buttonD.BackColor = Color.Red;
                buttonNext.Enabled = true;
            }

            if (labelQuestionNumber.Text == "4")
            {
                pictureBoxRed.Visible = true;
                buttonD.BackColor = Color.Red;
                buttonNext.Enabled = true;
                buttonNext.Enabled = true;
            }

            if (labelQuestionNumber.Text == "5")
            {
                pictureBoxRed.Visible = true;
                buttonD.BackColor = Color.Red;
                buttonNext.Enabled = true;
            }

            if (labelQuestionNumber.Text == "6")
            {
                pictureBoxRed.Visible = true;
                buttonD.BackColor = Color.Red;
                buttonNext.Enabled = true;
            }

            if (labelQuestionNumber.Text == "8")
            {
                pictureBoxRed.Visible = true;
                buttonD.BackColor = Color.Red;
                buttonNext.Enabled = true;
            }

            if (labelQuestionNumber.Text == "9")
            {
                buttonD.BackColor = Color.Green;
                pictureBoxGreen.Visible = true;
                trueNumber++;
                labelTrue.Text = trueNumber.ToString();
                buttonNext.Enabled = true;
            }

            if (labelQuestionNumber.Text == "10")
            {
                pictureBoxRed.Visible = true;
                buttonNext.Enabled = true;
                buttonNext.Text = "Sınavı Bitir";
                
            }

            if (labelQuestionNumber.Text == "2")
            {
                pictureBoxRed.Visible = true;
                falseNumber++;
                labelFalse.Text = falseNumber.ToString();
                buttonNext.Enabled = true;
            }

            if (labelQuestionNumber.Text == "4")
            {
                pictureBoxRed.Visible = true;
                falseNumber++;
                labelFalse.Text = falseNumber.ToString();
                buttonNext.Enabled = true;
            }

            if (labelQuestionNumber.Text == "5")
            {
                pictureBoxRed.Visible = true;
                falseNumber++;
                labelFalse.Text = falseNumber.ToString();
                buttonNext.Enabled = true;
            }

            if (labelQuestionNumber.Text == "6")
            {
                pictureBoxRed.Visible = true;
                falseNumber++;
                labelFalse.Text = falseNumber.ToString();
                buttonNext.Enabled = true;
            }
           

            if (labelQuestionNumber.Text == "8")
            {
                pictureBoxRed.Visible = true;
                falseNumber++;
                labelFalse.Text = falseNumber.ToString();
                buttonNext.Enabled = true;
            }

            if (labelQuestionNumber.Text == "10")
            {
                pictureBoxRed.Visible = true;
                falseNumber++;
                labelFalse.Text = falseNumber.ToString();
                buttonNext.Enabled = true;
                buttonNext.Text = "Sınavı Bitir";
                

            }
        }

        private void buttonC_Click(object sender, EventArgs e)
        {
            disabledAllButtons();

            if (labelQuestionNumber.Text == "2")
            {
                buttonC.BackColor = Color.Green;
                pictureBoxGreen.Visible = true;
                trueNumber++;
                labelTrue.Text = trueNumber.ToString();
                buttonNext.Enabled = true;
            }

            if (labelQuestionNumber.Text == "4")
            {
                buttonC.BackColor = Color.Green;
                pictureBoxGreen.Visible = true;
                trueNumber++;
                labelTrue.Text = trueNumber.ToString();
                buttonNext.Enabled = true;
            }

            if (labelQuestionNumber.Text == "8")
            {
                buttonC.BackColor = Color.Green;
                pictureBoxGreen.Visible = true;
                trueNumber++;
                labelTrue.Text = trueNumber.ToString();
                buttonNext.Enabled = true;
            }
          

            if (labelQuestionNumber.Text == "1")
            {
                pictureBoxRed.Visible = true;
                buttonC.BackColor = Color.Red;
                buttonNext.Enabled = true;
            }

            if (labelQuestionNumber.Text == "3")
            {
                pictureBoxRed.Visible = true;
                buttonC.BackColor = Color.Red;
                buttonNext.Enabled = true;
            }

            if (labelQuestionNumber.Text == "5")
            {
                pictureBoxRed.Visible = true;
                buttonC.BackColor = Color.Red;
                buttonNext.Enabled = true;
            }

            if (labelQuestionNumber.Text == "6")
            {
                pictureBoxRed.Visible = true;
                buttonC.BackColor = Color.Red;
                buttonNext.Enabled = true;
            }

            if (labelQuestionNumber.Text == "7")
            {
                pictureBoxRed.Visible = true;
                buttonC.BackColor = Color.Red;
                buttonNext.Enabled = true;
            }

            if (labelQuestionNumber.Text == "9")
            {
                pictureBoxRed.Visible = true;
                buttonC.BackColor = Color.Red;
                buttonNext.Enabled = true;
            }

            if (labelQuestionNumber.Text == "10")
            {
                pictureBoxRed.Visible = true;
                buttonC.BackColor = Color.Red;
                buttonNext.Enabled = true;
                buttonNext.Text = "Sınavı Bitir";
                
            }

            if (labelQuestionNumber.Text == "1")
            {
                pictureBoxRed.Visible = true;
                falseNumber++;
                labelFalse.Text = falseNumber.ToString();
                buttonNext.Enabled = true;
            }

            if (labelQuestionNumber.Text == "3")
            {
                pictureBoxRed.Visible = true;
                falseNumber++;
                labelFalse.Text = falseNumber.ToString();
                buttonNext.Enabled = true;
            }

            if (labelQuestionNumber.Text == "5")
            {
                pictureBoxRed.Visible = true;
                falseNumber++;
                labelFalse.Text = falseNumber.ToString();
                buttonNext.Enabled = true;
            }

            if (labelQuestionNumber.Text == "6")
            {
                pictureBoxRed.Visible = true;
                falseNumber++;
                labelFalse.Text = falseNumber.ToString();
                buttonNext.Enabled = true;
            }

            if (labelQuestionNumber.Text == "7")
            {
                pictureBoxRed.Visible = true;
                falseNumber++;
                labelFalse.Text = falseNumber.ToString();
                buttonNext.Enabled = true;
            }

            if (labelQuestionNumber.Text == "9")
            {
                pictureBoxRed.Visible = true;
                falseNumber++;
                labelFalse.Text = falseNumber.ToString();
                buttonNext.Enabled = true;
            }

            if (labelQuestionNumber.Text == "10")
            {
                pictureBoxRed.Visible = true;
                falseNumber++;
                labelFalse.Text = falseNumber.ToString();
                buttonNext.Enabled = true;
                buttonNext.Text = "Sınavı Bitir";
                

            }
        }

        private void buttonB_Click(object sender, EventArgs e)
        {
            disabledAllButtons();

            if (labelQuestionNumber.Text == "1")
            {
                pictureBoxRed.Visible = true;
                buttonB.BackColor = Color.Red;
                buttonNext.Enabled = true;
            }

            if (labelQuestionNumber.Text == "2")
            {
                pictureBoxRed.Visible = true;
                buttonB.BackColor = Color.Red;
                buttonNext.Enabled = true;
            }

            if (labelQuestionNumber.Text == "3")
            {
                pictureBoxRed.Visible = true;
                buttonB.BackColor = Color.Red;
                buttonNext.Enabled = true;
            }

            if (labelQuestionNumber.Text == "4")
            {
                pictureBoxRed.Visible = true;
                buttonB.BackColor = Color.Red;
                buttonNext.Enabled = true;
            }

            if (labelQuestionNumber.Text == "5")
            {
                pictureBoxRed.Visible = true;
                buttonB.BackColor = Color.Red;
                buttonNext.Enabled = true;
            }

            if (labelQuestionNumber.Text == "6")
            {
                pictureBoxRed.Visible = true;
                buttonB.BackColor = Color.Red;
                buttonNext.Enabled = true;
            }

            if (labelQuestionNumber.Text == "7")
            {
                pictureBoxRed.Visible = true;
                buttonB.BackColor = Color.Red;
                buttonNext.Enabled = true;
            }

            if (labelQuestionNumber.Text == "8")
            {
                pictureBoxRed.Visible = true;
                buttonB.BackColor = Color.Red;
                buttonNext.Enabled = true;
            }

            if (labelQuestionNumber.Text == "9")
            {
                pictureBoxRed.Visible = true;
                buttonB.BackColor = Color.Red;
                buttonNext.Enabled = true;
            }

            if (labelQuestionNumber.Text == "10")
            {
                pictureBoxRed.Visible = true;
                buttonB.BackColor = Color.Red;
                buttonNext.Enabled = true;
                buttonNext.Text = "Sınavı Bitir";
               
            }

            if (labelQuestionNumber.Text == "1")
            {
                pictureBoxRed.Visible = true;
                falseNumber++;
                labelFalse.Text = falseNumber.ToString();
                buttonNext.Enabled = true;
            }

            if (labelQuestionNumber.Text == "2")
            {
                pictureBoxRed.Visible = true;
                falseNumber++;
                labelFalse.Text = falseNumber.ToString();
                buttonNext.Enabled = true;
            }

            if (labelQuestionNumber.Text == "3")
            {
                pictureBoxRed.Visible = true;
                falseNumber++;
                labelFalse.Text = falseNumber.ToString();
                buttonNext.Enabled = true;
            }

            if (labelQuestionNumber.Text == "4")
            {
                pictureBoxRed.Visible = true;
                falseNumber++;
                labelFalse.Text = falseNumber.ToString();
                buttonNext.Enabled = true;
            }

            if (labelQuestionNumber.Text == "5")
            {
                pictureBoxRed.Visible = true;
                falseNumber++;
                labelFalse.Text = falseNumber.ToString();
                buttonNext.Enabled = true;
            }

            if (labelQuestionNumber.Text == "6")
            {
                pictureBoxRed.Visible = true;
                falseNumber++;
                labelFalse.Text = falseNumber.ToString();
                buttonNext.Enabled = true;
            }

            if (labelQuestionNumber.Text == "7")
            {
                pictureBoxRed.Visible = true;
                falseNumber++;
                labelFalse.Text = falseNumber.ToString();
                buttonNext.Enabled = true;
            }

            if (labelQuestionNumber.Text == "8")
            {
                pictureBoxRed.Visible = true;
                falseNumber++;
                labelFalse.Text = falseNumber.ToString();
                buttonNext.Enabled = true;
            }

            if (labelQuestionNumber.Text == "9")
            {
                pictureBoxRed.Visible = true;
                falseNumber++;
                labelFalse.Text = falseNumber.ToString();
                buttonNext.Enabled = true;
                
            }

            if (labelQuestionNumber.Text == "10")
            {
                pictureBoxRed.Visible = true;
                falseNumber++;
                labelFalse.Text = falseNumber.ToString();
                buttonNext.Enabled = true;
                buttonNext.Text = "Sınavı Bitir";
                
            }


        }
        
        private void Form1_Load(object sender, EventArgs e)
        {
            timer1.Interval = 1000;
            labelTimer.Text = "0";
            
            timer1.Start();
            FormEnd frm = new FormEnd();            

            buttonNext.Enabled = false;
            labelQuestionNumber.Text = "1";

            if (questionNumber == 1)
            {
                richTextBoxQuestion.Text = "1. Anlatım bozukluğu sorusuyla başlıyoruz. Hangi cümlede bir anlatım bozukluğu vardır?" +
                    "\n\nA - Teyit edilmemiş bir konu hakkında yorum yapmaması gerektiğini öğrenmiş oldu." +
                    "\n\nB - Konuları araştırmaması çok hata yapmasına yol açtı." +
                    "\n\nC - Hataları çoğaldıkça, insanların tepkileri yoğunlaştı." +
                    "\n\nD - Duyduklarına hemen inanıyor ve her yerde savunuyordu."; //**                   


            }

        }
        
        public int number = 0;
        private void buttonExit_Click(object sender, EventArgs e)
        {
                   
            Application.Exit();
          
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            number++;
            labelTimer.Text = number.ToString();
        }

        private void timer2_Tick(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {
            labelTimer.Text = timer1.ToString();
        }
    }
}
