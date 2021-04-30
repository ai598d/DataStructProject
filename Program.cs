using System;

namespace PathFinder_AVL
{
    class Program
    {
        static void Main(string[] args)
        {
            AVL_BST myTree = new AVL_BST();

            Console.WriteLine(myTree.IsEmpty());

            myTree.Initialize(0,"sensor1", 1, "sensor2", 1, "sensor3");
            myTree.UpdatedSensorAdd(0, "sensor4");

            myTree.PrintInOrder();
            //myTree.AVL_Insert(1,"MoveForward");
            //myTree.AVL_Insert(1);
            //myTree.AVL_Insert(1);
            //myTree.AVL_Insert(1);
            //myTree.AVL_Insert(1);
            //myTree.AVL_Insert(1);
            //myTree.AVL_Insert(0);
            //myTree.AVL_Insert(1);

            //myTree.Insert(3);
            //myTree.Insert(76);
            //myTree.Insert(23);
            //myTree.Insert(10);

            Console.WriteLine(myTree.IsEmpty());
        }
    }


    // create Node class. This is the building block. 

    class Node
    {

        // data 

        public int Value { get; set; }    // stores values

        //public T Slot { get; set; }    // finxed slot of each node

        public string Sensor { get; set; }  // sensor string 

        public Node left, right; // left and right reference

        //public int height;          // height of each node   


        //methods



        //ctor
        public Node(int newValue, string sensor)
        {
            Value = newValue;
            Sensor = sensor;
        }

    }

    class AVL_BST
    {

        // A single Tri-Nodal DataStructure

        public Node root { get; set; }
        
        public Node LeftChild { get; set; }

        public Node RightChild { get; set; }

        //public Node Carrier { get; set; }


        //methods


        // clear the tree
        public void Clear()
        {
            root = null;
        }


        // check if the tree is empty 
        public bool IsEmpty()
        {
            return root == null; 
        }


        // A recursive insert method for general purpose. 
        public void AVL_Insert(int newVal, string sensor)
        {
            
             AVL_Insert(root, newVal,sensor);

       

        }

        // AVL tree insertion. Method to insert into a subtree 

        public void AVL_Insert(Node t, int newVal, string sensor)
        {
            // t is the root node of the subtree
            // newVal is the value of the new node to be added

            if (t == null)  // if subtree is empty
            {
                t = new Node(newVal,sensor);
                root = t;                  // assign t as new root of the subtree 
            }
            else if(newVal.CompareTo(t.Value) <= 0) // if the value is less than t.value, add new node to the left recursivley
            {
                AVL_Insert(t.left, newVal,sensor);
            }
            else                                    // if the value is larger
            {
                AVL_Insert(t.right, newVal,sensor);
            }

        }


        public void AVL_hegiht()
        {
            int height = 0;


       
        }



        // Initializer

        public void Initialize(int SenvalRoot, string SenDirRoot, int SenvalLC , string SenDirLC, int SenvalRC, string SenDirRC)  // initialize with sensor in moving direction
        {

            // The purpose of this method is to initialize the data structure with initial sensor values.
            // This structure is designed as a single tri-nodal structure for a robot with 4 sensors.
            // Initially 3 sensor values are required.

            if (SenvalRoot != 0 || SenvalLC!=0 || SenvalRC !=1)
            {
                throw new Exception(" Must initialize root with sensor.value = 0 \n Must initialize LeftChild with sensor.value = 0 \n Must initialize RightChild with sensor.value = 1 ");
            }
            else
            {
                root = null; // clear the tree
                Node Initialroot = new Node(SenvalRoot, SenDirRoot);   // Root initializer node
                Node InitialLC = new Node(SenvalLC, SenDirLC);      // Leftchild  initializer node
                Node InitialRC = new Node(SenvalRC, SenDirRC);      // Rightchild initializer node

                root = Initialroot; // Initialize root node

                //Node leftchild  = InitialLC;    // initialize left child  node  
                //Node rightchild = InitialRC;    // initialize right child node 

                //root.left  = leftchild;         // connect root to the left child 
                //root.right = rightchild;        // connect root to the right child

                LeftChild = InitialLC;    // initialize left child  node  
                RightChild = InitialRC;    // initialize right child node 

                root.left = LeftChild;          // connect root to the left child 
                root.right = RightChild;        // connect root to the right child
            }

            


        }

        // Add New Node to the leftchild. 

        public void UpdatedSensorAdd(int senval, string sensor)
        {

            Node NewNode = new Node(senval, sensor);

            LeftChild.left = NewNode; 


        }

        // CWSingle  clock wise single rotation

        public void ClockSingleRot()
        {
            // delete current right child 
            // make current root the new right child
            // current leftchild becomes new root
            // child of leftchild becomes new leftchild


            RightChild = null;

            RightChild = root;

            root = LeftChild;

            LeftChild = LeftChild.left; 



            


        }

        // Delete


        // print in order

        public void PrintInOrder()
        {
            PrintInOrder(root);
        }

        public void PrintInOrder(Node N)
        {
            if (N == null)
            {
                Console.WriteLine("---------");
            }
            else
            {
                Console.WriteLine($"Reading from {N.Sensor} is {N.Value}");
                Console.WriteLine($"Reading from {N.left.Sensor} is {N.left.Value}");
                Console.WriteLine($"Reading from {N.right.Sensor} is {N.right.Value}");

            }
        }



        //ctor



    }

}
