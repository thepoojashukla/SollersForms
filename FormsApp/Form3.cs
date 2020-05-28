using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FormsApp
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }
        private int CountCharacters()
        {
            int count = 0;
            using (StreamReader reader = new StreamReader("C:\\Personal docs\\Soller\\CSharp.txt"))
            {
                string content = reader.ReadToEnd();
                count = content.Length;
                Thread.Sleep(5000);
            }
            return count;
        }
        //private async void btnProcessFile_Click(object sender, EventArgs e)
        //{
        //    Task<int> task = new Task<int>(CountCharacters);
        //    task.Start();
        //    lblCount.Text = "Processing Please wait";
        //    //int count = CountCharacters(); //Now delegating this work to Task
        //    int count = await task;//Let the task first complete then get the count
        //    lblCount.Text = count.ToString() + "characters in File";
        //}

        private  void btnProcessFile_Click(object sender, EventArgs e)
        {
            int count = 0;
            Thread thread1 = new Thread(() => {
                count = CountCharacters();
                Action action = () => { lblCount.Text = count.ToString() + "characters in File"; };
                this.BeginInvoke(action);//This is gonna ask mainthread to Invoke the method Asyncgronously in Type safe manner
            });
            thread1.Start();
            lblCount.Text = "Processing Please wait";
            thread1.Join();     //This is going to block the UI    
            //lblCount.Text = count.ToString() + "characters in File";
        }
    }
}
