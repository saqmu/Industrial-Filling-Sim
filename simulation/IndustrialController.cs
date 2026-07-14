using UnityEngine;

public class IndustrialController : MonoBehaviour
{
    // Este script lê os botões 1, 2, 3 e 4 do seu console USB
    
    void Update()
    {
        // BOTÃO 1: ESTEIRA
        if (Input.GetButtonDown("JoystickButton0")) {
            Debug.Log("BOTÃO 1: Iniciando movimentação da esteira...");
            // Aqui entra o código que move a garrafa
        }

        // BOTÃO 2: ENVASE (Onde a gravidade acontece)
        if (Input.GetButton("JoystickButton1")) {
            Debug.Log("BOTÃO 2: Válvula aberta. Enchendo líquido...");
            // Aqui ativa o sistema de partículas (líquido com gravidade)
        }

        // BOTÃO 3: LACRAMENTO
        if (Input.GetButtonDown("JoystickButton2")) {
            Debug.Log("BOTÃO 3: Descendo prensa de lacramento.");
        }

        // BOTÃO 4: EXPEDIÇÃO
        if (Input.GetButtonDown("JoystickButton3")) {
            Debug.Log("BOTÃO 4: Garrafa finalizada e enviada ao estoque.");
        }
    }
}
