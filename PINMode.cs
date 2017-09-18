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

        String finalPIN = "";
        String finalPINtoCheck;

        private void clearButton_Click(object sender, EventArgs e)
        {
            finalPIN = "";
            pinLabel.Text = "";
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
            else
            {
                int fruit = randomNumber.Next(901, 993);
                return fruit;
            }
        }

        private void getButton_Click(object sender, EventArgs e)
        {
            correctLabel.Visible = false;
            wrongLabel.Visible = false;

            Random randomNumber = new Random();
            int deliVegiFruit = randomNumber.Next(1, 4);

            int itemNumber = getOption(deliVegiFruit);
            finalPINtoCheck = itemNumber.ToString();

            if (itemNumber == 90)
            {
                answerLabel.Text = "Trung Cut Vi";
            }
            else if (itemNumber == 91)
            {
                answerLabel.Text = "Hot Vit Lon";
            }
            else if (itemNumber == 92)
            {
                answerLabel.Text = "Dau Hu Trang";
            }
            else if (itemNumber == 93)
            {
                answerLabel.Text = "Trung Vit Tuoi";
            }
            else if (itemNumber == 94)
            {
                answerLabel.Text = "Trung Vit Muoi";
            }
            else if (itemNumber == 100)
            {
                answerLabel.Text = "Bong A Ti So";
            }
            else if (itemNumber == 101)
            {
                answerLabel.Text = "Bac Ha";
            }
            else if (itemNumber == 103)
            {
                answerLabel.Text = "Bap";
            }
            else if (itemNumber == 104)
            {
                answerLabel.Text = "Bap Cai";
            }
            else if (itemNumber == 105)
            {
                answerLabel.Text = "Bap Cai Do";
            }
            else if (itemNumber == 106)
            {
                answerLabel.Text = "Bap Chuoi";
            }
            else if (itemNumber == 107)
            {
                answerLabel.Text = "Bau";
            }
            else if (itemNumber == 108)
            {
                answerLabel.Text = "Bi";
            }
            else if (itemNumber == 109)
            {
                answerLabel.Text = "Bi Dao";
            }
            else if (itemNumber == 110)
            {
                answerLabel.Text = "Bi Ro";
            }
            else if (itemNumber == 113)
            {
                answerLabel.Text = "Bong Cai Trang";
            }
            else if (itemNumber == 114)
            {
                answerLabel.Text = "Bong Cai Xanh";
            }
            else if (itemNumber == 115)
            {
                answerLabel.Text = "Ca Chua Roman";
            }
            else if (itemNumber == 116)
            {
                answerLabel.Text = "Ca Chua";
            }
            else if (itemNumber == 117)
            {
                answerLabel.Text = "Ca Chua Co Canh";
            }
            else if (itemNumber == 119)
            {
                answerLabel.Text = "Ca Phao Trang";
            }
            else if (itemNumber == 120)
            {
                answerLabel.Text = "Ca Tim";
            }
            else if (itemNumber == 121)
            {
                answerLabel.Text = "Ca Tim My";
            }
            else if (itemNumber == 122)
            {
                answerLabel.Text = "Ca Tim Nhat";
            }
            else if (itemNumber == 123)
            {
                answerLabel.Text = "Cai Be Xanh Lon";
            }
            else if (itemNumber == 124)
            {
                answerLabel.Text = "Cai Be Xanh Nho";
            }
            else if (itemNumber == 125)
            {
                answerLabel.Text = "Cai Dai Loan";
            }
            else if (itemNumber == 1251)
            {
                answerLabel.Text = "Cai Dai Loan Nho";
            }
            else if (itemNumber == 126)
            {
                answerLabel.Text = "Cai Kim Chi";
            }
            else if (itemNumber == 127)
            {
                answerLabel.Text = "Cai Lan";
            }
            else if (itemNumber == 128)
            {
                answerLabel.Text = "Cai Dua Muoi Lon";
            }
            else if (itemNumber == 129)
            {
                answerLabel.Text = "Cai Ngot";
            }
            else if (itemNumber == 130)
            {
                answerLabel.Text = "Bo Cong Anh";
            }
            else if (itemNumber == 131)
            {
                answerLabel.Text = "Cai Nhung";
            }
            else if (itemNumber == 132)
            {
                answerLabel.Text = "Cai Trang Lon";
            }
            else if (itemNumber == 133)
            {
                answerLabel.Text = "Cai Trang Nho";
            }
            else if (itemNumber == 134)
            {
                answerLabel.Text = "Cai Dua Muoi Nho";
            }
            else if (itemNumber == 135)
            {
                answerLabel.Text = "Can My";
            }
            else if (itemNumber == 136)
            {
                answerLabel.Text = "Can Nuoc";
            }
            else if (itemNumber == 137)
            {
                answerLabel.Text = "Can Tau";
            }
            else if (itemNumber == 141)
            {
                answerLabel.Text = "Ca Rot Lon";
            }
            else if (itemNumber == 142)
            {
                answerLabel.Text = "Cu Cai Trang";
            }
            else if (itemNumber == 143)
            {
                answerLabel.Text = "Cu Au";
            }
            else if (itemNumber == 144)
            {
                answerLabel.Text = "Cu Den Do";
            }
            else if (itemNumber == 145)
            {
                answerLabel.Text = "Hat De";
            }
            else if (itemNumber == 147)
            {
                answerLabel.Text = "Cu Gung";
            }
            else if (itemNumber == 149)
            {
                answerLabel.Text = "Cu Hanh Do";
            }
            else if (itemNumber == 150)
            {
                answerLabel.Text = "Cu Hanh Trang";
            }
            else if (itemNumber == 151)
            {
                answerLabel.Text = "Cu Hanh Vang";
            }
            else if (itemNumber == 152)
            {
                answerLabel.Text = "Cu Nang";
            }
            else if (itemNumber == 153)
            {
                answerLabel.Text = "Cu Nghe";
            }
            else if (itemNumber == 154)
            {
                answerLabel.Text = "La CuuKy";
            }
            else if (itemNumber == 155)
            {
                answerLabel.Text = "Cu San";
            }
            else if (itemNumber == 156)
            {
                answerLabel.Text = "Cu San Day";
            }
            else if (itemNumber == 157)
            {
                answerLabel.Text = "Cu Sen";
            }
            else if (itemNumber == 158)
            {
                answerLabel.Text = "Cu Hanh Vang Bich 3lbs";
            }
            else if (itemNumber == 160)
            {
                answerLabel.Text = "Dau Bap";
            }
            else if (itemNumber == 162)
            {
                answerLabel.Text = "Dau Dua";
            }
            else if (itemNumber == 163)
            {
                answerLabel.Text = "Dau Hoa Lan";
            }
            else if (itemNumber == 164)
            {
                answerLabel.Text = "Dau Que";
            }
            else if (itemNumber == 165)
            {
                answerLabel.Text = "Dau Ngot";
            }
            else if (itemNumber == 166)
            {
                answerLabel.Text = "Rau Lang";
            }
            else if (itemNumber == 167)
            {
                answerLabel.Text = "Du Du Bao";
            }
            else if (itemNumber == 168)
            {
                answerLabel.Text = "Dua Chuot";
            }
            else if (itemNumber == 169)
            {
                answerLabel.Text = "Dua Leo My";
            }
            else if (itemNumber == 4593)
            {
                answerLabel.Text = "Dua Leo Anh";
            }
            else if (itemNumber == 171)
            {
                answerLabel.Text = "Dua Leo Nhat";
            }
            else if (itemNumber == 173)
            {
                answerLabel.Text = "Gia Bich Lon 10lbs";
            }
            else if (itemNumber == 174)
            {
                answerLabel.Text = "Hanh Huong";
            }
            else if (itemNumber == 175)
            {
                answerLabel.Text = "La Chua";
            }
            else if (itemNumber == 176)
            {
                answerLabel.Text = "Hanh La";
            }
            else if (itemNumber == 177)
            {
                answerLabel.Text = "He";
            }
            else if (itemNumber == 178)
            {
                answerLabel.Text = "He Bong";
            }
            else if (itemNumber == 179)
            {
                answerLabel.Text = "La Lo Hoi";
            }
            else if (itemNumber == 180)
            {
                answerLabel.Text = "Hung Cay";
            }
            else if (itemNumber == 181)
            {
                answerLabel.Text = "Hung Que";
            }
            else if (itemNumber == 182)
            {
                answerLabel.Text = "Hung Lui";
            }
            else if (itemNumber == 183)
            {
                answerLabel.Text = "Kho Qua";
            }
            else if (itemNumber == 184)
            {
                answerLabel.Text = "Khoai Lang Do";
            }
            else if (itemNumber == 185)
            {
                answerLabel.Text = "Khoai Mi";
            }
            else if (itemNumber == 186)
            {
                answerLabel.Text = "Khoai Mo";
            }
            else if (itemNumber == 187)
            {
                answerLabel.Text = "Khoai Mon Lon";
            }
            else if (itemNumber == 188)
            {
                answerLabel.Text = "Khoai Mon Nho";
            }
            else if (itemNumber == 189)
            {
                answerLabel.Text = "Khoai Tay Nau";
            }
            else if (itemNumber == 190)
            {
                answerLabel.Text = "Khoai Tay Do";
            }
            else if (itemNumber == 191)
            {
                answerLabel.Text = "Khoai Tay Trang";
            }
            else if (itemNumber == 192)
            {
                answerLabel.Text = "Khoai Mon Got Vo";
            }
            else if (itemNumber == 193)
            {
                answerLabel.Text = "Khoai Tay Nau Bich 10lbs";
            }
            else if (itemNumber == 194)
            {
                answerLabel.Text = "La Dau Hoa Lan";
            }
            else if (itemNumber == 195)
            {
                answerLabel.Text = "La Dua";
            }
            else if (itemNumber == 196)
            {
                answerLabel.Text = "Khoai Tu";
            }
            else if (itemNumber == 197)
            {
                answerLabel.Text = "Mang Tay Tuoi";
            }
            else if (itemNumber == 198)
            {
                answerLabel.Text = "La Lot";
            }
            else if (itemNumber == 199)
            {
                answerLabel.Text = "Me Dop Hop";
            }
            else if (itemNumber == 202)
            {
                answerLabel.Text = "Dau Phong Song";
            }
            else if (itemNumber == 203)
            {
                answerLabel.Text = "Rau Mong Toi";
            }
            else if (itemNumber == 204)
            {
                answerLabel.Text = "Muop Huong";
            }
            else if (itemNumber == 205)
            {
                answerLabel.Text = "Muop Khia";
            }
            else if (itemNumber == 206)
            {
                answerLabel.Text = "Muop Y";
            }
            else if (itemNumber == 207)
            {
                answerLabel.Text = "Nam Hao";
            }
            else if (itemNumber == 208)
            {
                answerLabel.Text = "Nam Dong";
            }
            else if (itemNumber == 209)
            {
                answerLabel.Text = "Khoai Lang Duong Ngoc";
            }
            else if (itemNumber == 210)
            {
                answerLabel.Text = "Khoai Lang Nhat";
            }
            else if (itemNumber == 211)
            {
                answerLabel.Text = "Ngo";
            }
            else if (itemNumber == 212)
            {
                answerLabel.Text = "Ngo Gai";
            }
            else if (itemNumber == 213)
            {
                answerLabel.Text = "Nam Tay";
            }
            else if (itemNumber == 214)
            {
                answerLabel.Text = "Ngo Om";
            }
            else if (itemNumber == 215)
            {
                answerLabel.Text = "Ot Bell Vang";
            }
            else if (itemNumber == 216)
            {
                answerLabel.Text = "Ot Bell Xanh";
            }
            else if (itemNumber == 217)
            {
                answerLabel.Text = "Ot Bell Do";
            }
            else if (itemNumber == 220)
            {
                answerLabel.Text = "Ot Hiem Do";
            }
            else if (itemNumber == 224)
            {
                answerLabel.Text = "Rau Den My";
            }
            else if (itemNumber == 225)
            {
                answerLabel.Text = "Rau Dang";
            }
            else if (itemNumber == 226)
            {
                answerLabel.Text = "Rau Dap Ca";
            }
            else if (itemNumber == 227)
            {
                answerLabel.Text = "Ray Day";
            }
            else if (itemNumber == 228)
            {
                answerLabel.Text = "Rau Den Do";
            }
            else if (itemNumber == 230)
            {
                answerLabel.Text = "Rau Kinh Gioi";
            }
            else if (itemNumber == 231)
            {
                answerLabel.Text = "Rau Ma";
            }
            else if (itemNumber == 232)
            {
                answerLabel.Text = "Rau Muong";
            }
            else if (itemNumber == 234)
            {
                answerLabel.Text = "Rau Ram";
            }
            else if (itemNumber == 235)
            {
                answerLabel.Text = "Rau Tia To";
            }
            else if (itemNumber == 236)
            {
                answerLabel.Text = "Xa Lach Romaine";
            }
            else if (itemNumber == 237)
            {
                answerLabel.Text = "Xa Lach Bap";
            }
            else if (itemNumber == 238)
            {
                answerLabel.Text = "Xa Lach Da Lat";
            }
            else if (itemNumber == 239)
            {
                answerLabel.Text = "Xa Lach Do";
            }
            else if (itemNumber == 240)
            {
                answerLabel.Text = "Xa Lach Xanh";
            }
            else if (itemNumber == 242)
            {
                answerLabel.Text = "Xa Lach Xoong";
            }
            else if (itemNumber == 243)
            {
                answerLabel.Text = "Mang Tre Tuoi";
            }
            else if (itemNumber == 244)
            {
                answerLabel.Text = "Rau Tan O";
            }
            else if (itemNumber == 245)
            {
                answerLabel.Text = "Thi La";
            }
            else if (itemNumber == 246)
            {
                answerLabel.Text = "Toi";
            }
            else if (itemNumber == 247)
            {
                answerLabel.Text = "Toi La";
            }
            else if (itemNumber == 250)
            {
                answerLabel.Text = "Xa Cay";
            }
            else if (itemNumber == 252)
            {
                answerLabel.Text = "Su Hao";
            }
            else if (itemNumber == 253)
            {
                answerLabel.Text = "Su Su";
            }
            else if (itemNumber == 256)
            {
                answerLabel.Text = "Cai Dua Chua An Lien";
            }
            else if (itemNumber == 257)
            {
                answerLabel.Text = "Cu Kieu Chua An Lien";
            }
            else if (itemNumber == 258)
            {
                answerLabel.Text = "Do Chua An Lien";
            }
            else if (itemNumber == 901)
            {
                answerLabel.Text = "Buoi Oi";
            }
            else if (itemNumber == 902)
            {
                answerLabel.Text = "Buoi Hong";
            }
            else if (itemNumber == 903)
            {
                answerLabel.Text = "Buoi Trang";
            }
            else if (itemNumber == 905)
            {
                answerLabel.Text = "Cam Cali";
            }
            else if (itemNumber == 906)
            {
                answerLabel.Text = "Cam Texas";
            }
            else if (itemNumber == 9061)
            {
                answerLabel.Text = "Cam Texas Thung";
            }
            else if (itemNumber == 907)
            {
                answerLabel.Text = "Chom Chom";
            }
            else if (itemNumber == 913)
            {
                answerLabel.Text = "Chanh Vang";
            }
            else if (itemNumber == 914)
            {
                answerLabel.Text = "Chanh Xanh";
            }
            else if (itemNumber == 915)
            {
                answerLabel.Text = "Trai So-ri";
            }
            else if (itemNumber == 916)
            {
                answerLabel.Text = "Chuoi";
            }
            else if (itemNumber == 917)
            {
                answerLabel.Text = "Chuoi Su";
            }
            else if (itemNumber == 918)
            {
                answerLabel.Text = "Chuoi Cha Bot";
            }
            else if (itemNumber == 919)
            {
                answerLabel.Text = "Chuoi Cau VN";
            }
            else if (itemNumber == 920)
            {
                answerLabel.Text = "Chuoi Chat";
            }
            else if (itemNumber == 921)
            {
                answerLabel.Text = "Chuoi Xanh";
            }
            else if (itemNumber == 923)
            {
                answerLabel.Text = "Trai Dao Long Trang";
            }
            else if (itemNumber == 924)
            {
                answerLabel.Text = "Trai Dao Trang";
            }
            else if (itemNumber == 925)
            {
                answerLabel.Text = "Trai Dao Vang";
            }
            else if (itemNumber == 926)
            {
                answerLabel.Text = "Du Du Me";
            }
            else if (itemNumber == 927)
            {
                answerLabel.Text = "Du Du Xanh";
            }
            else if (itemNumber == 928)
            {
                answerLabel.Text = "Dua Ram";
            }
            else if (itemNumber == 929)
            {
                answerLabel.Text = "Dua Kho";
            }
            else if (itemNumber == 930)
            {
                answerLabel.Text = "Dua Tuoi Trai";
            }
            else if (itemNumber == 931)
            {
                answerLabel.Text = "Dua Tuoi Thung";
            }
            else if (itemNumber == 932)
            {
                answerLabel.Text = "Du Du Hawaii";
            }
            else if (itemNumber == 933)
            {
                answerLabel.Text = "Dua Gang My";
            }
            else if (itemNumber == 934)
            {
                answerLabel.Text = "Dua Gang Mat";
            }
            else if (itemNumber == 935)
            {
                answerLabel.Text = "Dua Dai Han";
            }
            else if (itemNumber == 936)
            {
                answerLabel.Text = "Dua Hau Co Hot";
            }
            else if (itemNumber == 9361)
            {
                answerLabel.Text = "Dua Hau Nho";
            }
            else if (itemNumber == 937)
            {
                answerLabel.Text = "Dua Hau Khong Hot";
            }
            else if (itemNumber == 938)
            {
                answerLabel.Text = "Dua Gang VN";
            }
            else if (itemNumber == 939)
            {
                answerLabel.Text = "Hong Don Lon";
            }
            else if (itemNumber == 940)
            {
                answerLabel.Text = "Hong Don Tron";
            }
            else if (itemNumber == 941)
            {
                answerLabel.Text = "Hong Mem";
            }
            else if (itemNumber == 942)
            {
                answerLabel.Text = "Trai Cha La";
            }
            else if (itemNumber == 943)
            {
                answerLabel.Text = "Khom Ngot";
            }
            else if (itemNumber == 944)
            {
                answerLabel.Text = "Trai Kiwi";
            }
            else if (itemNumber == 9441)
            {
                answerLabel.Text = "Trai Kiwi #1";
            }
            else if (itemNumber == 945)
            {
                answerLabel.Text = "Le Nau My";
            }
            else if (itemNumber == 946)
            {
                answerLabel.Text = "Trai Thanh Long";
            }
            else if (itemNumber == 947)
            {
                answerLabel.Text = "Le Dai Han";
            }
            else if (itemNumber == 9471)
            {
                answerLabel.Text = "Le Dai Han Thung";
            }
            else if (itemNumber == 948)
            {
                answerLabel.Text = "Le Nau Tau";
            }
            else if (itemNumber == 9481)
            {
                answerLabel.Text = "Le Tau Thung";
            }
            else if (itemNumber == 949)
            {
                answerLabel.Text = "Le Xanh My";
            }
            else if (itemNumber == 950)
            {
                answerLabel.Text = "Man Den";
            }
            else if (itemNumber == 951)
            {
                answerLabel.Text = "Man Xanh";
            }
            else if (itemNumber == 952)
            {
                answerLabel.Text = "Man Ngot";
            }
            else if (itemNumber == 953)
            {
                answerLabel.Text = "Man Do";
            }
            else if (itemNumber == 954)
            {
                answerLabel.Text = "Trai Mang Cau";
            }
            else if (itemNumber == 955)
            {
                answerLabel.Text = "Mit Tuoi Xe";
            }
            else if (itemNumber == 956)
            {
                answerLabel.Text = "Mit Tuoi Nguyen Trai";
            }
            else if (itemNumber == 957)
            {
                answerLabel.Text = "Trai Nhan Tuoi";
            }
            else if (itemNumber == 9571)
            {
                answerLabel.Text = "Trai Nhan Tuoi Thung";
            }
            else if (itemNumber == 958)
            {
                answerLabel.Text = "Le Yali";
            }
            else if (itemNumber == 959)
            {
                answerLabel.Text = "Le Xanh Ballet";
            }
            else if (itemNumber == 960)
            {
                answerLabel.Text = "Nho Do Co Hot";
            }
            else if (itemNumber == 9601)
            {
                answerLabel.Text = "Nho Do Co Hot Thung";
            }
            else if (itemNumber == 961)
            {
                answerLabel.Text = "Nho Do Khong Hot";
            }
            else if (itemNumber == 9611)
            {
                answerLabel.Text = "Nho Do Khong Hot";
            }
            else if (itemNumber == 963)
            {
                answerLabel.Text = "Nho Den";
            }
            else if (itemNumber == 9631)
            {
                answerLabel.Text = "Nho Den Thung";
            }
            else if (itemNumber == 964)
            {
                answerLabel.Text = "Nho Xanh";
            }
            else if (itemNumber == 9641)
            {
                answerLabel.Text = "Nho Xanh Thung";
            }
            else if (itemNumber == 966)
            {
                answerLabel.Text = "Trai Oi Tuoi";
            }
            else if (itemNumber == 967)
            {
                answerLabel.Text = "Quit Nho Bich 5lbs";
            }
            else if (itemNumber == 969)
            {
                answerLabel.Text = "Quit Duong";
            }
            else if (itemNumber == 9691)
            {
                answerLabel.Text = "Quit Me Tangelos";
            }
            else if (itemNumber == 9692)
            {
                answerLabel.Text = "Quit La";
            }
            else if (itemNumber == 971)
            {
                answerLabel.Text = "Tao Do";
            }
            else if (itemNumber == 973)
            {
                answerLabel.Text = "Tao Gala";
            }
            else if (itemNumber == 9731)
            {
                answerLabel.Text = "Tao Gala Bich";
            }
            else if (itemNumber == 975)
            {
                answerLabel.Text = "Tao Tau";
            }
            else if (itemNumber == 9751)
            {
                answerLabel.Text = "Tao Tau Dai";
            }
            else if (itemNumber == 976)
            {
                answerLabel.Text = "Tao Fuji";
            }
            else if (itemNumber == 9761)
            {
                answerLabel.Text = "Tao Fuji Thung";
            }
            else if (itemNumber == 977)
            {
                answerLabel.Text = "Tao Vang";
            }
            else if (itemNumber == 978)
            {
                answerLabel.Text = "Tao Xanh";
            }
            else if (itemNumber == 9781)
            {
                answerLabel.Text = "Tao Xanh Nho Bich";
            }
            else if (itemNumber == 981)
            {
                answerLabel.Text = "Trai Bo Hass";
            }
            else if (itemNumber == 9811)
            {
                answerLabel.Text = "Trai Bo Bich";
            }
            else if (itemNumber == 983)
            {
                answerLabel.Text = "Trai Gac Dong Lanh";
            }
            else if (itemNumber == 984)
            {
                answerLabel.Text = "Sau Rieng Dong Lanh";
            }
            else if (itemNumber == 985)
            {
                answerLabel.Text = "Trai Luu";
            }
            else if (itemNumber == 986)
            {
                answerLabel.Text = "Trai Vai Tuoi";
            }
            else if (itemNumber == 9861)
            {
                answerLabel.Text = "Trai Vai Tuoi Thung";
            }
            else if (itemNumber == 987)
            {
                answerLabel.Text = "Xoai Coc Thom";
            }
            else if (itemNumber == 9871)
            {
                answerLabel.Text = "Xoai Coc Thung";
            }
            else if (itemNumber == 988)
            {
                answerLabel.Text = "Xoai Xanh Song";
            }
            else if (itemNumber == 9881)
            {
                answerLabel.Text = "Xoai Tuong";
            }
            else if (itemNumber == 989)
            {
                answerLabel.Text = "Xoai Thanh Ca Me Thung";
            }
            else if (itemNumber == 990)
            {
                answerLabel.Text = "Xoai Thanh Ca Thung";
            }
            else if (itemNumber == 991)
            {
                answerLabel.Text = "Xoai Kent Thung";
            }
            else if (itemNumber == 992)
            {
                answerLabel.Text = "XOai Champagne Thung";
            }
            else
            {
                MessageBox.Show("Click Again.");
            }

        }

        private void enterButton_Click(object sender, EventArgs e)
        {
            //String matchPin = finalPIN;

            //matchPin = getFinalPIN("");
            if (finalPIN == finalPINtoCheck)
                correctLabel.Visible = true;
            else
                wrongLabel.Visible = true;
        }
    }
}
