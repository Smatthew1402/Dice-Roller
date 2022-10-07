using System.Security.Cryptography.Xml;

namespace Dice_Roller
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private ComboBox GetDieSelection()
        {
            return DieSelection;
        }

        private void Rollbutton_Click(object sender, EventArgs e)
        {
            Random rnd = new Random();
            int numdice = (int)Numberselection.Value;
            long numsides = 0;
            long result = (long)modifier.Value;
            string dieResults = "";
            switch (DieSelection.Text)
            {
                case "D4":
                    numsides = 4;
                    break;
                case "D6":
                    numsides = 6;
                    break;
                case "D8":
                    numsides = 8;
                    break;
                case "D10":
                    numsides = 10;
                    break;
                case "D12":
                    numsides = 12;
                    break;
                case "D20":
                    numsides = 20;
                    break;
                case "D100":
                    numsides = 100;
                    break;
            }
            for (int i = 0; i < numdice; i++)
            {
                long dieroll = rnd.NextInt64(numsides) + 1;
                result += dieroll;
                if (numdice < 2) {
                    dieResults += dieroll.ToString();
                }
                else if (i > 0)
                {
                    dieResults = dieResults + " + " + dieroll.ToString();
                }
                else
                {
                    dieResults += "" + dieroll.ToString();    
                }
            }
            Resultlabel.Text = result.ToString();
            DiceOut.Text = dieResults;
            
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}