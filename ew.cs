namespace Employeewage
{
    public static class Employeecheck
    {
      public static void checkattendence()
        {
            int IS_FULL_TIME = 1;
            int EMP_RATE_PER_HOR = 20;

            int emphrs = 0;
            int empwage = 0;

            Random random = new Random();
            int empcheck = random.Next(2);
            if  (empcheck==IS_FULL_TIME)
            {
                Console.WriteLine("Employee is present");
                emphrs = 8;

            }


        }
    }

