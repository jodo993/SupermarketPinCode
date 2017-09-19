using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SupermarketCodeFlashCards
{
    public partial class PINMode : Form
    {
        public PINMode()
        {
            InitializeComponent();
        }

        String finalPIN;
        String finalPINtoCheck;

        // Clear current answer
        private void clearButton_Click(object sender, EventArgs e)
        {
            finalPIN = "";
            pinLabel.Text = "";

            correctLabel.Visible = false;
            wrongLabel.Visible = false;
        }

        private void button0_Click(object sender, EventArgs e)
        {
            pinLabel.Text = getFinalPIN("0");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            pinLabel.Text = getFinalPIN("1");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            pinLabel.Text = getFinalPIN("2");
        }

        private void button3_Click(object sender, EventArgs e)
        {
            pinLabel.Text = getFinalPIN("3");
        }

        private void button4_Click(object sender, EventArgs e)
        {
            pinLabel.Text = getFinalPIN("4");
        }

        private void button5_Click(object sender, EventArgs e)
        {
            pinLabel.Text = getFinalPIN("5");
        }

        private void button6_Click(object sender, EventArgs e)
        {
            pinLabel.Text = getFinalPIN("6");
        }

        private void button7_Click(object sender, EventArgs e)
        {
            pinLabel.Text = getFinalPIN("7");
        }

        private void button8_Click(object sender, EventArgs e)
        {
            pinLabel.Text = getFinalPIN("8");
        }

        private void button9_Click(object sender, EventArgs e)
        {
            pinLabel.Text = getFinalPIN("9");
        }

        // Get final pin
        String getFinalPIN(String PIN)
        {
            String currentPIN = finalPIN;
            currentPIN = currentPIN + PIN;
            finalPIN = currentPIN;
            return currentPIN;
        }

        private void quitButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void getButton_Click(object sender, EventArgs e)
        {
            // Hide labels
            correctLabel.Visible = false;
            wrongLabel.Visible = false;

            // Clear previous entries
            finalPIN = "";
            finalPINtoCheck = "";

            // Get a random number to decide which category
            Random randomNumber = new Random();
            int deliVegiFruit = randomNumber.Next(1, 5);
            int itemNumber = getOption(deliVegiFruit);

            // Assign item number to string
            finalPINtoCheck = itemNumber.ToString();

            if (itemNumber == 90)
            {
                answerLabel.Text = "Trung Cut Vi";
                pictureBox.Image = Properties.Resources.quailEggs;
            }
            else if (itemNumber == 91)
            {
                answerLabel.Text = "Hot Vit Lon";
                pictureBox.Image = Properties.Resources.ballutEggs;
            }
            else if (itemNumber == 92)
            {
                answerLabel.Text = "Dau Hu Trang";
                pictureBox.Image = Properties.Resources.tofuCake;
            }
            else if (itemNumber == 93)
            {
                answerLabel.Text = "Trung Vit Tuoi";
                pictureBox.Image = Properties.Resources.duckEggs;
            }
            else if (itemNumber == 94)
            {
                answerLabel.Text = "Trung Vit Muoi";
                pictureBox.Image = Properties.Resources.duckEggs;
            }
            else if (itemNumber == 100)
            {
                answerLabel.Text = "Bong A Ti So";
                pictureBox.Image = Properties.Resources.artichoke;
            }
            else if (itemNumber == 101)
            {
                answerLabel.Text = "Bac Ha";
                pictureBox.Image = Properties.Resources.peppermintStem;
            }
            else if (itemNumber == 103)
            {
                answerLabel.Text = "Bap";
                pictureBox.Image = Properties.Resources.corn;
            }
            else if (itemNumber == 104)
            {
                answerLabel.Text = "Bap Cai";
                pictureBox.Image = Properties.Resources.greenCabbage;
            }
            else if (itemNumber == 105)
            {
                answerLabel.Text = "Bap Cai Do";
                pictureBox.Image = Properties.Resources.redCabbage;
            }
            else if (itemNumber == 106)
            {
                answerLabel.Text = "Bap Chuoi";
                pictureBox.Image = Properties.Resources.bananaFlower;
            }
            else if (itemNumber == 107)
            {
                answerLabel.Text = "Bau";
                pictureBox.Image = Properties.Resources.opo;
            }
            else if (itemNumber == 108)
            {
                answerLabel.Text = "Bi";
                pictureBox.Image = Properties.Resources.whiteGourd;
            }
            else if (itemNumber == 109)
            {
                answerLabel.Text = "Bi Dao";
                pictureBox.Image = Properties.Resources.moqua;
            }
            else if (itemNumber == 110)
            {
                answerLabel.Text = "Bi Ro";
                pictureBox.Image = Properties.Resources.kabocha;
            }
            else if (itemNumber == 113)
            {
                answerLabel.Text = "Bong Cai Trang";
                pictureBox.Image = Properties.Resources.cauliflower;
            }
            else if (itemNumber == 114)
            {
                answerLabel.Text = "Bong Cai Xanh";
                pictureBox.Image = Properties.Resources.broccoli;
            }
            else if (itemNumber == 115)
            {
                answerLabel.Text = "Ca Chua Roman";
                pictureBox.Image = Properties.Resources.romanTomato;
            }
            else if (itemNumber == 116)
            {
                answerLabel.Text = "Ca Chua";
                pictureBox.Image = Properties.Resources.tomato;
            }
            else if (itemNumber == 117)
            {
                answerLabel.Text = "Ca Chua Co Canh";
                pictureBox.Image = Properties.Resources.clusterTomato;
            }
            else if (itemNumber == 119)
            {
                answerLabel.Text = "Ca Phao Trang";
                pictureBox.Image = Properties.Resources.whiteThaiEggplant;
            }
            else if (itemNumber == 120)
            {
                answerLabel.Text = "Ca Tim";
                pictureBox.Image = Properties.Resources.chineseEggplant;
            }
            else if (itemNumber == 121)
            {
                answerLabel.Text = "Ca Tim My";
                pictureBox.Image = Properties.Resources.americanEggplant;
            }
            else if (itemNumber == 122)
            {
                answerLabel.Text = "Ca Tim Nhat";
                pictureBox.Image = Properties.Resources.japaneseEggplant;
            }
            else if (itemNumber == 123)
            {
                answerLabel.Text = "Cai Be Xanh Lon";
                pictureBox.Image = Properties.Resources.noImage;
            }
            else if (itemNumber == 124)
            {
                answerLabel.Text = "Cai Be Xanh Nho";
                pictureBox.Image = Properties.Resources.noImage;
            }
            else if (itemNumber == 125)
            {
                answerLabel.Text = "Cai Dai Loan";
                pictureBox.Image = Properties.Resources.bokChoy;
            }
            else if (itemNumber == 1251)
            {
                answerLabel.Text = "Cai Dai Loan Nho";
                pictureBox.Image = Properties.Resources.bokChoy;
            }
            else if (itemNumber == 126)
            {
                answerLabel.Text = "Cai Kim Chi";
                pictureBox.Image = Properties.Resources.napaCabbage;
            }
            else if (itemNumber == 127)
            {
                answerLabel.Text = "Cai Lan";
                pictureBox.Image = Properties.Resources.gaiLan;
            }
            else if (itemNumber == 128)
            {
                answerLabel.Text = "Cai Dua Muoi Lon";
                pictureBox.Image = Properties.Resources.smallTaiGaiChoy;
            }
            else if (itemNumber == 129)
            {
                answerLabel.Text = "Cai Ngot";
                pictureBox.Image = Properties.Resources.yauChoy;
            }
            else if (itemNumber == 130)
            {
                answerLabel.Text = "Bo Cong Anh";
                pictureBox.Image = Properties.Resources.dandelion;
            }
            else if (itemNumber == 131)
            {
                answerLabel.Text = "Cai Nhung";
                pictureBox.Image = Properties.Resources.kale;
            }
            else if (itemNumber == 132)
            {
                answerLabel.Text = "Cai Trang Lon";
                pictureBox.Image = Properties.Resources.longWhiteBokChoy;
            }
            else if (itemNumber == 133)
            {
                answerLabel.Text = "Cai Trang Nho";
                pictureBox.Image = Properties.Resources.longWhiteBokChoy;
            }
            else if (itemNumber == 134)
            {
                answerLabel.Text = "Cai Dua Muoi Nho";
                pictureBox.Image = Properties.Resources.smallTaiGaiChoy;
            }
            else if (itemNumber == 135)
            {
                answerLabel.Text = "Can My";
                pictureBox.Image = Properties.Resources.celery;
            }
            else if (itemNumber == 136)
            {
                answerLabel.Text = "Can Nuoc";
                pictureBox.Image = Properties.Resources.celery;
            }
            else if (itemNumber == 137)
            {
                answerLabel.Text = "Can Tau";
                pictureBox.Image = Properties.Resources.chineseCelery;
            }
            else if (itemNumber == 141)
            {
                answerLabel.Text = "Ca Rot Lon";
                pictureBox.Image = Properties.Resources.jumboCarrot;
            }
            else if (itemNumber == 142)
            {
                answerLabel.Text = "Cu Cai Trang";
                pictureBox.Image = Properties.Resources.daikon;
            }
            else if (itemNumber == 143)
            {
                answerLabel.Text = "Cu Au";
                pictureBox.Image = Properties.Resources.chestnut;
            }
            else if (itemNumber == 144)
            {
                answerLabel.Text = "Cu Den Do";
                pictureBox.Image = Properties.Resources.beet;
            }
            else if (itemNumber == 145)
            {
                answerLabel.Text = "Hat De";
                pictureBox.Image = Properties.Resources.chestnut;
            }
            else if (itemNumber == 147)
            {
                answerLabel.Text = "Cu Gung";
                pictureBox.Image = Properties.Resources.ginger;
            }
            else if (itemNumber == 149)
            {
                answerLabel.Text = "Cu Hanh Do";
                pictureBox.Image = Properties.Resources.redOnion;
            }
            else if (itemNumber == 150)
            {
                answerLabel.Text = "Cu Hanh Trang";
                pictureBox.Image = Properties.Resources.whiteOnion;
            }
            else if (itemNumber == 151)
            {
                answerLabel.Text = "Cu Hanh Vang";
                pictureBox.Image = Properties.Resources.yellowOnion;
            }
            else if (itemNumber == 152)
            {
                answerLabel.Text = "Cu Nang";
                pictureBox.Image = Properties.Resources.chestnut;
            }
            else if (itemNumber == 153)
            {
                answerLabel.Text = "Cu Nghe";
                pictureBox.Image = Properties.Resources.tumeric;
            }
            else if (itemNumber == 154)
            {
                answerLabel.Text = "La CuuKy";
                pictureBox.Image = Properties.Resources.noImage;
            }
            else if (itemNumber == 155)
            {
                answerLabel.Text = "Cu San";
                pictureBox.Image = Properties.Resources.noImage;
            }
            else if (itemNumber == 156)
            {
                answerLabel.Text = "Cu San Day";
                pictureBox.Image = Properties.Resources.noImage;
            }
            else if (itemNumber == 157)
            {
                answerLabel.Text = "Cu Sen";
                pictureBox.Image = Properties.Resources.lilyRoot;
            }
            else if (itemNumber == 158)
            {
                answerLabel.Text = "Cu Hanh Vang Bich 3lbs";
                pictureBox.Image = Properties.Resources.yellowOnion;
            }
            else if (itemNumber == 160)
            {
                answerLabel.Text = "Dau Bap";
                pictureBox.Image = Properties.Resources.okra;
            }
            else if (itemNumber == 162)
            {
                answerLabel.Text = "Dau Dua";
                pictureBox.Image = Properties.Resources.longBean;
            }
            else if (itemNumber == 163)
            {
                answerLabel.Text = "Dau Hoa Lan";
                pictureBox.Image = Properties.Resources.snowPea;
            }
            else if (itemNumber == 164)
            {
                answerLabel.Text = "Dau Que";
                pictureBox.Image = Properties.Resources.greenBean;
            }
            else if (itemNumber == 165)
            {
                answerLabel.Text = "Dau Ngot";
                pictureBox.Image = Properties.Resources.snapPea;
            }
            else if (itemNumber == 166)
            {
                answerLabel.Text = "Rau Lang";
                pictureBox.Image = Properties.Resources.yamLeaf;
            }
            else if (itemNumber == 167)
            {
                answerLabel.Text = "Du Du Bao";
                pictureBox.Image = Properties.Resources.slicedPapaya;
            }
            else if (itemNumber == 168)
            {
                answerLabel.Text = "Dua Chuot";
                pictureBox.Image = Properties.Resources.pickledCucumber;
            }
            else if (itemNumber == 169)
            {
                answerLabel.Text = "Dua Leo My";
                pictureBox.Image = Properties.Resources.americanCucumber;
            }
            else if (itemNumber == 4593)
            {
                answerLabel.Text = "Dua Leo Anh";
                pictureBox.Image = Properties.Resources.noImage;
            }
            else if (itemNumber == 171)
            {
                answerLabel.Text = "Dua Leo Nhat";
                pictureBox.Image = Properties.Resources.persianCucumber;
            }
            else if (itemNumber == 173)
            {
                answerLabel.Text = "Gia Bich Lon 10lbs";
                pictureBox.Image = Properties.Resources.beanSprout;
            }
            else if (itemNumber == 174)
            {
                answerLabel.Text = "Hanh Huong";
                pictureBox.Image = Properties.Resources.shallotOnion;
            }
            else if (itemNumber == 175)
            {
                answerLabel.Text = "La Chua";
                pictureBox.Image = Properties.Resources.sourLeaf;
            }
            else if (itemNumber == 176)
            {
                answerLabel.Text = "Hanh La";
                pictureBox.Image = Properties.Resources.greenOnion;
            }
            else if (itemNumber == 177)
            {
                answerLabel.Text = "He";
                pictureBox.Image = Properties.Resources.chives;
            }
            else if (itemNumber == 178)
            {
                answerLabel.Text = "He Bong";
                pictureBox.Image = Properties.Resources.chives;
            }
            else if (itemNumber == 179)
            {
                answerLabel.Text = "La Lo Hoi";
                pictureBox.Image = Properties.Resources.aloeVeraLeaf;
            }
            else if (itemNumber == 180)
            {
                answerLabel.Text = "Hung Cay";
                pictureBox.Image = Properties.Resources.peppermint;
            }
            else if (itemNumber == 181)
            {
                answerLabel.Text = "Hung Que";
                pictureBox.Image = Properties.Resources.thaiBasil;
            }
            else if (itemNumber == 182)
            {
                answerLabel.Text = "Hung Lui";
                pictureBox.Image = Properties.Resources.peppermint;
            }
            else if (itemNumber == 183)
            {
                answerLabel.Text = "Kho Qua";
                pictureBox.Image = Properties.Resources.bitterMelon;
            }
            else if (itemNumber == 184)
            {
                answerLabel.Text = "Khoai Lang Do";
                pictureBox.Image = Properties.Resources.redYam;
            }
            else if (itemNumber == 185)
            {
                answerLabel.Text = "Khoai Mi";
                pictureBox.Image = Properties.Resources.cassava;
            }
            else if (itemNumber == 186)
            {
                answerLabel.Text = "Khoai Mo";
                pictureBox.Image = Properties.Resources.purpleCassava;
            }
            else if (itemNumber == 187)
            {
                answerLabel.Text = "Khoai Mon Lon";
                pictureBox.Image = Properties.Resources.bigTaro;
            }
            else if (itemNumber == 188)
            {
                answerLabel.Text = "Khoai Mon Nho";
                pictureBox.Image = Properties.Resources.smallTaro;
            }
            else if (itemNumber == 189)
            {
                answerLabel.Text = "Khoai Tay Nau";
                pictureBox.Image = Properties.Resources.brownPotato;
            }
            else if (itemNumber == 190)
            {
                answerLabel.Text = "Khoai Tay Do";
                pictureBox.Image = Properties.Resources.redPotato;
            }
            else if (itemNumber == 191)
            {
                answerLabel.Text = "Khoai Tay Trang";
                pictureBox.Image = Properties.Resources.whitePotato;
            }
            else if (itemNumber == 192)
            {
                answerLabel.Text = "Khoai Mon Got Vo";
                pictureBox.Image = Properties.Resources.peeledTaro;
            }
            else if (itemNumber == 193)
            {
                answerLabel.Text = "Khoai Tay Nau Bich 10lbs";
                pictureBox.Image = Properties.Resources.brownPotato;
            }
            else if (itemNumber == 194)
            {
                answerLabel.Text = "La Dau Hoa Lan";
                pictureBox.Image = Properties.Resources.snowPeaLeaf;
            }
            else if (itemNumber == 195)
            {
                answerLabel.Text = "La Dua";
                pictureBox.Image = Properties.Resources.pandaLeaf;
            }
            else if (itemNumber == 196)
            {
                answerLabel.Text = "Khoai Tu";
                pictureBox.Image = Properties.Resources.nampeeYam;
            }
            else if (itemNumber == 197)
            {
                answerLabel.Text = "Mang Tay Tuoi";
                pictureBox.Image = Properties.Resources.asparagus;
            }
            else if (itemNumber == 198)
            {
                answerLabel.Text = "La Lot";
                pictureBox.Image = Properties.Resources.betelLeaf;
            }
            else if (itemNumber == 199)
            {
                answerLabel.Text = "Me Dop Hop";
                pictureBox.Image = Properties.Resources.tamarindBox;
            }
            else if (itemNumber == 202)
            {
                answerLabel.Text = "Dau Phong Song";
                pictureBox.Image = Properties.Resources.rawPeanut;
            }
            else if (itemNumber == 203)
            {
                answerLabel.Text = "Rau Mong Toi";
                pictureBox.Image = Properties.Resources.spinach;
            }
            else if (itemNumber == 204)
            {
                answerLabel.Text = "Muop Huong";
                pictureBox.Image = Properties.Resources.noImage;
            }
            else if (itemNumber == 205)
            {
                answerLabel.Text = "Muop Khia";
                pictureBox.Image = Properties.Resources.noImage;
            }
            else if (itemNumber == 206)
            {
                answerLabel.Text = "Muop Y";
                pictureBox.Image = Properties.Resources.italianSquash;
            }
            else if (itemNumber == 207)
            {
                answerLabel.Text = "Nam Hao";
                pictureBox.Image = Properties.Resources.oysterMushroom;
            }
            else if (itemNumber == 208)
            {
                answerLabel.Text = "Nam Dong";
                pictureBox.Image = Properties.Resources.shiitakeMushroom;
            }
            else if (itemNumber == 209)
            {
                answerLabel.Text = "Khoai Lang Duong Ngoc";
                pictureBox.Image = Properties.Resources.okinawaYam;
            }
            else if (itemNumber == 210)
            {
                answerLabel.Text = "Khoai Lang Nhat";
                pictureBox.Image = Properties.Resources.okinawaYam;
            }
            else if (itemNumber == 211)
            {
                answerLabel.Text = "Ngo";
                pictureBox.Image = Properties.Resources.cilantro;
            }
            else if (itemNumber == 212)
            {
                answerLabel.Text = "Ngo Gai";
                pictureBox.Image = Properties.Resources.noImage;
            }
            else if (itemNumber == 213)
            {
                answerLabel.Text = "Nam Tay";
                pictureBox.Image = Properties.Resources.mushroom;
            }
            else if (itemNumber == 214)
            {
                answerLabel.Text = "Ngo Om";
                pictureBox.Image = Properties.Resources.noImage;
            }
            else if (itemNumber == 215)
            {
                answerLabel.Text = "Ot Bell Vang";
                pictureBox.Image = Properties.Resources.yellowBellPepper;
            }
            else if (itemNumber == 216)
            {
                answerLabel.Text = "Ot Bell Xanh";
                pictureBox.Image = Properties.Resources.greenBellPepper;
            }
            else if (itemNumber == 217)
            {
                answerLabel.Text = "Ot Bell Do";
                pictureBox.Image = Properties.Resources.redBellPepper;
            }
            else if (itemNumber == 220)
            {
                answerLabel.Text = "Ot Hiem Do";
                pictureBox.Image = Properties.Resources.redThaiChili;
            }
            else if (itemNumber == 224)
            {
                answerLabel.Text = "Rau Den My";
                pictureBox.Image = Properties.Resources.spinach;
            }
            else if (itemNumber == 225)
            {
                answerLabel.Text = "Rau Dang";
                pictureBox.Image = Properties.Resources.noImage;
            }
            else if (itemNumber == 226)
            {
                answerLabel.Text = "Rau Dap Ca";
                pictureBox.Image = Properties.Resources.peppermint;
            }
            else if (itemNumber == 227)
            {
                answerLabel.Text = "Ray Day";
                pictureBox.Image = Properties.Resources.noImage;
            }
            else if (itemNumber == 228)
            {
                answerLabel.Text = "Rau Den Do";
                pictureBox.Image = Properties.Resources.noImage;
            }
            else if (itemNumber == 230)
            {
                answerLabel.Text = "Rau Kinh Gioi";
                pictureBox.Image = Properties.Resources.peppermint;
            }
            else if (itemNumber == 231)
            {
                answerLabel.Text = "Rau Ma";
                pictureBox.Image = Properties.Resources.pennyworthLeaf;
            }
            else if (itemNumber == 232)
            {
                answerLabel.Text = "Rau Muong";
                pictureBox.Image = Properties.Resources.on_choy;
            }
            else if (itemNumber == 234)
            {
                answerLabel.Text = "Rau Ram";
                pictureBox.Image = Properties.Resources.peppermint;
            }
            else if (itemNumber == 235)
            {
                answerLabel.Text = "Rau Tia To";
                pictureBox.Image = Properties.Resources.peppermint;
            }
            else if (itemNumber == 236)
            {
                answerLabel.Text = "Xa Lach Romaine";
                pictureBox.Image = Properties.Resources.romaineLettuce;
            }
            else if (itemNumber == 237)
            {
                answerLabel.Text = "Xa Lach Bap";
                pictureBox.Image = Properties.Resources.headLettuce;
            }
            else if (itemNumber == 238)
            {
                answerLabel.Text = "Xa Lach Da Lat";
                pictureBox.Image = Properties.Resources.bostonLettuce;
            }
            else if (itemNumber == 239)
            {
                answerLabel.Text = "Xa Lach Do";
                pictureBox.Image = Properties.Resources.redLettuce;
            }
            else if (itemNumber == 240)
            {
                answerLabel.Text = "Xa Lach Xanh";
                pictureBox.Image = Properties.Resources.greenLettuce;
            }
            else if (itemNumber == 242)
            {
                answerLabel.Text = "Xa Lach Xoong";
                pictureBox.Image = Properties.Resources.noImage;
            }
            else if (itemNumber == 243)
            {
                answerLabel.Text = "Mang Tre Tuoi";
                pictureBox.Image = Properties.Resources.bambooTip;
            }
            else if (itemNumber == 244)
            {
                answerLabel.Text = "Rau Tan O";
                pictureBox.Image = Properties.Resources.noImage;
            }
            else if (itemNumber == 245)
            {
                answerLabel.Text = "Thi La";
                pictureBox.Image = Properties.Resources.dill;
            }
            else if (itemNumber == 246)
            {
                answerLabel.Text = "Toi";
                pictureBox.Image = Properties.Resources.garlic;
            }
            else if (itemNumber == 247)
            {
                answerLabel.Text = "Toi La";
                pictureBox.Image = Properties.Resources.leek;
            }
            else if (itemNumber == 250)
            {
                answerLabel.Text = "Xa Cay";
                pictureBox.Image = Properties.Resources.lemonGrass;
            }
            else if (itemNumber == 252)
            {
                answerLabel.Text = "Su Hao";
                pictureBox.Image = Properties.Resources.kohlrabi;
            }
            else if (itemNumber == 253)
            {
                answerLabel.Text = "Su Su";
                pictureBox.Image = Properties.Resources.chayote;
            }
            else if (itemNumber == 256)
            {
                answerLabel.Text = "Cai Dua Chua An Lien";
                pictureBox.Image = Properties.Resources.noImage;
            }
            else if (itemNumber == 257)
            {
                answerLabel.Text = "Cu Kieu Chua An Lien";
                pictureBox.Image = Properties.Resources.noImage;
            }
            else if (itemNumber == 258)
            {
                answerLabel.Text = "Do Chua An Lien";
                pictureBox.Image = Properties.Resources.noImage;
            }
            else if (itemNumber == 901)
            {
                answerLabel.Text = "Buoi Oi";
                pictureBox.Image = Properties.Resources.dragonGrapefruit;
            }
            else if (itemNumber == 902)
            {
                answerLabel.Text = "Buoi Hong";
                pictureBox.Image = Properties.Resources.pinkGrapefruit;
            }
            else if (itemNumber == 903)
            {
                answerLabel.Text = "Buoi Trang";
                pictureBox.Image = Properties.Resources.noImage;
            }
            else if (itemNumber == 905)
            {
                answerLabel.Text = "Cam Cali";
                pictureBox.Image = Properties.Resources.orange;
            }
            else if (itemNumber == 906)
            {
                answerLabel.Text = "Cam Texas";
                pictureBox.Image = Properties.Resources.orange;
            }
            else if (itemNumber == 9061)
            {
                answerLabel.Text = "Cam Texas Thung";
                pictureBox.Image = Properties.Resources.orange;
            }
            else if (itemNumber == 907)
            {
                answerLabel.Text = "Chom Chom";
                pictureBox.Image = Properties.Resources.noImage;
            }
            else if (itemNumber == 913)
            {
                answerLabel.Text = "Chanh Vang";
                pictureBox.Image = Properties.Resources.lemon;
            }
            else if (itemNumber == 914)
            {
                answerLabel.Text = "Chanh Xanh";
                pictureBox.Image = Properties.Resources.lime;
            }
            else if (itemNumber == 915)
            {
                answerLabel.Text = "Trai So-ri";
                pictureBox.Image = Properties.Resources.cherry;
            }
            else if (itemNumber == 916)
            {
                answerLabel.Text = "Chuoi";
                pictureBox.Image = Properties.Resources.banana;
            }
            else if (itemNumber == 917)
            {
                answerLabel.Text = "Chuoi Su";
                pictureBox.Image = Properties.Resources.banana;
            }
            else if (itemNumber == 918)
            {
                answerLabel.Text = "Chuoi Cha Bot";
                pictureBox.Image = Properties.Resources.banana;
            }
            else if (itemNumber == 919)
            {
                answerLabel.Text = "Chuoi Cau VN";
                pictureBox.Image = Properties.Resources.banana;
            }
            else if (itemNumber == 920)
            {
                answerLabel.Text = "Chuoi Chat";
                pictureBox.Image = Properties.Resources.banana;
            }
            else if (itemNumber == 921)
            {
                answerLabel.Text = "Chuoi Xanh";
                pictureBox.Image = Properties.Resources.burroBanana;
            }
            else if (itemNumber == 923)
            {
                answerLabel.Text = "Trai Dao Long Trang";
                pictureBox.Image = Properties.Resources.whitePeach;
            }
            else if (itemNumber == 924)
            {
                answerLabel.Text = "Trai Dao Trang";
                pictureBox.Image = Properties.Resources.whiteNectarine;
            }
            else if (itemNumber == 925)
            {
                answerLabel.Text = "Trai Dao Vang";
                pictureBox.Image = Properties.Resources.yellowNectarine;
            }
            else if (itemNumber == 926)
            {
                answerLabel.Text = "Du Du Me";
                pictureBox.Image = Properties.Resources.mexicanPapaya;
            }
            else if (itemNumber == 927)
            {
                answerLabel.Text = "Du Du Xanh";
                pictureBox.Image = Properties.Resources.greenPapaya;
            }
            else if (itemNumber == 928)
            {
                answerLabel.Text = "Dua Ram";
                pictureBox.Image = Properties.Resources.thaiCoconut;
            }
            else if (itemNumber == 929)
            {
                answerLabel.Text = "Dua Kho";
                pictureBox.Image = Properties.Resources.driedCoconut;
            }
            else if (itemNumber == 930)
            {
                answerLabel.Text = "Dua Tuoi Trai";
                pictureBox.Image = Properties.Resources.thaiCoconut;
            }
            else if (itemNumber == 931)
            {
                answerLabel.Text = "Dua Tuoi Thung";
                pictureBox.Image = Properties.Resources.thaiCoconut;
            }
            else if (itemNumber == 932)
            {
                answerLabel.Text = "Du Du Hawaii";
                pictureBox.Image = Properties.Resources.hawaiianPapaya;
            }
            else if (itemNumber == 933)
            {
                answerLabel.Text = "Dua Gang My";
                pictureBox.Image = Properties.Resources.cantaloupe;
            }
            else if (itemNumber == 934)
            {
                answerLabel.Text = "Dua Gang Mat";
                pictureBox.Image = Properties.Resources.honeyDew;
            }
            else if (itemNumber == 935)
            {
                answerLabel.Text = "Dua Dai Han";
                pictureBox.Image = Properties.Resources.koreanMelon;
            }
            else if (itemNumber == 936)
            {
                answerLabel.Text = "Dua Hau Co Hot";
                pictureBox.Image = Properties.Resources.watermelon;
            }
            else if (itemNumber == 9361)
            {
                answerLabel.Text = "Dua Hau Nho";
                pictureBox.Image = Properties.Resources.bambinoWatermelon;
            }
            else if (itemNumber == 937)
            {
                answerLabel.Text = "Dua Hau Khong Hot";
                pictureBox.Image = Properties.Resources.watermelon;
            }
            else if (itemNumber == 938)
            {
                answerLabel.Text = "Dua Gang VN";
                pictureBox.Image = Properties.Resources.koreanMelon;
            }
            else if (itemNumber == 939)
            {
                answerLabel.Text = "Hong Don Lon";
                pictureBox.Image = Properties.Resources.persimon;
            }
            else if (itemNumber == 940)
            {
                answerLabel.Text = "Hong Don Tron";
                pictureBox.Image = Properties.Resources.persimon;
            }
            else if (itemNumber == 941)
            {
                answerLabel.Text = "Hong Mem";
                pictureBox.Image = Properties.Resources.persimon;
            }
            else if (itemNumber == 942)
            {
                answerLabel.Text = "Trai Cha La";
                pictureBox.Image = Properties.Resources.date;
            }
            else if (itemNumber == 943)
            {
                answerLabel.Text = "Khom Ngot";
                pictureBox.Image = Properties.Resources.pineapple;
            }
            else if (itemNumber == 944)
            {
                answerLabel.Text = "Trai Kiwi";
                pictureBox.Image = Properties.Resources.kiwi;
            }
            else if (itemNumber == 9441)
            {
                answerLabel.Text = "Trai Kiwi #1";
                pictureBox.Image = Properties.Resources.goldKiwi;
            }
            else if (itemNumber == 945)
            {
                answerLabel.Text = "Le Nau My";
                pictureBox.Image = Properties.Resources.boscPear;
            }
            else if (itemNumber == 946)
            {
                answerLabel.Text = "Trai Thanh Long";
                pictureBox.Image = Properties.Resources.dragonFruit;
            }
            else if (itemNumber == 947)
            {
                answerLabel.Text = "Le Dai Han";
                pictureBox.Image = Properties.Resources.koreanPear;
            }
            else if (itemNumber == 9471)
            {
                answerLabel.Text = "Le Dai Han Thung";
                pictureBox.Image = Properties.Resources.koreanPear;
            }
            else if (itemNumber == 948)
            {
                answerLabel.Text = "Le Nau Tau";
                pictureBox.Image = Properties.Resources.asianPear;
            }
            else if (itemNumber == 9481)
            {
                answerLabel.Text = "Le Tau Thung";
                pictureBox.Image = Properties.Resources.asianPear;
            }
            else if (itemNumber == 949)
            {
                answerLabel.Text = "Le Xanh My";
                pictureBox.Image = Properties.Resources.danjourPear;
            }
            else if (itemNumber == 950)
            {
                answerLabel.Text = "Man Den";
                pictureBox.Image = Properties.Resources.blackPlum;
            }
            else if (itemNumber == 951)
            {
                answerLabel.Text = "Man Xanh";
                pictureBox.Image = Properties.Resources.greenPlum;
            }
            else if (itemNumber == 952)
            {
                answerLabel.Text = "Man Ngot";
                pictureBox.Image = Properties.Resources.sugarPlum;
            }
            else if (itemNumber == 953)
            {
                answerLabel.Text = "Man Do";
                pictureBox.Image = Properties.Resources.redPlum;
            }
            else if (itemNumber == 954)
            {
                answerLabel.Text = "Trai Mang Cau";
                pictureBox.Image = Properties.Resources.cherimoya;
            }
            else if (itemNumber == 955)
            {
                answerLabel.Text = "Mit Tuoi Xe";
                pictureBox.Image = Properties.Resources.jackfruit;
            }
            else if (itemNumber == 956)
            {
                answerLabel.Text = "Mit Tuoi Nguyen Trai";
                pictureBox.Image = Properties.Resources.jackfruit;
            }
            else if (itemNumber == 957)
            {
                answerLabel.Text = "Trai Nhan Tuoi";
                pictureBox.Image = Properties.Resources.longan;
            }
            else if (itemNumber == 9571)
            {
                answerLabel.Text = "Trai Nhan Tuoi Thung";
                pictureBox.Image = Properties.Resources.longan;
            }
            else if (itemNumber == 958)
            {
                answerLabel.Text = "Le Yali";
                pictureBox.Image = Properties.Resources.yaliPear;
            }
            else if (itemNumber == 959)
            {
                answerLabel.Text = "Le Xanh Ballet";
                pictureBox.Image = Properties.Resources.yaliPear;
            }
            else if (itemNumber == 960)
            {
                answerLabel.Text = "Nho Do Co Hot";
                pictureBox.Image = Properties.Resources.redGlobe;
            }
            else if (itemNumber == 9601)
            {
                answerLabel.Text = "Nho Do Co Hot Thung";
                pictureBox.Image = Properties.Resources.redGlobe;
            }
            else if (itemNumber == 961)
            {
                answerLabel.Text = "Nho Do Khong Hot";
                pictureBox.Image = Properties.Resources.noImage;
            }
            else if (itemNumber == 9611)
            {
                answerLabel.Text = "Nho Do Khong Hot";
                pictureBox.Image = Properties.Resources.noImage;
            }
            else if (itemNumber == 963)
            {
                answerLabel.Text = "Nho Den";
                pictureBox.Image = Properties.Resources.blackGrape;
            }
            else if (itemNumber == 9631)
            {
                answerLabel.Text = "Nho Den Thung";
                pictureBox.Image = Properties.Resources.blackGrape;
            }
            else if (itemNumber == 964)
            {
                answerLabel.Text = "Nho Xanh";
                pictureBox.Image = Properties.Resources.thompsonGrape;
            }
            else if (itemNumber == 9641)
            {
                answerLabel.Text = "Nho Xanh Thung";
                pictureBox.Image = Properties.Resources.thompsonGrape;
            }
            else if (itemNumber == 966)
            {
                answerLabel.Text = "Trai Oi Tuoi";
                pictureBox.Image = Properties.Resources.guava;
            }
            else if (itemNumber == 967)
            {
                answerLabel.Text = "Quit Nho Bich 5lbs";
                pictureBox.Image = Properties.Resources.clementine;
            }
            else if (itemNumber == 969)
            {
                answerLabel.Text = "Quit Duong";
                pictureBox.Image = Properties.Resources.honeyTangerine;
            }
            else if (itemNumber == 9691)
            {
                answerLabel.Text = "Quit Me Tangelos";
                pictureBox.Image = Properties.Resources.tangelosTangerine;
            }
            else if (itemNumber == 9692)
            {
                answerLabel.Text = "Quit La";
                pictureBox.Image = Properties.Resources.tangelosTangerine;
            }
            else if (itemNumber == 971)
            {
                answerLabel.Text = "Tao Do";
                pictureBox.Image = Properties.Resources.apple;
            }
            else if (itemNumber == 973)
            {
                answerLabel.Text = "Tao Gala";
                pictureBox.Image = Properties.Resources.apple;
            }
            else if (itemNumber == 9731)
            {
                answerLabel.Text = "Tao Gala Bich";
                pictureBox.Image = Properties.Resources.apple;
            }
            else if (itemNumber == 975)
            {
                answerLabel.Text = "Tao Tau";
                pictureBox.Image = Properties.Resources.apple;
            }
            else if (itemNumber == 9751)
            {
                answerLabel.Text = "Tao Tau Dai";
                pictureBox.Image = Properties.Resources.apple;
            }
            else if (itemNumber == 976)
            {
                answerLabel.Text = "Tao Fuji";
                pictureBox.Image = Properties.Resources.apple;
            }
            else if (itemNumber == 9761)
            {
                answerLabel.Text = "Tao Fuji Thung";
                pictureBox.Image = Properties.Resources.apple;
            }
            else if (itemNumber == 977)
            {
                answerLabel.Text = "Tao Vang";
                pictureBox.Image = Properties.Resources.apple;
            }
            else if (itemNumber == 978)
            {
                answerLabel.Text = "Tao Xanh";
                pictureBox.Image = Properties.Resources.apple;
            }
            else if (itemNumber == 9781)
            {
                answerLabel.Text = "Tao Xanh Nho Bich";
                pictureBox.Image = Properties.Resources.noImage;
            }
            else if (itemNumber == 981)
            {
                answerLabel.Text = "Trai Bo Hass";
                pictureBox.Image = Properties.Resources.avocado;
            }
            else if (itemNumber == 9811)
            {
                answerLabel.Text = "Trai Bo Bich";
                pictureBox.Image = Properties.Resources.avocado;
            }
            else if (itemNumber == 983)
            {
                answerLabel.Text = "Trai Gac Dong Lanh";
                pictureBox.Image = Properties.Resources.noImage;
            }
            else if (itemNumber == 984)
            {
                answerLabel.Text = "Sau Rieng Dong Lanh";
                pictureBox.Image = Properties.Resources.durian;
            }
            else if (itemNumber == 985)
            {
                answerLabel.Text = "Trai Luu";
                pictureBox.Image = Properties.Resources.pomegranate;
            }
            else if (itemNumber == 986)
            {
                answerLabel.Text = "Trai Vai Tuoi";
                pictureBox.Image = Properties.Resources.lychee;
            }
            else if (itemNumber == 9861)
            {
                answerLabel.Text = "Trai Vai Tuoi Thung";
                pictureBox.Image = Properties.Resources.lychee;
            }
            else if (itemNumber == 987)
            {
                answerLabel.Text = "Xoai Coc Thom";
                pictureBox.Image = Properties.Resources.mango;
            }
            else if (itemNumber == 9871)
            {
                answerLabel.Text = "Xoai Coc Thung";
                pictureBox.Image = Properties.Resources.mango;
            }
            else if (itemNumber == 988)
            {
                answerLabel.Text = "Xoai Xanh Song";
                pictureBox.Image = Properties.Resources.mango;
            }
            else if (itemNumber == 9881)
            {
                answerLabel.Text = "Xoai Tuong";
                pictureBox.Image = Properties.Resources.mango;
            }
            else if (itemNumber == 989)
            {
                answerLabel.Text = "Xoai Thanh Ca Me Thung";
                pictureBox.Image = Properties.Resources.mango;
            }
            else if (itemNumber == 990)
            {
                answerLabel.Text = "Xoai Thanh Ca Thung";
                pictureBox.Image = Properties.Resources.mango;
            }
            else if (itemNumber == 991)
            {
                answerLabel.Text = "Xoai Kent Thung";
                pictureBox.Image = Properties.Resources.mango;
            }
            else if (itemNumber == 992)
            {
                answerLabel.Text = "XOai Champagne Thung";
                pictureBox.Image = Properties.Resources.mango;
            }
            else
            {
                MessageBox.Show("Click Again.");
                //recall();
            }

        }

        int getOption(int option)
        {
            // Generate random number from 1 - 3
            Random randomNumber = new Random();

            // Return deli and misc options
            if (option == 1)
            {
                int deliMisc = randomNumber.Next(90, 95);
                return deliMisc;
            }
            // Return vegetable options
            else if (option == 2)
            {
                int vegetable = randomNumber.Next(100, 259);
                return vegetable;
            }
            // Return fruit options
            else if (option == 3)
            {
                int fruit = randomNumber.Next(901, 993);
                return fruit;
            } 
            else
            {
                int fourDigits = randomNumber.Next(1, 21);
                if (fourDigits == 1)
                    return 4593;
                else if (fourDigits == 2)
                    return 9471;
                else if (fourDigits == 3)
                    return 9601;
                else if (fourDigits == 4)
                    return 9061;
                else if (fourDigits == 5)
                    return 9571;
                else if (fourDigits == 6)
                    return 9611;
                else if (fourDigits == 7)
                    return 9361;
                else if (fourDigits == 8)
                    return 9481;
                else if (fourDigits == 9)
                    return 9631;
                else if (fourDigits == 10)
                    return 9641;
                else if (fourDigits == 11)
                    return 9691;
                else if (fourDigits == 12)
                    return 9692;
                else if (fourDigits == 13)
                    return 9731;
                else if (fourDigits == 14)
                    return 9751;
                else if (fourDigits == 15)
                    return 9761;
                else if (fourDigits == 16)
                    return 9781;
                else if (fourDigits == 17)
                    return 9811;
                else if (fourDigits == 18)
                    return 9861;
                else if (fourDigits == 19)
                    return 9881;
                else
                    return 9871;
            }
        }

        private void enterButton_Click(object sender, EventArgs e)
        {
            //String matchPin = finalPIN;

            //matchPin = getFinalPIN("");
            if (finalPIN == finalPINtoCheck)
            {
                correctLabel.Visible = true;
               // recall();
            }
            else
                wrongLabel.Visible = true;

            finalLabel.Text = finalPIN;
            checkLabel.Text = finalPINtoCheck;
        }

        private void hintButton_Click(object sender, EventArgs e)
        {
            if (finalLabel.Visible == false && checkLabel.Visible == false)
            {
                finalLabel.Visible = true;
                checkLabel.Visible = true;
            }
            else
            {
                finalLabel.Visible = false;
                checkLabel.Visible = false;
            }

        }

        // Auto get new question
        //public void recall()
        //{
        //    getButton_Click(new object(), new EventArgs());
        //}
    }
}
