using System.Windows.Forms;
using static System.Net.Mime.MediaTypeNames;


namespace Oefening2;


    public partial class Form1 : Form 
    {
        Game<string> videoGame = new Game<string>();
        Game<double> videoGamePrice = new Game<double>();
    public Form1()
        {
            InitializeComponent();
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            String text = textVideo.Text;
            videoGame.toevoegen(text);
            textBox1.Text = videoGame.ToString();
            
        }

        private void removeVideo_Click(object sender, EventArgs e)
        {
            String text = textVideo.Text;
            videoGame.Verwijder();
            textBox1.Text = videoGame.ToString();
           }

        private void removeAllVideo_Click(object sender, EventArgs e)
        {
            videoGame.Leegmaken();
            textBox1.Text = videoGame.ToString();
        }

        private void checkItemVideo_Click(object sender, EventArgs e)
        {
            String text = textVideo.Text;
            videoGame.IsAanwezig(text);
            if(videoGame.IsAanwezig(text) == true)
            {
            textBox1.Text = text + " exist in list";
            }else if(videoGame.IsAanwezig(text) == false)
            {
            textBox1.Text = "Item does not exist";
            }            
    }

    private void button2_Click(object sender, EventArgs e)
    {
        double text = double.Parse(textPrice.Text);
        videoGamePrice.toevoegen(text);
        textBox2.Text = videoGamePrice.ToString();
    }

    private void removePrice_Click(object sender, EventArgs e)
    {
        double text = double.Parse(textPrice.Text);
        videoGamePrice.Verwijder();
        textBox2.Text = videoGamePrice.ToString();
    }

    private void clearPrice_Click(object sender, EventArgs e)
    {
        videoGamePrice.Leegmaken();
        textBox2.Text = videoGamePrice.ToString();
    }

    private void checkPrice_Click(object sender, EventArgs e)
    {
        double text = double.Parse(textPrice.Text);
        videoGamePrice.IsAanwezig(text);
        if (videoGamePrice.IsAanwezig(text) == true)
        {
            textBox2.Text = text + " price is in the list";
        }
        else if (videoGamePrice.IsAanwezig(text) == false)
        {
            textBox2.Text = "this price does not exist";
        }
    }
}


