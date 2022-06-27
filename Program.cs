using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/// <summary>
/// This dynamic array is implemented 
/// using the staic array method
/// Examples of Dynamic Array 
/// are List & Linked Lists
/// </summary>

namespace Dynamic_Array_Using_CSharp
{
    class DyanmmicArray
    {
        public int[] dynamic_array = new int[] { }; //Initial Uninitialized Array
        public int capacity; //Total Elements that the array can hold
        public int current; //Number of elements currently present in the array

        public DyanmmicArray()
        {
            //Using the default constructor the array is
            //initialized with an initial capacity of 1
            dynamic_array = new int[1];
            capacity = 1; 
            current = 0;
        }

        //This function adds a new element at the end of the array
        public void insert(int element)
        {
            //When the number of elements (current) becomes
            //equal to the capacity of the array. We make a new
            //temporary array of double capacity
            if(current == capacity)
            {
                int[] temp = new int[2 * capacity];

                //After creating the new array of double capacity
                //we copy all the elements of the array to the
                //the temp array
                for(int i = 0; i < capacity; i++)
                {
                    temp[i] = dynamic_array[i];
                }

                capacity *= 2; //The value of the capacity has been doubled as the well
                dynamic_array = temp; //Our temp array of double capacity becomes the dynamic array
            }

            //Finally we store the new value into the dynamic array and increment the current value
            dynamic_array[current] = element;
            current++;
        }

        //This function adds a new element at any index in the array
        public void insert(int element, int index)
        {
            //If the index value is at the capacity of the array
            //We call the insert function else we simply add 
            //the element at the given index
            if(index == capacity)
            {
                insert(element);
            }
            else
            {
                dynamic_array[index] = element;
            }
        }

        //This function deletes the last element in 
        //the array
        public void delete(int index)
        {
            current--;
        }

        //This function turns the element at a specific index
        public int get(int index)
        {
            if(index < current)
            {
                return dynamic_array[index];
            }

            return -1;
        }

        //This function imply displays all the elements in the array
        public void display()
        {
            for(int i = 0; i < current; i++)
            {
                Console.WriteLine(dynamic_array[i]);
            }
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
        }
    }
}
