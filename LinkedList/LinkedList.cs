using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;
using LinkedListVisualizer;

namespace LinkedList
{
    public partial class LinkedList : Form
    {
        int cntr = 0;
        int maxItems = 0;
        LinkedList<object> gLinkedList;

        public LinkedList()
        {
            string exeFile = Application.ExecutablePath;
            exeFile = exeFile.Substring(exeFile.LastIndexOf('\\') + 1);

            try
            {
                using (var key = Microsoft.Win32.Registry.LocalMachine.OpenSubKey(
        @"Software\WOW6432Node\Microsoft\Internet Explorer\Main\FeatureControl\FEATURE_BROWSER_EMULATION",
        true))
                {
                    key.SetValue(exeFile, 11001, Microsoft.Win32.RegistryValueKind.DWord);
                    key.Close();
                }
            }
            catch
            {
                //MessageBox.Show(@"Cannot access the registry.  Ensure Computer\HKEY_LOCAL_MACHINE\ SOFTWARE\WOW6432Node\Microsoft\ Internet Explorer\Main\ FeatureControl\FEATURE_BROWSER_EMULATION has a DWORD value for Name = " + exeFile + " with a value of 11001.  Otherwise the Web Browser features may not work.");
            }
            InitializeComponent();

            button1.Click += new EventHandler(Button1__Click);
            button2.Click += new EventHandler(Button2__Click);
            button3.Click += new EventHandler(Button3__Click);
            button4.Click += new EventHandler(Button4__Click);
            button5.Click += new EventHandler(Button5__Click);
        }

        /* Linked List Examples        
        
        1. Create a Linked List of strings
            LinkedList<string> sentence = new LinkedList<string>();

        2. Create a Linked List from an array of strings
            string[] words =
                { "the", "red", "car", "speeds", "away" };
            LinkedList<string> sentence = new LinkedList<string>(words);

        3. Add new strings to the end of the Linked List
            sentence.AddLast("word");

        4. Add the word 'today' to the beginning of the linked list.
            sentence.AddFirst("today");

        5. Move the first node to be the last node.
            LinkedListNode<string> firstNode = sentence.First;
            sentence.RemoveFirst();
            sentence.AddLast(firstNode);

        6. Change the last node to 'yesterday'
            sentence.RemoveLast();
            sentence.AddLast("yesterday");

        7. Move the last node to be the first node.
            LinkedListNode<string> lastNode = sentence.Last;
            sentence.RemoveLast();
            sentence.AddFirst(lastNode);

        8. Find the last occurence of 'the'.
            LinkedListNode<string> target = sentence.FindLast("the");
            if (target == null)
            {
                // "the" is not found
            }
            else
            {
                // Add 'bright' and 'red' after 'the' (the LinkedListNode named target).
                sentence.AddAfter(target, "bright");
                sentence.AddAfter(target, "red");
            }

        9. Find the 'car' node
            LinkedListNode<string> target = sentence.FindLast("car");

        10. Add 'sporty' and 'red' before 'car':
            sentence.AddBefore(target, "sporty");
            sentence.AddBefore(target, "red");

        11. Keep a reference to the 'car' node
        and to the previous node in the list
            carNode = sentence.Find("car");
            LinkedListNode<string> current = carNode.Previous;

        12. The AddBefore method throws an InvalidOperationException
        if you try to add a node that already belongs to a list.
            try
            {
                // try to add carNode before current
                sentence.AddBefore(current, carNode);
            }
            catch (InvalidOperationException ex)
            {
                Console.WriteLine("Exception message: {0}", ex.Message);
            }


        13. Remove the node referred to by carNode, and then add it
        before the node referred to by current.
            sentence.Remove(carNode);
            sentence.AddBefore(current, carNode);


        14. Add the 'current' node after the node referred to by mark2
            sentence.AddAfter(mark2, current);

        15. The Remove method finds and removes the
        first node that that has the specified value.
            sentence.Remove("red");

        16. Create an array with the same number of
        elements as the inked list.
            string[] sArray = new string[sentence.Count];
            sentence.CopyTo(sArray, 0);

        17. Walk through a Linked List in forward order
            LinkedListNode<object> linkedListNode = linkedList.First;

            while( linkedListNode != null )
            {
                linkedListNode = linkedListNode.Next;
            }

        18. Walk through a Linked List in reverse order
            LinkedListNode<object> linkedListNode = linkedList.Last;

            while( linkedListNode != null )
            {
                linkedListNode = linkedListNode.Previous;
            }

        19. Change the Value of a node
            linkedListNode.Value = "new value";

        20. Release all the nodes.
            sentence.Clear();

        */



        private void Button1__Click(object sender, EventArgs e)
        {
            // 1. create a LinkedList which contains the digits 1 through 10
            LinkedList<object> linkedList = new LinkedList<object>();


            // 2. then call the visualizer
            VisualizeLinkedList visualizeLinkedList = new VisualizeLinkedList(linkedList);
        }

        private void Button2__Click(object sender, EventArgs e)
        {
            // 1. create a LinkedList which contains the digits 1 through 10
            LinkedList<object> linkedList = new LinkedList<object>();


            // 2. copy the linkedList to reverseLinkedList in reverse order
            // so that reverseLinkedList goes from 10 to 1
            LinkedList<object> reverseLinkedList = new LinkedList<object>();
            LinkedListNode<object> linkedListNode;


            // then call the visualizer
            VisualizeLinkedList visualizeLinkedList = new VisualizeLinkedList(reverseLinkedList);
        }

        private void Button3__Click(object sender, EventArgs e)
        {
            // 1. create a LinkedList which contains the words
            // "the", "fox", "jumped", "over", "the", "dog"
            string[] s;
            LinkedList<object> linkedList = new LinkedList<object>(s);
            LinkedListNode<object> linkedListNode;


            // 2. add "quick" and "brown" before "fox"


            // 3. add "lazy" after the last "the"


            // 4. then call the visualizer
            VisualizeLinkedList visualizeLinkedList = new VisualizeLinkedList(linkedList);
        }

        private void Button4__Click(object sender, EventArgs e)
        {
            // create a LinkedList which contains the words:
            // Because I'm sad Clap along if you feel like a room without a roof
            // Because I'm sad Clap along if you feel like sadness is the truth sad
            string[] s;
            LinkedList<object> linkedList = new LinkedList<object>(s);
            LinkedListNode<object> linkedListNode;



            // replace "sad" with "happy"
            // and "sadness with "happiness"
            // note that because Value is an object 
            // you will have to cast Value as a string as follows:
            //     if( (string)linkedListNode.Value == "sad"

            // then call the visualizer
            VisualizeLinkedList visualizeLinkedList = new VisualizeLinkedList(linkedList);
        }

        private void Button5__Click(object sender, EventArgs e)
        {
            // create a LinkedList which contains the following words
            // The Spain in rain falls plain on the mainly
            string[] s;
            LinkedList<object> linkedList = new LinkedList<object>(s);
            LinkedListNode<object> linkedListNode1;
            LinkedListNode<object> linkedListNode2;

            // manipulate the list using Remove() and AddBefore() or AddAfter() to result in
            // "The rain in Spain falls mainly on the plain"

            // then call the visualizer
            VisualizeLinkedList visualizeLinkedList = new VisualizeLinkedList(linkedList);
        }
    }
}