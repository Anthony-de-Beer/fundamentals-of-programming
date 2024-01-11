using Services.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Services.Services
{
    public class ReverseService : IReverseService
    {
        public ReverseService()
        {
                
        }

        public string ReverseString(string sentance)
        {
            string[] sentanceArray = sentance.Split(' ');
            string reversedSentance = " ";

            for (int i = sentanceArray.Length - 1; i >= 0; i--)
            {
                reversedSentance += sentanceArray[i] + " ";
            }

            return reversedSentance;
        }
    }
}
