using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Runtime.InteropServices;

namespace WebCamForm
{
    public partial class UCWebCam : UserControl, IDisposable
    {
        //Altura e largura da imagem da webcam
        private int m_Width = 500;
        private int m_Height = 400;

        //Handle da janela de controle da webcam
        private int mCapHwnd;

        //Flag de webcam parada
        private bool bStopped = true;

        #region API Declarations

        //Abaixo tremos todas as chamadas das APIs do Sistema Operacional Windows. 
        //Essas chamadas fazem a interface do nosso controle com a WebCam e com o SO. 

        //Esta chamada é uma das mais importantes e é vital para o funcionamento do SO.  
        [DllImport("user32", EntryPoint = "SendMessage")]
        public static extern int SendMessage(int hWnd, uint Msg, int wParam, int lParam);

        //Esta API cria a instância da webcam para que possamos acessa-la. 
        [DllImport("avicap32.dll", EntryPoint = "capCreateCaptureWindowA")]
        public static extern int capCreateCaptureWindowA(string lpszWindowName, int dwStyle, int x, int y, int nWidth, int nHeight, int hwndParent, int nID);

        //Esta API abre a área de tranferência para que possamos buscar os dados da webcam. 
        [DllImport("user32", EntryPoint = "OpenClipboard")]
        public static extern int OpenClipboard(int hWnd);

        //Esta API limpa a área de transferência. 
        [DllImport("user32", EntryPoint = "EmptyClipboard")]
        public static extern int EmptyClipboard();

        //Esta API fecha a área de tranferência após utilização. 
        [DllImport("user32", EntryPoint = "CloseClipboard")]
        public static extern int CloseClipboard();

        //Esta API recupera os dados da área de tranferência para a utilização. 
        [DllImport("user32.dll")]
        extern static IntPtr GetClipboardData(uint uFormat);

        #endregion 

        #region API Constants

        //Esas constantes são predefinidas pelo SO 

        public const int WM_USER = 1024;

        public const int WM_CAP_CONNECT = 1034;
        public const int WM_CAP_DISCONNECT = 1035;
        public const int WM_CAP_GT_FRAME = 1084;
        public const int WM_CAP_COPY = 1054;

        public const int WM_CAP_START = WM_USER;

        public const int WM_CAP_DLG_VIDEOFORMAT = WM_CAP_START + 41;
        public const int WM_CAP_DLG_VIDEOSOURCE = WM_CAP_START + 42;
        public const int WM_CAP_DLG_VIDEODISPLAY = WM_CAP_START + 43;
        public const int WM_CAP_GET_VIDEOFORMAT = WM_CAP_START + 44;
        public const int WM_CAP_SET_VIDEOFORMAT = WM_CAP_START + 45;
        public const int WM_CAP_DLG_VIDEOCOMPRESSION = WM_CAP_START + 46;
        public const int WM_CAP_SET_PREVIEW = WM_CAP_START + 50;

        #endregion


        /// <summary>
        /// Ajusta o tamanho da imagem da Webcam com o tamanho da tela
        /// </summary>

        private void ImageSize()
        {
            m_Height = imgWebCam.Size.Height;
            m_Width = imgWebCam.Size.Width;
        }

        /// <summary>
        /// Iniciar a captura de tela da webcam
        /// 
        /// </summary>

        #region Start e Stop webcam

        public void Start()
        {
            try
            {
                //Ajusta o tamanho da imagem
                ImageSize();

                //por segurança se inicia o metodo com a webcam em stop
                this.Stop();

                //Criar janela de captura utilizando API
                mCapHwnd = capCreateCaptureWindowA("WebCap", 0, 0, 0, m_Width, m_Height, this.Handle.ToInt32(), 0);
 
                //liberar recurso ao SO
                Application.DoEvents();

                //messagem ao SO para conectar com o driver
                SendMessage(mCapHwnd, WM_CAP_CONNECT, 0, 0);
                SendMessage(mCapHwnd, WM_CAP_CONNECT, 0, 0);
                SendMessage(mCapHwnd, WM_CAP_CONNECT, 0, 0);

                /* Ajustamos o intervalo de captura da webcam
                 * POdemos criar uma prioridade do componente para
                 * alterarmos o tempo. Lembrando que quanto maior o tempo
                 * maior o atraso entre o capturado e o exibido*/
                this.tmrRefreshFrame.Interval = 1;
                bStopped = false;
                this.tmrRefreshFrame.Start();
                
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao iniciar a webcam.\n" + ex.Message, "webcam error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.Stop();
            }
        }


