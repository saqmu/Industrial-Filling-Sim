# 🏭 Beverage Industrial Digital Twin - Simulação de Envase 3D

Este projeto consiste em uma célula de manufatura automatizada para envase de bebidas, controlada por um **console físico externo via USB**. O objetivo é criar um "Gêmeo Digital" onde a física do mundo real (gravidade e fluidez) é replicada em um ambiente 3D.

## 🕹️ Controle de Hardware (Mapeamento dos Botões)

O console possui 4 botões de acionamento industrial com as seguintes funções programadas:

| Botão | Ação Industrial | Descrição Técnica |
| :--- | :--- | :--- |
| **01** | **Alimentação** | Aciona a esteira para posicionar uma garrafa vazia sob a válvula. |
| **02** | **Envase (Filling)** | Abre a válvula de fluido. Utiliza física de partículas para simular o preenchimento. |
| **03** | **Lacramento** | Aciona a prensa pneumática para colocação de tampas/rolhas. |
| **04** | **Expedição** | Libera a garrafa pronta para o estoque e gera log de produção no sistema. |

## 💧 Simulação Realista e Gravidade

Para garantir o realismo da "empresa", a simulação utiliza:
- **Gravity Physics:** O líquido só flui se a válvula estiver aberta e a garrafa posicionada abaixo.
- **Fluid Dynamics:** O volume do líquido reage à inclinação da garrafa e ao impacto da queda.
- **Collision Detection:** Sensores detectam se a garrafa transbordou ou se está vazia.

## 🛠️ Tecnologias Utilizadas
- **3D Engine:** Unity (C#) para simulação de física e renderização.
- **Hardware:** Console USB Customizado (Interface HID).
- **Controle de Versão:** GitHub para documentação e código-fonte.

---
*Status do Projeto: Em Desenvolvimento (Fase de Integração de Hardware)*
