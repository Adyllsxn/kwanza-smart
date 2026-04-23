# Hardware do KwanzaSmart

## Componentes

| Componente | Modelo sugerido | Função |
|------------|----------------|--------|
| Microcontrolador | PIC18F4550 | Leitura e envio de dados |
| Sensor temperatura | DS18B20 | Temperatura da água |
| Sensor pH | SEN0161 | pH da água |
| Sensor oxigénio | DO-9542 | Oxigénio dissolvido |
| Sensor nível | HC-SR04 | Nível da água |

## Esquema de ligação

| Sensor | Pino PIC |
|--------|----------|
| Temperatura | A0 |
| pH | A1 |
| Oxigénio | A2 |
| Nível | A3 |

## Protocolo de comunicação

O PIC envia dados no formato: