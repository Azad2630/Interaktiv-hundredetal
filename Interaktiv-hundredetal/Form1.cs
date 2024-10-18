using System.Security.Cryptography.X509Certificates;

namespace Interaktiv_hundredetal
{
    public partial class Form1 : Form
    {
        // En offentlig variabel, der gemmer et tilfældigt genereret tal, som bruges i beregningerne.
        public int randomNumber;

        //Dette er konstruktøren for klassen Form1, der initialiserer GUI-komponenterne
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            // Opretter en ny instans af Random-klassen til at generere tilfældige tal
            Random random = new Random();

            // Genererer et tilfældigt tal mellem 1 og 100 (inklusive) og gemmer det i variablen randomNumber
            randomNumber = random.Next(1, 101);

            // Sætter tekstboksen textBoxTallet's tekst til det tilfældige tal som en streng
            textBoxTallet.Text = randomNumber.ToString();

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            // Forsøger at konvertere tekstboksen (textBox9) til en integer (value9) og tjekker om den er lig med randomNumber + 10
            if (int.TryParse(textBox9.Text, out int value9) && value9 == randomNumber + 10)
            {
                
                textBox9.BackColor = Color.Green;
            }
            else
            {
                textBox9.BackColor = Color.Red;
            }
            
            if (int.TryParse(textBox4.Text, out int value4) && value4 == randomNumber * 10)
            {
                textBox4.BackColor = Color.Green;
            }
            else
            {
                textBox4.BackColor = Color.Red;
            }

            if (int.TryParse(textBox5.Text, out int value5) && value5 == randomNumber + 20)
            {
                textBox5.BackColor = Color.Green;
            }
            else
            {
                textBox5.BackColor = Color.Red;
            }

            if (int.TryParse(textBox8.Text, out int value8) && value8 == randomNumber * 20)
            {
                textBox8.BackColor = Color.Green;
            }
            else
            {
                textBox8.BackColor = Color.Red;
            }

            if (int.TryParse(textBox7.Text, out int value7) && value7 == randomNumber / 10)
            {
                textBox7.BackColor = Color.Green;
            }
            else
            {
                textBox7.BackColor = Color.Red;
            }

            if (int.TryParse(textBox6.Text, out int value6) && value6 == randomNumber / 20)
            {
                textBox6.BackColor = Color.Green;
            }
            else
            {
                textBox6.BackColor = Color.Red;
            }

            if (int.TryParse(textBox1.Text, out int value1) && value1 == randomNumber - 10)
            {
                textBox1.BackColor = Color.Green;
            }
            else
            {
                textBox1.BackColor = Color.Red;
            }

            if (int.TryParse(textBox2.Text, out int value2) && value2 == randomNumber - 20)
            {
                textBox2.BackColor = Color.Green;
            }
            else
            {
                textBox2.BackColor = Color.Red;
            }
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {
        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox9_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void textBox7_TextChanged(object sender, EventArgs e)
        {
        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
        }

        private void textBox8_TextChanged(object sender, EventArgs e)
        {
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            // Opretter en liste af tekstbokse, som skal tømmes og nulstilles
            List<TextBox> textBoxes = new List<TextBox> { textBox1, textBox2, textBox4, textBox5, textBox6, textBox7, textBox8, textBox9 };

            // Rydder (fjerner) teksten i hver tekstboks ved at kalde Clear()-metoden
            textBox1.Clear();
            textBox2.Clear();
            textBox4.Clear();
            textBox5.Clear();
            textBox6.Clear();
            textBox7.Clear();
            textBox8.Clear();
            textBox9.Clear();

            // Gennemgår alle tekstbokse i listen
            foreach (var textBox in textBoxes)
            {
                // Hvis tekstboksen er tom (efter at Clear() er blevet kaldt), sættes baggrundsfarven til hvid
                if (string.IsNullOrEmpty(textBox.Text))
                {
                    textBox.BackColor = Color.White;
                }
                
            }
        }
    }
}
