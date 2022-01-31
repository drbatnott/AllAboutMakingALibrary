using System;

namespace HealthLibrary
{
    public class HealthData
    {
        /*Fields will be put here
         * Fields are private to the class. In order to let other things use the class we end up making
         * public accessor methods (functions) and public parameters.
         * */
        private int idNumber;
        private float massKg;
        private int heightCm;
        private float bodyMassIndex;

        /// <summary>
        /// This is the simple constructor for a HealthData object
        /// We will want a new HealthData object for any person in our Health Data App
        /// Default values are to be set for the other fields (massKg, heightCm and bodyMassIndex)
        /// By setting them to -1 this will allow us to check whether they have been set before we allow them to be used
        /// </summary>
        /// <param name="id">The ID for the person</param>
        public HealthData(int id)
        {
            idNumber = id;
            bodyMassIndex = -1;
            massKg = -1;
            heightCm = -1;
        }

        public int IDNumber
        {
            get { return idNumber; }
        }
        /// <summary>
        /// In the code that uses this class we will have constructed an object of the HealthData type
        /// If the object was called healthData then we could use this MassKg parameter to get or set the value
        /// of the field massKg
        /// Using the get function:
        /// float mass = healthData.MassKg;
        /// using the set function:
        /// healthData.MassKg = 65;
        /// in this case the 65 would be the "value"
        /// </summary>
        public float MassKg
        {
            get { return massKg; }
            set
            {
                massKg = value;
                if (heightCm != -1)
                {
                    CalculateBMI();
                }
            }
        }
        public int HeightCm
        {
            get { return heightCm; }
            set
            {
                heightCm = value;
                if (massKg != -1)
                {
                    CalculateBMI();
                }
            }
        }
        public float BodyMassIndex
        {
            get { return bodyMassIndex; }
        }

        void CalculateBMI()
        {
            //in C# ..... divide is written /  addition of numbers as + subtraction as - 
            // also a += b; means add b to a and store the answer in a
            float heightM = heightCm / 100f;
            //In C#, Java, Python, JavaScript and PHP * stands for multiply
            bodyMassIndex = massKg / (heightM * heightM);
            //bodyMassIndex = massKg / (float)Math.Pow(heightM,2);
        }

    }
}
