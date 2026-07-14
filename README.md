# 🏭 Industrial-Filling-Sim: Beverage Digital Twin

Este projeto é uma simulação industrial realista de uma linha de produção de bebidas, controlada por um **console físico externo (Hardware)**. O sistema utiliza física avançada de fluidos e gravidade para replicar um ambiente de fábrica em 3D.

## 🕹️ Controle de Hardware (HID Interface)

O sistema é operado através de um console USB reconhecido como **USB Gamepad**, mapeado da seguinte forma:

| Botão Físico | Ação no Software | Função Industrial |
| :--- | :--- | :--- |
| **Botão 01** | `JoystickButton0` | **Esteira:** Posiciona a garrafa vazia. |
| **Botão 02** | `JoystickButton1` | **Envase:** Abre a válvula (Física de Gravidade). |
| **Botão 03** | `JoystickButton2` | **Tampador:** Aplica o lacre na garrafa. |
| **Botão 04** | `JoystickButton3` | **Expedição:** Move para o estoque e gera Log. |

## 💧 Realismo e Física de Fluidos
Para atingir o nível de realismo industrial desejado:
- **Gravidade Dinâmica:** O líquido possui massa e cai conforme a aceleração da gravidade.
- **Colisores 3D:** As garrafas possuem malhas de colisão que retêm o líquido.
- **Simulação de Partículas:** O fluxo de bebida reage ao impacto e ao preenchimento em tempo real.

## 📂 Estrutura do Repositório
- `/simulation`: Contém os scripts C# para controle da lógica industrial na Unity.
- `/hardware`: Documentação técnica da interface USB.
- `/assets`: Modelos 3D e materiais da fábrica.

---
*Status: Hardware mapeado e lógica de controle em desenvolvimento.*
