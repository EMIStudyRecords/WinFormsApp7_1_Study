namespace WinFormsApp7_1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        //計算ボタン押下時
        private void CalcButtonClicked(object sender, EventArgs e)
        {
            int price;
            bool success = int.TryParse(this.priceBox.Text, out price);

            if (success)
            {
                //消費税を計算する
                int taxPrice = (int)(price * 1.1);
                this.taxPriceBox.Text = taxPrice.ToString();
            }
            else
            {
                MessageBox.Show("税抜価格を正しく入力してください");
            }
        }
    }
}