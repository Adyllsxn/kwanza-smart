# 🔧 Setup do Hardware - KwanzaSmart

## 📟 Componentes Necessários

| Componente | Modelo | Quantidade | Função |
|------------|--------|------------|--------|
| **Microcontrolador** | PIC18F4550 | 1 | Processamento e leitura dos sensores |
| **Módulo Wi-Fi** | ESP8266 | 1 | Comunicação com o backend |
| **Sensor Temperatura** | DS18B20 | 1 | Mede temperatura da água |
| **Sensor pH** | SEN0161 | 1 | Mede pH da água |
| **Sensor Oxigénio** | DO-9542 | 1 | Mede oxigénio dissolvido |
| **Sensor Nível** | HC-SR04 | 1 | Mede nível da água |
| **Fonte alimentação** | 5V / 12V | 1 | Alimenta o sistema |
| **Jumpers** | - | Vários | Ligações elétricas |

---

## 🔌 Esquema de Ligação

### PIC18F4550 → Sensores

| Sensor | Pino PIC | Tipo |
|--------|----------|------|
| DS18B20 (Temperatura) | A0 | Digital (OneWire) |
| SEN0161 (pH) | A1 | Analógico |
| DO-9542 (Oxigénio) | A2 | Analógico |
| HC-SR04 (Trig) | A3 | Digital |
| HC-SR04 (Echo) | A4 | Digital |

### PIC18F4550 → ESP8266 (Wi-Fi)

| PIC | ESP8266 | Descrição |
|-----|---------|-----------|
| TX (C6) | RX | Envio de dados |
| RX (C7) | TX | Receção de comandos |
| GND | GND | Terra comum |
| VCC (3.3V) | VCC | Alimentação |

---

## 📡 Protocolo de Comunicação

O PIC envia dados para o ESP8266 via UART no formato JSON:

```json
{
  "temperatura": 28.5,
  "ph": 7.2,
  "oxigenio": 6.2,
  "nivel": 65,
  "timestamp": "2026-05-03T10:30:00Z"
}