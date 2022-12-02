using System.Security.Cryptography.X509Certificates;

namespace IShape
{

    public partial class Form1 : Form
    {

        IShape[] array = new IShape[100];
        public static int count = 0;





        public Form1()
        {
            InitializeComponent();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Runner runner = new Runner();
            runner.Run();
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void checkBox5_CheckedChanged(object sender, EventArgs e)
        {


        }

        private void button3_Click(object sender, EventArgs e)
        {

            if (count < 100)
            {
                if (checkBox1.Checked)
                {
                    array[count] = new Rectangle(7, "red", 7, 8);
                    count++;
                }
                if (checkBox2.Checked)
                {
                    array[count] = new Circle(7, "red", 7);
                    count++;
                }
                if (checkBox3.Checked)
                {
                    array[count] = new ellipse(7, "red", 7, 5);
                    count++;
                }
                if (checkBox4.Checked)
                {
                    array[count] = new Triangle(7, "red", 7, 5);
                    count++;
                }
                if (checkBox5.Checked)
                {
                    array[count] = new Moon(7, "red", 7);
                    count++;
                }

            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            int sum = 0;
            for (int u = 0; u < count; u++)
            {
                sum += array[u].codcodim;
            }
            label1.Text = sum.ToString();
           
        }
    }
    }
    
    
    
