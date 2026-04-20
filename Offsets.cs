using System;

namespace SucSoftwares {
    public static class Offsets {
        // Offsets Dinâmicos - Aqui é onde a mágica acontece
        public static long LocalPlayer = 0x1D2E3F0; // Exemplo atualizado
        public static long EntityList = 0x4B8C230;  // Exemplo atualizado
        
        // IDs de Ossos para o Aimbot (6 = Cabeça)
        public static int BoneHead = 6;
        
        // Configurações do "Grude"
        public static float AimSmooth = 2.0f; // Quanto menor, mais rápido puxa
        public static float AimFov = 15.0f;   // Tamanho do círculo de trava
    }
}