        public void TakePicture()
        {
            try
            {
                //Ajusta o tamanho da imagem
                ImageSize();

                //por segurança se inicia o metodo com a webcam em stop
                this.Stop();

                //Criar janela de captura utilizando API
                mCapHwnd = capCreateCaptureWindowA("WebCap", 0, 0, 0, m_Width, m_Height, this.Handle.ToInt32(), 0);

                //liberar recurso ao SO
                Application.DoEvents();

                //messagem ao SO para conectar com o driver
                SendMessage(mCapHwnd, WM_CAP_CONNECT, 0, 0);
                SendMessage(mCapHwnd, WM_CAP_CONNECT, 0, 0);
                SendMessage(mCapHwnd, WM_CAP_CONNECT, 0, 0);



                //Envia mensagem ao SO para capturar o frame
                SendMessage(mCapHwnd, WM_CAP_GT_FRAME, 0, 0);

                //copia o frame para a area de transferencia

                SendMessage(mCapHwnd, WM_CAP_COPY, 0, 0);

                //Abre a area de transferencia
                OpenClipboard(mCapHwnd);

                //busca dados da imagem e põe eles em um ponteiro
                IntPtr img = GetClipboardData(2);

                //fecha a area de transferencia

                CloseClipboard();

                //criar objeto bitmap para receber a imagem
                Bitmap bmp = new Bitmap(m_Width, m_Height);

                //criar objeto graphics para manipular a imagem
                Graphics gfc = Graphics.FromImage(bmp);


                //ajustar algumas propriedades da imagem para otimizar a velocidade ou qualidade;
                gfc.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.HighQuality;
                gfc.InterpolationMode = System.Drawing.Drawing2D.InterpolationMode.High;
                gfc.PixelOffsetMode = System.Drawing.Drawing2D.PixelOffsetMode.HighQuality;
                gfc.CompositingQuality = System.Drawing.Drawing2D.CompositingQuality.HighQuality;


                // carregar a imagem do ponteiro para o bitmap
                gfc.DrawImage(Image.FromHbitmap(img), 0, 0, m_Width, m_Height);


                //carregar o controle com o bitmap
                imgWebCam.Image = bmp;

                //refresh da imagem
                imgWebCam.Refresh();

                //liberar o recurso ao SO
                Application.DoEvents();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao iniciar a webcam.\n" + ex.Message, "webcam error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.Stop();
            }
            finally
            {
                this.Stop();
            }
        }


        /// <summary>
        /// 
        /// </summary>

        public void Stop()
        {
            try
            {
                //Parar o timer
                bStopped = false;
                tmrRefreshFrame.Stop();

                //liberar recurso ao SO
                Application.DoEvents();

                SendMessage(mCapHwnd, WM_CAP_DISCONNECT, 0, 0);

                //Fecha a área de transferencia
                CloseClipboard();

            }
            catch (Exception)
            {
            }
        }
        #endregion

        #region captura do video

        /// <summary>
        /// 
        /// </summary>

        private void tmrRefreshFrame_Tick(object sender, System.EventArgs e)
        {
            try
            {
                // pausa o temporizadora
                tmrRefreshFrame.Stop();

                //ajusta o tamanho da imagem
                ImageSize();

                //Envia mensagem ao SO para capturar o frame
                SendMessage(mCapHwnd, WM_CAP_GT_FRAME, 0, 0);

                //copia o frame para a area de transferencia

                SendMessage(mCapHwnd, WM_CAP_COPY, 0, 0);

                //Abre a area de transferencia
                OpenClipboard(mCapHwnd);

                //busca dados da imagem e põe eles em um ponteiro
                IntPtr img = GetClipboardData(2);

                //fecha a area de transferencia

                CloseClipboard();

                //criar objeto bitmap para receber a imagem
                Bitmap bmp = new Bitmap(m_Width, m_Height);

                //criar objeto graphics para manipular a imagem
                Graphics gfc = Graphics.FromImage(bmp);


                //ajustar algumas propriedades da imagem para otimizar a velocidade ou qualidade;
                gfc.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.HighSpeed;
                gfc.InterpolationMode = System.Drawing.Drawing2D.InterpolationMode.Low;
                gfc.PixelOffsetMode = System.Drawing.Drawing2D.PixelOffsetMode.HighSpeed;
                gfc.CompositingQuality = System.Drawing.Drawing2D.CompositingQuality.HighSpeed;


                // carregar a imagem do ponteiro para o bitmap
                gfc.DrawImage(Image.FromHbitmap(img), 0, 0, m_Width, m_Height);


                //carregar o controle com o bitmap
                imgWebCam.Image = bmp;

                //refresh da imagem
                imgWebCam.Refresh();

                //liberar o recurso ao SO
                Application.DoEvents();

                if (!bStopped)
                    this.tmrRefreshFrame.Start();


            }
            catch (Exception ex)
            {

                MessageBox.Show("Erro na exibição da webcam.\n" + ex.Message, "Error in webcam", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.Stop();
            }
        }


        #endregion

        void IDisposable.Dispose()
        {
            this.Dispose();
        }


        //garantir que a webcam será fechada ao encerrar a classe
        ~UCWebCam()
        {
            this.Stop();
        }


        

        public UCWebCam()
        {
            InitializeComponent();
        }

        private void imgWebCam_Click(object sender, EventArgs e)
        {

        }
    }
}
