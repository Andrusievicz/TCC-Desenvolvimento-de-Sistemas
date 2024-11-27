using AxWMPLib;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SeuProjeto
{
    public partial class CapoeiraForm : Form
    {
        public CapoeiraForm()
        {
            InitializeComponent();
        }
        private void btnPlayVideo_Click(object sender, EventArgs e)
        {
            // Define o caminho do vídeo
            string videoPath = @"Video\CapoeiraVideo.mp4";

            // Configura o controle do Windows Media Player para carregar e reproduzir o vídeo
            axWindowsMediaPlayer.URL = videoPath;
            axWindowsMediaPlayer.uiMode = "none"; // esconde o controle do video
            axWindowsMediaPlayer.Ctlcontrols.play();
        }
        private void BtnAtividadeBack_Click(object sender, EventArgs e)
        {
            var atividadeMenu = new AtividadeForm();
            atividadeMenu.Show();
            this.Close();
        }
    }
}
