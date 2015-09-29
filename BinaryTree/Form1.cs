using System;
using System.Drawing.Imaging;
using System.Linq;
using System.Windows.Forms;

namespace BinaryTree
{
    public partial class Form1 : Form
    {
       
        public Form1()
        {
            InitializeComponent();
        }

        public BinaryTree _tree;
       
        private bool _acting = false;
        private bool _paintAgain = false;
        void PaintTree()
        {
            if (_tree == null) return;
            pictureBox1.Image = _tree.Draw();
        }

        private void btnCreate_Click(object sender, EventArgs e)
        {
            _tree = new BinaryTree();
            //lblEvents.Text = @"new binary tree";
            Node root = new Node(25);
            _tree.Add(root);

            _tree.Add(new Node(20));

            _tree.Add(new Node(30));

            _tree.Add(new Node(10));
            _tree.Add(new Node(23));

           

            _tree.Add(new Node(35));

            _tree.Add(new Node(5));
            _tree.Add(new Node(4));
            _tree.Add(new Node(6));
         



            _tree.Add(new Node(21));
            _tree.Add(new Node(19));
            _tree.Add(new Node(24));

          

            _tree.Add(new Node(32));
            _tree.Add(new Node(50));
            _tree.Add(new Node(33));
           

            PaintTree();
        }

  
        private void textBox1_KeyDown(object sender, KeyEventArgs e)
        {
        
            {
        
            }
        }

    
        private void btnRnd_Click(object sender, EventArgs e)
        {
               
            
            var val = int.Parse(textBox1.Text);
            var val2 = int.Parse(textBox2.Text);
     

            Node n1 = new Node(val);
            Node n2 = new Node(val2);
            

         
       

          BinaryTree i = new BinaryTree();




          Node root = i.RootNode;

         if (_tree.Exists(val) && _tree.Exists(val2))
         {    


              MessageBox.Show("The parent node is " + i.LCA(root, n1, n2).Value, "Please Hire Me!");
         }
         else
         {
                MessageBox.Show("Node values are invalid please try again","Error");
         }

        }

        private void Form1_Load(object sender, EventArgs e)
        {
           
        }

        public static ImageCodecInfo GetEncoderInfo(string mimeType)
        {
            // Get image codecs for all image formats
            var codecs = ImageCodecInfo.GetImageEncoders();
            // Find the correct image codec
            return codecs.FirstOrDefault(t => t.MimeType == mimeType);
        }


        }

        
    }

