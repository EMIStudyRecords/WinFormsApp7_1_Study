namespace WinFormsApp7_1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }


       //�v�Z�{�^��������
        private void CalcButtonClicked(object sender, EventArgs e)
        {
            int price;
            bool success = int.TryParse(this.priceBox.Text, out price);

            if (success)
            {
                //����ł��v�Z����
                int taxPrice = (int)(price * 1.1);
                this.taxPriceBox.Text = taxPrice.ToString();
            }
        }
    }
}