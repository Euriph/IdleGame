using System.Drawing;

namespace IdleGame
{
    public partial class FrmMain : Form
    {
        Game game = new Game();
        System.Threading.Thread mouneyCount;

        public FrmMain()
        {
            InitializeComponent();
        }

        private void picBuilding_Click(object sender, EventArgs e)
        {
            game.IncreaseClickCount();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            CheckForIllegalCrossThreadCalls = false;
            mouneyCount = new System.Threading.Thread(new ThreadStart(DoJob));
            mouneyCount.Start();

        }

        public void DoJob()
        {
            while (true)
            {
                RefreshScreen();
                System.Threading.Thread.Sleep(10);

            }
        }

        private void RefreshScreen()
        {

            lblLevel.Text = game.GetLevelText();
            lblWorker.Text = game.GetWrokerText();
            lblClickCount.Text = game.GetClickCountText();

        }

        private void btnAddWorker_Click(object sender, EventArgs e)
        {
            game.BuyWorker();
        }

        
    }
}