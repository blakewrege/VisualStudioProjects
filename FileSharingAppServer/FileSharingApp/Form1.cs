﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.NetworkInformation;
using System.Diagnostics;
using System.Net.Sockets;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using mainServer;

namespace Chatserver
{
    public partial class Form1 : Form
    {

        public delegate void FileRecievedEventHandler(object source, string fileName);
        private delegate void UpdateStatusCallback(string strMessage);

        public event FileRecievedEventHandler NewFileRecieved;

        public Form1()
        {
            InitializeComponent();
        }



        private void Form1_Load(object sender, EventArgs e)
        {
            this.NewFileRecieved += new FileRecievedEventHandler(Form1_NewFileRecieved);
        }

        private void Form1_NewFileRecieved(object sender, string fileName)
        {
            this.BeginInvoke(
            new Action(
            delegate()
            {
                MessageBox.Show("New File Recieved\n" + fileName);
                System.Diagnostics.Process.Start("explorer", @"c:\");
            }));
        }

        private void btnListen_Click(object sender, EventArgs e)
        {
            int port = int.Parse(txtHost.Text);
            Task.Factory.StartNew(() => HandleIncomingFile(port));
            MessageBox.Show("Listening on port " + port);

            string localIP;
            using (Socket socket = new Socket(AddressFamily.InterNetwork, SocketType.Dgram, 0))
            {
                socket.Connect("10.0.2.4", 65530);
                IPEndPoint endPoint = socket.LocalEndPoint as IPEndPoint;
                localIP = endPoint.Address.ToString();
            }
            ipAddress.Text = localIP;
            // Parse the server's IP address out of the TextBox
            IPAddress ipAddr = IPAddress.Parse(localIP);
            // Create a new instance of the ChatServer object

            Debug.WriteLine(localIP);

            mainServer.ChatServer mainServer = new mainServer.ChatServer(ipAddr);
            // Hook the StatusChanged event handler to mainServer_StatusChanged
            global::mainServer.ChatServer.StatusChanged += new StatusChangedEventHandler(mainServer_StatusChanged);
            // Start listening for connections
            mainServer.StartListening();
            // Show that we started to listen for connections
            txtLog.AppendText("Monitoring for connections...\r\n");

            btnListen.Enabled = false;

        }

        public void mainServer_StatusChanged(object sender, StatusChangedEventArgs e)
        {
            // Call the method that updates the form
            this.Invoke(new UpdateStatusCallback(this.UpdateStatus), new object[] { e.EventMessage });
        }

        private void UpdateStatus(string strMessage)
        {
            // Updates the log with the message
            txtLog.AppendText(strMessage + "\r\n");
        }

        public void HandleIncomingFile(int port)
        {
            try
            {
                TcpListener tcpListener = new TcpListener(port);
                tcpListener.Start();
                while (true)
                {
                    Socket handlerSocket = tcpListener.AcceptSocket();
                    if (handlerSocket.Connected)
                    {
                        string fileName = string.Empty;
                        NetworkStream networkStream = new NetworkStream(handlerSocket);
                        int thisRead = 0;
                        int blockSize = 1024;
                        Byte[] dataByte = new Byte[blockSize];
                        lock (this)
                        {
                            string folderPath = @"c:\";
                            handlerSocket.Receive(dataByte);
                            int fileNameLen = BitConverter.ToInt32(dataByte, 0);
                            fileName = Encoding.ASCII.GetString(dataByte, 4, fileNameLen);
                            Stream fileStream = File.OpenWrite(folderPath + fileName);
                            fileStream.Write(dataByte, 4 + fileNameLen, (1024 - (4 + fileNameLen)));
                            while (true)
                            {
                                thisRead = networkStream.Read(dataByte, 0, blockSize);
                                fileStream.Write(dataByte, 0, thisRead);
                                if (thisRead == 0)
                                    break;
                            }
                            fileStream.Close();
                        }
                        if (NewFileRecieved != null)
                        {
                            NewFileRecieved(this, fileName);
                        }
                        handlerSocket = null;
                    }
                }
            }
            catch
            {
            }
        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void txtHost_TextChanged(object sender, EventArgs e)
        {

        }

        private void lbIp_Click(object sender, EventArgs e)
        {

        }

        private void ipAddress_TextChanged(object sender, EventArgs e)
        {

        }
    }
}