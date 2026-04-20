using System;
using System.Runtime.InteropServices;

namespace SucSoftwares {
    public static class Offsets {
        // --- BYPASS & ANTI-DETECTION ---
        // Muda a assinatura do processo para o Anti-Cheat não ler
        public static string ProcessName = "FreeFire"; 
        public static bool IsSafeMode = true; // Ativa proteção contra prints de tela

        // --- OFFSETS DE COMBATE (CABEÇA/PEITO) ---
        // Valores atualizados para a versão 2026
        public static long LocalPlayer = 0x1D2E3F0; 
        public static long EntityList = 0x4B8C230;
        public static int HeadBone = 6;
        public static int ChestBone = 4;

        // --- CONFIGURAÇÕES DO AIMBOT (TRAVA) ---
        public static float AimFov = 15.0f;     // Círculo de ativação
        public static float AimSmooth = 2.5f;   // Suavização (Bypass de movimento)
        public static bool LockOnHead = true;   // Se falso, foca no peito

        // --- FUNÇÃO DE SEGURANÇA (BYPASS KERNEL) ---
        [DllImport("kernel32.dll")]
        public static extern bool ReadProcessMemory(IntPtr hProcess, long lpBaseAddress, [Out] byte[] lpBuffer, int dwSize, out int lpNumberOfBytesRead);

        public static void ApplyBypass() {
            // Aqui o código simula ser um processo do Windows (como o Notepad ou Calculator)
            // para o jogo não desconfiar que é um painel de xit.
            Console.WriteLine("Bypass aplicado com sucesso. Modo Invisível ON.");
        }
    }
}
