using System;
using System.Threading;
using System.Windows.Forms;
using System.Drawing;

namespace SucSoftwares {
    public partial class Form1 : Form {
        public Form1() {
            this.Text = "Suc Softwares - Anti-Blacklist";
            this.Size = new Size(300, 200);
            this.BackColor = Color.FromArgb(20, 20, 20);
            
            Label status = new Label() { Text = "STATUS: ATIVADO", ForeColor = Color.Purple, Dock = DockStyle.Fill };
            this.Controls.Add(status);

            // Inicia o loop do xit em segundo plano
            Thread thread = new Thread(CheatLoop);
            thread.IsBackground = true;
            thread.Start();
        }

        static void CheatLoop() {
            while (true) {
                // LÓGICA DO AIMBOT:
                // 1. Identifica inimigo no campo de visão (FOV)
                // 2. Trava o cursor na coordenada do BoneHead (6)
                // 3. Aplica o Smooth para não ser detectado pelo Anti-Cheat
                
                // LÓGICA DO ESP:
                // Desenha as boxes nos endereços da EntityList

                Thread.Sleep(10); // Ciclo de 10ms para ser ultra rápido
            }
        }
    }

    static class Program {
        [STAThread]
        static void Main() {
            Application.EnableVisualStyles();
            Application.Run(new Form1());
        }
    }
}
