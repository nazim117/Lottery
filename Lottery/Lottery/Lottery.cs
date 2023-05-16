using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lottery
{
    public class Lottery
    {
        private int maxValue;
        private int nrWantedNums;
        private List<int> lottery;
        private Random randNum;
        public Lottery(int maxValue, int nrWantedNums) 
        {
            this.maxValue = maxValue;
            this.nrWantedNums = nrWantedNums;
            lottery= new List<int>();
            randNum = new Random();
        }

        public int[] DrawAllNumbers()
        {
            while (lottery.Count < nrWantedNums)
            {
                 DrawNextNumber();
            }
            return lottery.ToArray();
        }
        public int DrawNextNumber()
        {
            int drawNum = 0;
            
            while(!lottery.Contains(drawNum))
            {
                drawNum = randNum.Next(1, maxValue);
                lottery.Add(drawNum);
            }
            
            return drawNum;
        }
        public bool IsLotteryFinished()
        {
            return lottery.Count == nrWantedNums;
        }
    }
}
