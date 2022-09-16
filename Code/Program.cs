using System;
class Program{
    public static string inputscore()
        {
            Console.WriteLine("1.for view information of the shop.");
            Console.WriteLine("2.for view shop co-founder information.");
            Console.WriteLine("3.for view employee information");
            Console.WriteLine("4.for view the store's income and expenses information.");
            Console.Write("Select the menu you want to view. : ");
            return Console.ReadLine();
        }
    public static void Main(string[] arge)
        {
            string scoretext = inputscore();
            int scoreDecimal = convertstringtoint(scoretext);
            string grade = convertscoretograde(scoreDecimal);
        }
            public static int convertstringtoint(string value)
        {
            if (int.TryParse(value, out int number))
            {
                return number;
            }
        throw new Exception("Please input menu you want to view.");
        }
        public static string convertscoretograde(int score)
        {
            if (score > 4) { throw new Exception("Please input menu you want to view 1 - 4"); }
            if (IsGradeA(score))
            {
                Users users=new Users();
                users.PrintUserInFormation();;
            }
            else if (IsGradeBPlus(score))
            {
                Staff staff=new Staff();
                staff.PrintStaffInFormation();
            }
            else if (IsGradeB(score))
            {
                Founder founder=new Founder();
                founder.PrintFounderInFormation();
            }
            else if (IsGradeCPlus(score))
            {
                Revenue revenue=new Revenue();
                revenue.PrintRevenueInFormation();
            }
            
            return "---";
    }
        public static bool IsGradeA(int score)
        {
            return score == 1;
        }
        public static bool IsGradeBPlus(int score)
        {
            return score == 2;
        }
        public static bool IsGradeB(int score)
        {
            return score == 3;
        }
        public static bool IsGradeCPlus(int score)
        {
            return score == 4;
        }
    
}