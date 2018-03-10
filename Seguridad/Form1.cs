using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net;
using System.Net.Sockets;
using System.IO;

namespace Seguridad
{
    public partial class Form1 : Form
    {
        private TcpClient client;
        public StreamReader STR;
        public StreamWriter STW;
        public string receive;
        public string text_to_send;

        public Form1()
        {
            // Get My IP
            IPAddress[] localIP = Dns.GetHostAddresses(Dns.GetHostName());
            foreach (IPAddress address in localIP)
            {
                if (address.AddressFamily == AddressFamily.InterNetwork)
                {
                    serverIPTextBox.Text = address.ToString();
                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            TcpListener listener = new TcpListener(IPAddress.Any, int.Parse(serverPortTextBox.Text));
            listener.Start();
            client = listener.AcceptTcpClient();
            STR = new StreamReader(client.GetStream());
            STW = new StreamWriter(client.GetStream());
            STW.AutoFlush = true;

            // Start Receiving Data
            backgroundWorker1.RunWorkerAsync();
            // Enable Cancelling this Thread
            backgroundWorker2.WorkerSupportsCancellation = true;
        }

        private void backgroundWorker1_DoWork(object sender, DoWorkEventArgs e)
        {
            while (client.Connected)
            {
                try
                {
                    receive = STR.ReadLine();
                    this.receiveTextBox.Invoke(new MethodInvoker(delegate () { receiveTextBox.AppendText("You: " + receive + "\n"); }));
                    receive = "";
                }
                catch (Exception x)
                {
                    MessageBox.Show(x.Message.ToString());
                }
            }
        }

        private void backgroundWorker2_DoWork(object sender, DoWorkEventArgs e)
        {
            if (client.Connected)
            {
                STW.WriteLine(text_to_send);
                this.receiveTextBox.Invoke(new MethodInvoker(delegate () { receiveTextBox.AppendText("Me :" + text_to_send + "\n"); }));
            }
            else
            {
                MessageBox.Show("Send failed!");
            }
            backgroundWorker2.CancelAsync();

        }

        private void button3_Click(object sender, EventArgs e)
        {
            client = new TcpClient();
            IPEndPoint IP_End = new IPEndPoint(IPAddress.Parse(connectIPTextBox.Text), int.Parse(connectPortTextBox.Text));

            try
            {
                client.Connect(IP_End);
                if (client.Connected)
                {
                    receiveTextBox.AppendText("Connected to Server\n");
                    STW = new StreamWriter(client.GetStream());
                    STR = new StreamReader(client.GetStream());
                    STW.AutoFlush = true;

                    // Start Receiving Data
                    backgroundWorker1.RunWorkerAsync();
                    // Enable Cancelling this Thread
                    backgroundWorker2.WorkerSupportsCancellation = true;
                }
            }
            catch (Exception x)
            {
                MessageBox.Show(x.Message.ToString());
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (sendTextBox.Text != "")
            {
                text_to_send = sendTextBox.Text;
                backgroundWorker2.RunWorkerAsync();
            }
            sendTextBox.Text = "";
        }
    }
}
