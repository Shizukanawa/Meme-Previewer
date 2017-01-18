using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Media;

namespace WindowsFormsApplication2
{
    public partial class StringVariables : Form
    {
        private static readonly Random random = new Random();
        private SoundPlayer mp3Afspiller;
        public StringVariables()
        {
            InitializeComponent();
            mp3Afspiller = new SoundPlayer("rickroll.mp3");
        }
        //Knappen skaffer informationer fra txtBox2
        private void btnStrings_Click(object sender, EventArgs e)
        {
            Memes();
        }

        void Memes()
        {
            try {

                if (txtBox2.Text.ToLower() == "pepe")
                {
                    picBoxGIF.Load(url: "http://static3.techinsider.io/image/55ba6d1f371d22dd2e8ba492-1106-1012/screen%20shot%202015-07-30%20at%202.31.57%20pm.png");
                    txtBox3.Text = "http://static3.techinsider.io/image/55ba6d1f371d22dd2e8ba492-1106-1012/screen%20shot%202015-07-30%20at%202.31.57%20pm.png";
                    MessageBox.Show("FeelsBadMan", "Them Feels");
                }
                if (txtBox2.Text.ToLower() == "kappa")
                {
                    picBoxGIF.Load(url: "http://res.cloudinary.com/urbandictionary/image/upload/a_exif,c_fit,h_200,w_200/v1395991705/gjn81wvxqsq6yzcwubok.png");
                    txtBox3.Text = "http://res.cloudinary.com/urbandictionary/image/upload/a_exif,c_fit,h_200,w_200/v1395991705/gjn81wvxqsq6yzcwubok.png";
                }
                if (txtBox2.Text.ToLower() == "what song is this?")
                {
                    txtBox3.Text = "https://www.youtube.com/watch?v=y6120QOlsfU";
                    MessageBox.Show("DUDUDUDUDUDUDUDUDUDUDU");
                }
                if (txtBox2.Text.ToLower() == "darude sandstorm")
                { 
                    txtBox3.Text = "https://www.youtube.com/watch?v=y6120QOlsfU";
                    MessageBox.Show("What song is this?");
                }
                if (txtBox2.Text.ToLower() == "shitpost")
                { 
                    txtBox3.Text = "http://cdn.meme.am/instances/59595319.jpg";
                    picBoxGIF.Load(url: "http://cdn.meme.am/instances/59595319.jpg");
                    MessageBox.Show("Born too late to discover the earth. Born too early to explore the space, but born just in time to post dank memes");
                }
                if (txtBox2.Text.ToLower() == "rick astley" || txtBox2.Text.ToLower() == "rick roll")
                {
                    picBoxGIF.Load(url: "https://media.giphy.com/media/Vuw9m5wXviFIQ/giphy.gif");
                    txtBox3.Text = "https://www.youtube.com/watch?v=dQw4w9WgXcQ";
                    System.Diagnostics.Process.Start("https://www.youtube.com/watch?v=dQw4w9WgXcQ");
                }
                if (txtBox2.Text.ToLower() == "biblethump")
                {
                    txtBox3.Text = "https://pbs.twimg.com/profile_images/577309793104175104/y2jIo9dq.png";
                    picBoxGIF.Load(url: "https://pbs.twimg.com/profile_images/577309793104175104/y2jIo9dq.png");
                }
                if (txtBox2.Text.ToLower() == "woah, i almost gave a fuck" || txtBox2.Text.ToLower() == "woah")
                {
                    picBoxGIF.Load(url: "http://www.imemewhatiwant.com/wp-content/uploads/2014/11/IMG_5616.gif");
                    txtBox3.Text = "http://www.imemewhatiwant.com/wp-content/uploads/2014/11/IMG_5616.gif";
                }
                if (txtBox2.Text.ToLower() == "lennyface" || txtBox2.Text.ToLower() == "lenny face")
                {                    picBoxGIF.Load(url: "http://vignette1.wikia.nocookie.net/thelennyface/images/2/24/Lenny_face.png/revision/latest?cb=20140728000856");
                    txtBox3.Text = "http://vignette1.wikia.nocookie.net/thelennyface/images/2/24/Lenny_face.png/revision/latest?cb=20140728000856";
                }
                if (txtBox2.Text.ToLower() == "wtf no zoom?" || txtBox2.Text.ToLower() == "wtf no zoom")
                {
                    txtBox3.Text = "http://i.imgur.com/CRM4sA8.gif";
                    picBoxGIF.Load(url: "http://i.imgur.com/CRM4sA8.gif");
                }
                if (txtBox2.Text.ToLower() == "john cena" || txtBox2.Text.ToLower() == "can't see me" || txtBox2.Text.ToLower() == "cant see me")
                {
                    txtBox3.Text = "http://www.instantcena.com/";
                    int HEJBACH = random.Next(1, 5);
                    if (HEJBACH == 1)
                    {
                        picBoxGIF.Load(url: "http://static.dnaindia.com/sites/default/files/2015/10/02/361285-john-cena-2.jpg");
                    }
                    if (HEJBACH == 2)
                    {
                        picBoxGIF.Load(url: "https://pbs.twimg.com/profile_images/661041286942584832/a5SW7Qz5.jpg");
                    }
                    if (HEJBACH == 3)
                    {
                        picBoxGIF.Load(url: "https://i.ytimg.com/vi/TUQ3nVoN-ko/maxresdefault.jpg");
                    }
                    if (HEJBACH == 4)
                    {
                        picBoxGIF.Load(url: "http://vignette2.wikia.nocookie.net/supermarioglitchy4/images/3/3e/WWE-John-Cena-Wallpaper-American-Flag.jpg/revision/latest?cb=20150831131013");
                    }
                    if (HEJBACH == 5)
                    {
                        picBoxGIF.Load(url: "http://sd.keepcalm-o-matic.co.uk/i/you-can-t-see-me-because-im-john-cena.png");
                    }
                }
                if (txtBox2.Text.ToLower() == "john cena closer look" || txtBox2.Text.ToLower() == "closer look")
                {
                    picBoxGIF.Load(url: "https://media.giphy.com/media/SWaOidqw3aZhe/giphy.gif");
                    txtBox3.Text = "http://www.instantcena.com/closerlook.html";
                }
                if (txtBox2.Text.ToLower() == "triggered")
                {

                    txtBox3.Text = "https://media.giphy.com/media/Si7woAWqRUbgA/giphy.gif";
                    picBoxGIF.Load(url: "https://media.giphy.com/media/Si7woAWqRUbgA/giphy.gif");
                     
                }
                if (txtBox2.Text.ToLower() == "did that excite you?" || txtBox2.Text.ToLower() == "did that excite you? :3")
                {
                    txtBox3.Text = "https://www.youtube.com/watch?v=_DDsl-6guFs&feature=youtu.be";
                }
                if (txtBox2.Text.ToLower() == "trap card")
                {
                    txtBox3.Text = "https://i.ytimg.com/vi/H4fKfz5rcx8/maxresdefault.jpg";
                    picBoxGIF.Load(url: "https://i.ytimg.com/vi/H4fKfz5rcx8/maxresdefault.jpg");
                }
                if (txtBox2.Text.ToLower() == "shitposting time")
                {
                    txtBox3.Text = "https://giant.gfycat.com/ImpoliteSinfulBuzzard.gif";
                    picBoxGIF.Load(url: "https://giant.gfycat.com/ImpoliteSinfulBuzzard.gif");
                }
                if (txtBox2.Text.ToLower() == "delayedartisticguppy" || txtBox2.Text.ToLower() == "flusha cringe")
                {
                    txtBox3.Text = "https://giant.gfycat.com/DelayedArtisticGuppy.gif";
                    picBoxGIF.Load(url: "https://giant.gfycat.com/DelayedArtisticGuppy.gif");
                }
                if (txtBox2.Text.ToLower() == "tsundere shark")
                {
                    txtBox3.Text = "http://new2.fjcdn.com/gifs/I+m+coming+to+eat+you_e48485_5564955.gif";
                    picBoxGIF.Load(url: "http://new2.fjcdn.com/gifs/I+m+coming+to+eat+you_e48485_5564955.gif");
                }
                if (txtBox2.Text.ToLower() == "saiyan cena")
                {
                    txtBox3.Text = "https://www.youtube.com/watch?v=JghDBxmB3UI";
                    picBoxGIF.Load(url: "https://media.giphy.com/media/ghzZ5HnynY9X2/giphy.gif");
                }
                if (txtBox2.Text.ToLower() == "trollface" || txtBox2.Text.ToLower() == "troll face")
                {
                    txtBox3.Text = "http://www.reactionface.info/sites/default/files/images/1287666826226.png";
                    picBoxGIF.Load(url: "http://www.reactionface.info/sites/default/files/images/1287666826226.png");
                }
                if (txtBox2.Text.ToLower() == "doge gif")
                {
                    txtBox3.Text = "http://i2.kym-cdn.com/entries/icons/original/000/013/564/aP2dv.gif";
                    picBoxGIF.Load(url: "http://i2.kym-cdn.com/entries/icons/original/000/013/564/aP2dv.gif");
                }
                if (txtBox2.Text.ToLower() == "much wow" || txtBox2.Text.ToLower() == "doge")
                {
                    txtBox3.Text = "http://i2.kym-cdn.com/photos/images/original/000/581/722/7bc.jpg";
                    picBoxGIF.Load(url: "http://i2.kym-cdn.com/photos/images/original/000/581/722/7bc.jpg");
                }
                if (txtBox2.Text.ToLower() == "doge bread" || txtBox2.Text.ToLower() == "doge twinkie")
                {
                    txtBox3.Text = "http://i0.kym-cdn.com/photos/images/newsfeed/000/581/567/bab.jpg";
                    picBoxGIF.Load(url: "http://i0.kym-cdn.com/photos/images/newsfeed/000/581/567/bab.jpg");
                }
                if (txtBox2.Text.ToLower() == "badass")
                {
                    txtBox3.Text = "http://i0.kym-cdn.com/photos/images/newsfeed/000/200/420/BRTky.jpg?1321408042";
                    picBoxGIF.Load(url: "http://i0.kym-cdn.com/photos/images/newsfeed/000/200/420/BRTky.jpg?1321408042");
                }
                if (txtBox2.Text.ToLower() == "perfect 5/7" || txtBox2.Text == "5/7")
                {
                    txtBox3.Text = "http://i3.kym-cdn.com/photos/images/newsfeed/001/050/963/fe5.png";
                    picBoxGIF.Load(url: "http://i3.kym-cdn.com/photos/images/newsfeed/001/050/963/fe5.png");
                }
                if (txtBox2.Text.ToLower() == "brendan sullivan" || txtBox2.Text.ToLower() == "robert graves")
                {
                    txtBox3.Text = "http://imgur.com/gallery/eDF6K";
                    picBoxGIF.Load(url: "http://i.imgur.com/yjituYz.jpg");
                }
                if (txtBox2.Text == "grammar nazi")
                {
                    txtBox3.Text = "http://cdn.meme.am/instances/37130851.jpg";
                    picBoxGIF.Load(url: "http://cdn.meme.am/instances/37130851.jpg");
                }
                if (txtBox2.Text.ToLower() == "dramatic chipmunk")
                {
                    txtBox3.Text = "https://media.giphy.com/media/kKdgdeuO2M08M/giphy.gif";
                    picBoxGIF.Load(url: "https://media.giphy.com/media/kKdgdeuO2M08M/giphy.gif");
                }
                if (txtBox2.Text.ToLower() == "browsers")
                {
                    txtBox3.Text = "http://www.favbrowser.com/wp-content/uploads/2013/09/browsersfunny.jpg";
                    picBoxGIF.Load(url: "http://www.favbrowser.com/wp-content/uploads/2013/09/browsersfunny.jpg");
                }
                if (txtBox2.Text.ToLower() == "brain power" || txtBox2.Text.ToLower() == "brainpower" || txtBox2.Text.ToLower() == "o-oooooooooo aaaae-a-a-i-a-u- jo-oooooooooooo aae-o-a-a-u-u-a- e-eee-ee-eee aaaae-a-e-i-e-a- jo-ooo-oo-oo-oo eeeeo-a-aaa-aaaa")
                {
                    txtBox3.Text = "https://www.youtube.com/watch?v=9R8aSKwTEMg";
                    picBoxGIF.Load(url: "http://img.youtube.com/vi/9R8aSKwTEMg/1.jpg");
                    System.Diagnostics.Process.Start("https://www.youtube.com/watch?v=9R8aSKwTEMg ");
                }
                if (txtBox2.Text.ToLower() == "lock")
                {
                    txtBox2.Text = "";
                    System.Diagnostics.Process.Start(@"C:\WINDOWS\system32\rundll32.exe", "user32.dll,LockWorkStation");
                }
                if (txtBox2.Text.ToLower() == "salt dance" || txtBox2.Text.ToLower() == "salty dance")
                {
                    txtBox3.Text = "http://media.tumblr.com/28eaf1c1d4c724a13003f6ff205910eb/tumblr_inline_n8l0kk9uvI1r8wkkd.gif";
                    picBoxGIF.Load(url: "http://media.tumblr.com/28eaf1c1d4c724a13003f6ff205910eb/tumblr_inline_n8l0kk9uvI1r8wkkd.gif");
                }
                if (txtBox2.Text.ToLower() == "salty asf")
                {
                    txtBox3.Text = "https://lh5.googleusercontent.com/-4QNpQr2yAR4/VdO6UXf1CqI/AAAAAAAACv0/mNADHlnEnjg/Salt_Cyanide_Happiness_Shorts.gif";
                    picBoxGIF.Load(url: "https://lh5.googleusercontent.com/-4QNpQr2yAR4/VdO6UXf1CqI/AAAAAAAACv0/mNADHlnEnjg/Salt_Cyanide_Happiness_Shorts.gif");
                }
                if (txtBox2.Text.ToLower() == "mvp keen" || txtBox2.Text.ToLower() == "keen")
                {
                    txtBox3.Text = "http://i.imgur.com/KvhE3.gif";
                    picBoxGIF.Load(url: "http://i.imgur.com/KvhE3.gif");
                }
                if (txtBox2.Text.ToLower() == "mvp keen reversed" || txtBox2.Text.ToLower() == "keen reversed" || txtBox2.Text.ToLower() == "neek")
                {
                    txtBox3.Text = "http://i.imgur.com/O90PN.gif";
                    picBoxGIF.Load(url: "http://i.imgur.com/O90PN.gif");
                }
            }
            catch (System.Exception excep)
            {
                MessageBox.Show("Can't load" + excep.Message);
            }
        }

        void LoadingMaymes()
        {
            
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void picBoxGIF_Click(object sender, EventArgs e)
        {

        }

        private void lbl_1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {

        }

        private void toolStripComboBox1_Click(object sender, EventArgs e)
        {

        }

        private void txt_Meme_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.Return)
            {
                btnStrings_Click(sender, e);
            }
        }

        private void progressBar1_Click(object sender, EventArgs e)
        {

        }
    }
}
