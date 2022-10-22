using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace IdleGame
{
    public class Game
    {

        System.Threading.Thread t;
        int overallMoneyCount = 0;
        int clickMoneyCount = 1;
        int dolar = 0;
        int level = 1;
        int workerCount = 0;
        int workerCost = 10;

        public void IncreaseClickCount()
        {
            overallMoneyCount += clickMoneyCount;
            dolar += clickMoneyCount;
            CalculateLevel();
        }

        public string GetLevelText()
        {
            return "Level:" + level;
        }
        public string GetWrokerText()
        {
            return "Worker:" + workerCount;
        }

        public string GetClickCountText()
        {
            return "$:" + dolar.ToString();
        }

        private void CalculateLevel()
        {

        if(overallMoneyCount % 100 == 0)
        {
            level += 1;
            clickMoneyCount *= 2;
        }

        }

        public void BuyWorker()
        {
            int temp = 0;
            if (dolar >= workerCost)
            {
                workerCount++;
                temp = dolar - workerCost;
                if (temp >= 0)
                {
                    dolar = temp;
                    workerCost *= 2;
                    overallMoneyCount += dolar;
                }
                t = new System.Threading.Thread(new ThreadStart(DoJob));
                t.Start();
            }


        }
        public void DoJob()
        {
            while (true)
            {
                dolar += 1;
                overallMoneyCount += 1;
                CalculateLevel();
                System.Threading.Thread.Sleep(1000);

            }
        }

    }
}
