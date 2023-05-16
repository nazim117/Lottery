namespace Lottery
{
    public partial class Form1 : Form
    {
        Lottery lotteryObj;

        public Form1()
        {
            InitializeComponent();
            btnDrawAllNum.Enabled = false;
            btnDrawNum.Enabled = false;
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void btnCreateObj_Click(object sender, EventArgs e)
        {
            lotteryObj = new Lottery(int.Parse(txtMaxValue.Text), int.Parse(txtWantedNums.Text));

            btnCreateObj.Enabled = false;
            btnDrawAllNum.Enabled = true;
            btnDrawNum.Enabled = true;
            lbObjects.Items.Clear();
        }

        private void btnDrawAllNum_Click(object sender, EventArgs e)
        {
            lbObjects.Items.Clear();
            int[] allNumbers = lotteryObj.DrawAllNumbers();
            for (int i = 0; i < allNumbers.Length; i++)
            {
                lbObjects.Items.Add(allNumbers[i]);
            }

            if (lotteryObj.IsLotteryFinished())
            {
                btnCreateObj.Enabled = true;
                btnDrawAllNum.Enabled = false;
                btnDrawNum.Enabled = false;
            }
        }

        private void btnDrawNum_Click(object sender, EventArgs e)
        {
            lbObjects.Items.Add(lotteryObj.DrawNextNumber());
            
            if (lotteryObj.IsLotteryFinished())
            {
                btnCreateObj.Enabled = true;
                btnDrawAllNum.Enabled = false;
                btnDrawNum.Enabled = false;
            }
        }
    }
}