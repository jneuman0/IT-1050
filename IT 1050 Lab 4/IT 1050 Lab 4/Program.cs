namespace IT_1050_Lab_4
{
    class Program
    {
        static void Main(string[] args)
        {


            System.Console.WriteLine("Is the movie playing during evening hours? (answer true/false)");

            bool isEveningShowing = bool.Parse(System.Console.ReadLine());



            System.Console.WriteLine("How many child tickets do you want? (12 or under is considered child)");

            int numberOfChildTickets = int.Parse(System.Console.ReadLine());



            System.Console.WriteLine("how many adult tickets do you want?");

            int numberOfAdultTickets = int.Parse(System.Console.ReadLine());



            System.Console.WriteLine("how many senior tickets do you want?");

            int numberOfSeniorTickets = int.Parse(System.Console.ReadLine());



            System.Console.WriteLine("Sodas come in two sizes: large and small");

            System.Console.WriteLine("How many small sodas do you want? ($3.50)");

            int numberOfSSodas = int.Parse(System.Console.ReadLine());

            System.Console.WriteLine("How many large sodas do you want? ($5.99)");

            int numberOfLSodas = int.Parse(System.Console.ReadLine());

            System.Console.WriteLine("How many hotdogs do you want? ($3.99)");

            int numberOfHotdogs = int.Parse(System.Console.ReadLine());

            System.Console.WriteLine("How many popcorns do you want? ($4.50)");

            int numberOfPopcorns = int.Parse(System.Console.ReadLine());

            System.Console.WriteLine("How many candies do you want? ($1.99)");

            int numberOfCandies = int.Parse(System.Console.ReadLine());



            double ticketTotal = 0;



            if (isEveningShowing == false)

            {

                ticketTotal += (numberOfChildTickets * 3.99 + numberOfAdultTickets * 5.99 + numberOfSeniorTickets * 4.50);

            }

            else if (isEveningShowing == true)

            {

                ticketTotal += (numberOfChildTickets * 6.99 + numberOfAdultTickets * 10.99 + numberOfSeniorTickets * 8.50);

            }

            else

            {

                System.Console.WriteLine("please try again");

            }



            double concessionsTotal = (numberOfSSodas * 3.50 + numberOfLSodas * 5.99 + numberOfHotdogs * 3.99 + numberOfPopcorns * 4.50 + numberOfCandies * 1.99);



            double totalPrice = (ticketTotal + concessionsTotal);



            /////////////////DISCOUNTS///////////////



            if ((numberOfPopcorns >= 1) && (numberOfLSodas >= 1) && ((numberOfChildTickets + numberOfAdultTickets + numberOfSeniorTickets) >= 1))

            {

                totalPrice -= 2.00;

            }



            if ((numberOfPopcorns >= 1) && ((numberOfChildTickets + numberOfAdultTickets + numberOfSeniorTickets) >= 3) && (isEveningShowing == true))

            {

                totalPrice -= 4.50;

            }



            int numberOfCandyDiscounts = numberOfCandies / 4;

            totalPrice -= (numberOfCandyDiscounts * 1.99);



            /////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////



            System.Console.WriteLine("The total price for the evening is $" + totalPrice);



            System.Console.ReadKey();













































        }
    }
}
