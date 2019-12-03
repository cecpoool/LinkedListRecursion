namespace Exercises
{
    public class ListNode
    {
        public string Data;
        public ListNode Next;

        public ListNode(string data, ListNode next = null) {
            this.Data = data;
            this.Next = next;
        }
    }

    public class LinkedList {
        public ListNode Head;

        public LinkedList() {
            Head = null;
        }

        public void AddToEnd(string newData) {
            ListNode newNode = new ListNode(newData, null);
            
            if (Head == null) {
                Head = newNode;
                return;
            } 

            
            ListNode current = Head;

            while (current.Next != null) {
                current = current.Next;
            }

                current.Next = newNode;
        }
        
        public ListNode GetNodeAt(int index) {
            int count = 0;

            if (index < 0) {
                return null;
            }
            
            ListNode current = Head;
            while (count < index) {
                if (current.Next != null) {
                    current = current.Next;
                } else {
                    return null;
                }
                count++;
            }

            return current;
        }

        public bool Find(string searchTerm) {
            ListNode current = Head;

            while (current != null) {
                if (current.Data == searchTerm) {
                    return true;
                }

                current = current.Next;
            }

            return false;
        }

        /// <summary>
        /// Returns the number of nodes in the Linked List
        /// </summary>
        /// <returns>int: count</returns>
        public int Count() {

             int getCountRec(ListNode node)
            {
                if (node == null)
                    return 0;

                return 1 + getCountRec(node.Next);
            }
            return getCountRec(Head);
        }

        /// <summary>
        /// Adds a node to the start of the list.
        /// </summary>
        /// <param name="data"></param>
        /// <returns>success: true</returns>
        public bool AddToStart(string data) {
            ListNode newNode = new ListNode(data, null);

            if (Head == null)
            {
                Head = newNode;
                return true;
            }
            else
            {
                newNode.Next = Head;
                Head = newNode;
                return true;
            }


        }

        /// <summary>
        /// add new node at index.  If index specified is greater than the size of the current list,
        /// adds nodes with null data in between.  Negative index will return false.
        /// </summary>
        /// <param name="data"></param>
        /// <param name="index"></param>
        /// <returns></returns>
        public bool AddNodeAt(string data, int index) {
            ListNode current = Head;


            if (index < 0)
            {
                return false;
            }
            else
            {
                for(int i = 1; i < index; i++)
                {

                    if (current.Next == null)
                    {
                        current.Next = new ListNode(null, null);
                    }


                    current = current.Next;


                }
                ListNode newNode = new ListNode(data, current.Next);

                current.Next = newNode;

                return true;
            }

      

        }

        /// <summary>
        /// Delete node at index.  return false if node does not exist
        /// </summary>
        /// <param name="index"></param>
        /// <returns></returns>
        public bool DeleteNodeAt(int index) {
            if (Head != null)
            {
                ListNode current = Head;
                for (int i = 1; i < index; i++)
                {
                    if (current.Next != null)
                    {
                        current = current.Next;
                    }
                }
                if (current.Next != null)
                {
                    current.Next = current.Next.Next;
                    return true;
                }

            }
            return false;
        }
    }
}