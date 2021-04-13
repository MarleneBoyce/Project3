using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Forms;

//I don't think I did this project properly. I think I overly complicated it...it was a bit challening to me
namespace ToDoList
{
    //12 Apr 2021 MBOYCE NEW: Created Queue as per homework guidance 
    public partial class ToDoList : Form
    {
        //Creating new Queue called "toDoQueue"
        private Queue<Task> toDoQueue = new Queue<Task>();
 
        public ToDoList()
        {
            InitializeComponent();
        }


       
      //10 Apr 2021 MBOYCE NEW: This method will create a Task object and assign an ID number
      // and text (from the user) to the object then place the object in a queue. 
     //It will also add an item to the CheckListBox created from the user's text.
     
        private void btnAddItem_Click(object sender, EventArgs e)
        {
            Task task = new Task();

            task.ID = Task.Counter + 1;

            task.Text = txtItem.Text;

            cblbLToDoList.Items.Add(task.Text, CheckState.Unchecked);

            txtItem.Clear();

            toDoQueue.Enqueue(task);

            Task.Counter++;
        }
 
        //10 Apr 2021 MBOYCE NEW:  When the user checks an item, it removes the item from checkedbox list box
        //and from the queue 
       
        private void cblbLToDoList_SelectedValueChanged(object sender, EventArgs e)
        {
            var checkedItems = cblbLToDoList.CheckedItems;

            //Looping through checked list box to get the checked item
            foreach (var task in checkedItems)
            {
                string text = task.ToString();

                //if the first item in the queue is checked, then we dequeue the item 
                if (toDoQueue.Peek().Text == task.ToString())
                {
                    toDoQueue.Dequeue();
                }
                else 
                {
                    //Create list to hold toDoQueue items 
                    List<Task> temp = toDoQueue.ToList();

                    //Loop through the items to find checked item, and remove it from the queue 
                    foreach (Task t in temp) 
                    {
                        //once we find the selected text, remove it from the temp list, and clear the queue 
                        if (t.Text == task.ToString())
                        {
                            temp.Remove(t);

                            toDoQueue.Clear();

                            break;
                        }
                    }
                    //After removing checked item, put everything back into the queue 
                    foreach (Task t in temp)
                    {
                        toDoQueue.Enqueue(t);
                    }
                }
                // 12 Apr 2021 MBOYCE NEW 1L: Adding the text to the "Done" list 
                lbDone.Items.Add(text);
               
                cblbLToDoList.Items.Remove(text);

                // 10 Apr 2021 MBOYCE NEW: CheckedItems will always only contain one item
                // So we must break after each cycle.
                break;

            }
        }

        //10 Apr 2021 MBOYCE NEW: When the user clicks clear, the ClearData method will be called 
        private void btnClearLists_Click(object sender, EventArgs e)
        {
            ClearData();
        }

        //10 Apr 2021 MBOYCE NEW: When the user clicks "Save"
        //the entire "toDoQueue" is saved to the file 
        private void btnSaveLists_Click(object sender, EventArgs e)
        {
            IFormatter formatter = new BinaryFormatter();

            //10 Apr 2021 MBOYCE NEW: Create a "To-Do List" text file  
            Stream stream = new FileStream("To-Do List.txt", FileMode.Create, FileAccess.Write);

            formatter.Serialize(stream, toDoQueue);
            stream.Close();

            ClearData();

        }
        //12 Apr 2021 MBOYCE NEW: Loading lists 
        private void btnLoadLists_Click(object sender, EventArgs e)
        {
            ClearData();

            IFormatter formatter = new BinaryFormatter();

            //Opening file 
            Stream stream = new FileStream("To-Do List.txt", FileMode.Open, FileAccess.Read);

            //12 Apr 2021 MBOYCE NEW: Recreating the queue we saved to file and reassigning it to the "toDoQueue"
            toDoQueue = (Queue<Task>)formatter.Deserialize(stream);
            stream.Close();

            //Putting toDoQueue contents into a list 
            List<Task> temp = toDoQueue.ToList();

            //Creating the text strings for the list
            List<string> taskString = new List<string>();
                     
            //Looping through the Task list and getting its text
            foreach (Task t in temp)
            {
                taskString.Add(t.Text);
            }

            //Taking the text and inserting it into the check box list 
            cblbLToDoList.Items.AddRange(taskString.ToArray());

        }
        //12 Apr 2021 MBOYCE NEW 7L: ClearData() used to clear fields 
        private void ClearData()
        {
            txtItem.Clear();

            cblbLToDoList.Items.Clear();

            lbDone.Items.Clear();

            toDoQueue.Clear();

        }

    
    }
}
