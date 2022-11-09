namespace Assignment_9_Olga_Grisina
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
            label1.Text = "";
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string text = textBox1.Text.ToLower();
            Dictionary<char, int> chars = new();
            
            
            foreach (char c in text)
            {
                if (chars.ContainsKey(c)) chars[c]++;
                else chars[c] = 1;
            }

            foreach (var pair in chars)
            {
                char a = pair.Key;
                string b = pair.Value.ToString();
                label1.Text += a + "=" + b +'\n';
            }

            char charBest = ' ';
            int iBest=0;
            foreach (var pair in chars)
            {
                if (pair.Value > iBest)
                {
                    charBest = pair.Key;
                    iBest = pair.Value;
                }
            }
            label1.Text = "'" + charBest + "'" + " appears most frequently (" + iBest.ToString() + " times)";


        }
    }
}