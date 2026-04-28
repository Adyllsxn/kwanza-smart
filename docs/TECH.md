# 🛠️ Tecnologias - KwanzaSmart

## 🖥️ Backend

| Tecnologia | Versão | Descrição |
|------------|--------|-----------|
| ![C#](https://img.shields.io/badge/C%23-239120?style=flat-square&logo=csharp&logoColor=white) | .NET 8 | Linguagem principal |
| ![ASP.NET Core](https://img.shields.io/badge/ASP.NET%20Core-512BD4?style=flat-square&logo=dotnet&logoColor=white) | 8.0 | Framework web para API REST |
| ![SignalR](https://img.shields.io/badge/SignalR-512BD4?style=flat-square&logo=dotnet&logoColor=white) | 8.0 | Comunicação em tempo real |
| ![Swagger](https://img.shields.io/badge/Swagger-85EA2D?style=flat-square&logo=swagger&logoColor=black) | 6.5.x | Documentação da API |

---

## 🎨 Frontend

| Tecnologia | Versão | Descrição |
|------------|--------|-----------|
| ![Blazor](https://img.shields.io/badge/Blazor-512BD4?style=flat-square&logo=blazor&logoColor=white) | .NET 8 | Framework para SPA com C# |
| ![Bootstrap](https://img.shields.io/badge/Bootstrap-7952B3?style=flat-square&logo=bootstrap&logoColor=white) | 5.x | Layout responsivo |
| ![Chart.js](https://img.shields.io/badge/Chart.js-FF6384?style=flat-square&logo=chartdotjs&logoColor=white) | 4.4.x | Gráficos em tempo real |

---

## 📟 Hardware

| Componente | Modelo | Função |
|------------|--------|--------|
| **Microcontrolador** | PIC18F4550 | Leitura e envio de dados |
| **Sensor Temperatura** | DS18B20 | Temperatura da água |
| **Sensor pH** | SEN0161 | pH da água |
| **Sensor Oxigénio** | DO-9542 | Oxigénio dissolvido |
| **Sensor Nível** | HC-SR04 | Nível da água |
| **Comunicação** | ESP8266 | Envio Wi-Fi para backend |

---

## 🔌 Comunicação
> PIC (UART) → ESP8266 (Wi-Fi) → API Backend → SignalR → Dashboard


| Protocolo | Utilização |
|-----------|------------|
| **UART** | Comunicação PIC → ESP8266 |
| **HTTP/REST** | ESP8266 → Backend |
| **WebSocket (SignalR)** | Backend → Frontend |

### Formato do payload (JSON)

```json
{
  "tanqueId": 1,
  "temperatura": 28.5,
  "ph": 6.8,
  "oxigenio": 5.9,
  "nivel": 75.0,
  "timestamp": "2026-04-27T10:30:00Z"
}
```

---

## 🔗 Links Úteis

- [README principal](../README.md)
- [Features (FEATURES.md)](./FEATURES.md)
- [Hardware (HARDWARE.md)](./HARDWARE.md)
