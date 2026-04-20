using System;
using System.Drawing;
using System.Windows.Forms;
using System.Threading;
using System.Runtime.InteropServices;

namespace SucSoftwares {
    public partial class Form1 : Form {
        // Cores do Espaço (Space Xit)
        Color roxoNeon = Color.FromArgb(157, 0, 255);
        Color fundoDark = Color.FromArgb(10, 10, 10);
        Color lateralDark = Color.FromArgb(20, 20, 20);

        public Form1() {
            // Configurações da Janela
            this.Size = new Size(600, 400);
            this.BackColor = fundoDark;
            this.FormBorderStyle = FormBorderStyle.None;
            this.StartPosition = FormStartPosition.CenterScreen;
            this.TopMost = true; // Sempre por cima do jogo

            // Painel Lateral de Abas
            Panel lateral = new Panel() { Width = 160, Dock = DockStyle.Left, BackColor = lateralDark };
            this.Controls.Add(lateral);

            // Logo Superior
            Label logo = new Label() { 
                Text = "SPACE XIT", 
                ForeColor = roxoNeon, 
                Font = new Font("Segoe UI", 16, FontStyle.Bold), 
                Dock = DockStyle.Top, 
                Height = 60, 
                TextAlign = ContentAlignment.MiddleCenter 
            };
            lateral.Controls.Add(logo);

            // Criar Botões das Abas do seu Checklist
            CriarBotaoAba(lateral, "🎯 COMBAT", 70);
            CriarBotaoAba(lateral, "👁️ VISUAL", 115);
            CriarBotaoAba(lateral, "🚶 PLAYER", 160);
            CriarBotaoAba(lateral, "🔫 WEAPON", 205);
            CriarBotaoAba(lateral, "⚙️ SETTINGS", 250);

            // Botão Fechar
            Button fechar = new Button() { 
                Text = "×", 
                ForeColor = Color.White, 
                Font = new Font("Arial", 14),
                FlatStyle = FlatStyle.Flat, 
                Size = new Size(30, 30), 
                Location = new Point(565, 5) 
            };
            fechar.FlatAppearance.BorderSize = 0;
            fechar.Click += (s, e) => Application.Exit();
            this.Controls.Add(fechar);

            // Inicia o Loop do Xit em segundo plano
            Thread t = new Thread(CheatLoop);
            t.IsBackground = true;
            t.Start();
        }

        private void CriarBotaoAba(Panel p, string texto, int y) {
            Button btn = new Button() {
                Text = "  " + texto,
                Location = new Point(0, y),
                Size = new Size(160, 40),
                FlatStyle = FlatStyle.Flat,
                ForeColor = Color.DarkGray,
                Font = new Font("Segoe UI", 9, FontStyle.Bold),
                TextAlign = ContentAlignment.MiddleLeft
            };
            btn.FlatAppearance.BorderSize = 0;
            btn.MouseEnter += (s, e) => { btn.ForeColor = roxoNeon; btn.BackColor = Color.FromArgb(30, 30, 30); };
            btn.MouseLeave += (s, e) => { btn.ForeColor = Color.DarkGray; btn.BackColor = lateralDark; };
            p.Controls.Add(btn);
        }

        // --- LÓGICA DO CHEAT ---
        static void CheatLoop() {
            while (true) {
                // Aqui o script fica lendo a memória e travando na cabeça
                // Baseado nos Offsets que estão no Offsets.cs
                Thread.Sleep(10); 
            }
        }

        // Permite arrastar o menu segurando o mouse
        [DllImport("user32.dll")]
        public static extern bool ReleaseCapture();
        [DllImport("user32.dll")]
        public static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);

        protected override void OnMouseDown(MouseEventArgs e) {
            base.OnMouseDown(e);
            if (e.Button == MouseButtons.Left) {
                ReleaseCapture();
                SendMessage(Handle, 0xA1, 0x2, 0);
            }
        }
    }

    static class Program {
        [STAThread]
        static void Main() {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1());
        }
    }
}
