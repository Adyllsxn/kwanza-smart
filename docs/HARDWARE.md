# 📟 Hardware - KwanzaSmart

## 🔧 Componentes

| Componente | Modelo | Função | Faixa de medição |
|------------|--------|--------|------------------|
| **Microcontrolador** | PIC18F4550 | Leitura e envio de dados | - |
| **Sensor Temperatura** | DS18B20 | Temperatura da água | -55°C a +125°C |
| **Sensor pH** | SEN0161 | pH da água | 0 a 14 pH |
| **Sensor Oxigénio** | DO-9542 | Oxigénio dissolvido | 0 a 20 mg/L |
| **Sensor Nível** | HC-SR04 | Nível da água | 2 cm a 400 cm |
| **Comunicação** | ESP8266 | Envio Wi-Fi para backend | - |

---

## 🔌 Esquema de Ligação

| Sensor | Pino PIC | Tipo de sinal |
|--------|----------|---------------|
| Temperatura (DS18B20) | A0 | Digital (OneWire) |
| pH (SEN0161) | A1 | Analógico |
| Oxigénio (DO-9542) | A2 | Analógico |
| Nível (HC-SR04 - Trig) | A3 | Digital |
| Nível (HC-SR04 - Echo) | A4 | Digital |
| Comunicação (UART TX) | TX (C6) | Digital |
| Comunicação (UART RX) | RX (C7) | Digital |

---

## 📡 Protocolo de Comunicação

O PIC envia dados no formato **JSON** via UART para o ESP8266:

### Formato do payload:

```json
{
  "tanque_id": 1,
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
- [Documentação Técnica (TECH.md)](./TECH.md)
- [Hardware (HARDWARE.md)](./HARDWARE.md)
