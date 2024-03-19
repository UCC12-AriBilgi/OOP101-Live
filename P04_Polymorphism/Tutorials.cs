using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P04_Polymorphism
{
    internal class Tutorials
    {
        private int TutorialID;
        private string TutorialName;
        private string TutorialDescription;

        // 1.hal
        public void setTutorial(string pTutorialName) 
        { 
            TutorialName = pTutorialName;
        }

        // 2.Hal
        public void setTutorial(int pID,string pTutorialName)
        {
            TutorialID= pID;
            TutorialName= pTutorialName;
        }



        // 3.hal
        public void setTutorial(int pID,string pTutorialName,string pTutorialDescription)
        {
            TutorialID = pID;
            TutorialName= pTutorialName;
            TutorialDescription= pTutorialDescription;
        }


        public string getTutorialInfo() 
        {
            return TutorialID.ToString() + " - " + TutorialName + " - " + TutorialDescription;
        }

    }
}
