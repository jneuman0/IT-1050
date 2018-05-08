namespace IT_1050_Final_Exam
{
    class Elevator
    {
                
        private double MaxWeight;

        private Passenger[] Occupants; 
        

        public Elevator(int maxOccupants, double maxWeight)

        { 


            this.MaxWeight = maxWeight;

            this.Occupants = new Passenger[maxOccupants]; 

        }

        public void AddOccupant(Passenger passenger, int index)

        {

            this.Occupants[index] = passenger;

        }

        public double GetCurrentWeight()

        {

            double currentWeight = 0;



            for (int i = 0; i < Occupants.Length; i++)

            {

                currentWeight += this.Occupants[i].GetWeight();

            }

            return currentWeight;

        }



        public bool IsOverMaxCapacity()

        {

            return this.GetCurrentWeight() > this.MaxWeight;

        }

    } 



    
}


