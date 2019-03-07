using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Timers;
using System.Collections;
using System.Threading;


namespace Teste_PortaSerialxServoMotor
{
    public partial class Form1 : Form
    {
        public static System.Timers.Timer aTimer;
        public static  byte[] messageSerialReturned = new byte[64];
        public static ArrayList mensagens = new ArrayList();


        
        public Form1()
        {
            InitializeComponent();
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            serialPort1.PortName = "COM20";
            serialPort1.BaudRate = 9600;
            txStatusSerial.Text = "Porta serial desconectada";
            pnCursor.Enabled = false;

            aTimer = new System.Timers.Timer(100);
            aTimer.Elapsed += new ElapsedEventHandler(aTimer_Elapsed);
            //aTimer.Enabled = true;

        }

        void aTimer_Elapsed(object sender, ElapsedEventArgs e)
        {

            if (serialPort1.IsOpen)
            {

                try
                {
                    serialPort1.DiscardOutBuffer();
                    char buffer = Convert.ToChar(sbCursor.Value);
                    serialPort1.Write(buffer.ToString());


                }
                catch (Exception ex)
                {
                    MessageBox.Show("Erro de comunicação com a porta para escrita em " + serialPort1.PortName + "." +
                        '\n' + ex.Message, "Error message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

                Thread.Sleep(50);

                try
                {
                    char[] tempMessage = new char[64];
                    String tempStr = "";
                    serialPort1.Read(tempMessage, 0, 64);
                    serialPort1.DiscardInBuffer();
                    for (int i = 0; i < 64; i++)
                    {
                        tempStr += tempMessage[i];
                    }
                    mensagens.Add(tempStr);

                }
                catch (Exception ex)
                {
                    MessageBox.Show("Erro de comunicação com a porta para leitura de " + serialPort1.PortName + "." +
                        '\n' + ex.Message, "Error message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }


            }
        }

        private void btConnection_Click(object sender, EventArgs e)
        {
            if (!serialPort1.IsOpen)
            {
                try
                {
                    serialPort1.Open();
                    btConnection.Text = "Desconectar PortaSerial";
                    txStatusSerial.Text = "Porta serial conectada";
                    pnCursor.Enabled = true;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Não foi possível conectar à porta " + serialPort1.PortName +
                        "." + '\n' + ex.Message, "Erro de conexão", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                
            }
            else
            {
                serialPort1.Close();
                btConnection.Text = "Conectar PortaSerial";
                txStatusSerial.Text = "Porta serial desconectada";
                pnCursor.Enabled = false;
            }

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (serialPort1.IsOpen)
            {
                serialPort1.DiscardOutBuffer();
                serialPort1.Write("1");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (serialPort1.IsOpen)
            {
                serialPort1.DiscardOutBuffer();
                serialPort1.Write("9");
            }
        }

        private void btAtualizar_Click(object sender, EventArgs e)
        {
            ltMessage.Items.Clear();
            for (int i = 0; i < mensagens.Count; i++)
            {
                ltMessage.Items.Add(mensagens[i]);
            }
        

            string tempStr = "";
            for (int i = 0; i < 64; i++)
			{
			    tempStr += messageSerialReturned[i];
			}
            ltMessage.Items.Add(tempStr);
        }

        private void sbCursor_Scroll(object sender, ScrollEventArgs e)
        {             
            try
            {
                serialPort1.DiscardOutBuffer();
                char buffer = Convert.ToChar(sbCursor.Value);
                serialPort1.Write(buffer.ToString());


            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro de comunicação com a porta para escrita em " + serialPort1.PortName + "." +
                    '\n' + ex.Message, "Error message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            Thread.Sleep(50);

            try
            {
                char[] tempMessage = new char[64];
                String tempStr = "";
                serialPort1.Read(tempMessage, 0, 64);
                serialPort1.DiscardInBuffer();
                for (int i = 0; i < 64; i++)
                {
                    tempStr += tempMessage[i];
                }
                mensagens.Add(sbCursor.Value.ToString() + " - " + tempStr);

            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro de comunicação com a porta para leitura de " + serialPort1.PortName + "." +
                    '\n' + ex.Message, "Error message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }       
    }
}
