# ✨ Funcionalidades - KwanzaSmart

## 📡 Monitorização

### Sensores em Tempo Real

| Parâmetro | Unidade | Faixa ideal | Descrição |
|-----------|---------|-------------|-----------|
| 🌡️ Temperatura | °C | 24 - 30 | Monitoriza a temperatura da água |
| 💧 pH | pH | 6.5 - 8.0 | Nível de acidez/alcalinidade |
| 🫧 Oxigénio dissolvido | mg/L | 5.0 - 8.0 | Oxigénio disponível para os peixes |
| 📉 Nível da água | % | 60 - 80 | Altura da água no tanque |
| 🌀 Turbidez | NTU | < 5 | Clareza da água (opcional) |

### Funcionalidades

- ✅ Leitura automática a cada intervalo configurável
- ✅ Exibição em tempo real no dashboard
- ✅ Atualização via WebSockets (SignalR)
- ✅ Histórico completo de todas as leituras

---

## 📊 Dashboard

### Cards de Sensores

| Card | Informação | Cor |
|------|------------|-----|
| 🌡️ Temperatura | Valor atual + tendência | Azul |
| 💧 pH | Valor atual + status | Verde |
| 🫧 Oxigénio | Valor atual + alerta | Roxo |
| 📉 Nível | Percentagem + barra | Laranja |

### Gráficos

| Gráfico | Tipo | Descrição |
|---------|------|-----------|
| Temperatura vs pH | Linha | Evolução ao longo do tempo |
| Oxigénio dissolvido | Linha | Tendência de oxigenação |
| Nível da água | Área | Variação do nível |

---

## ⚠️ Alertas Inteligentes

### Tipos de Alerta

| Alerta | Condição | Cor | Ação sugerida |
|--------|----------|-----|---------------|
| 🔴 Temperatura alta | > 32°C | Vermelho | Ligar bomba/resfriador |
| 🔵 Temperatura baixa | < 22°C | Azul | Ligar aquecedor |
| 🟡 pH alto | > 8.0 | Amarelo | Verificar alcalinidade |
| 🟠 pH baixo | < 6.0 | Laranja | Corrigir acidez |
| 🟣 Oxigénio baixo | < 4.0 mg/L | Roxo | Ligar aerador |

### Funcionalidades

- ✅ Alertas automáticos em tempo real
- ✅ Notificações visuais no dashboard
- ✅ Log de todos os alertas gerados
- ✅ Limiares configuráveis pelo utilizador

---

## 🎛️ Controlo Remoto

### Dispositivos Controláveis

| Dispositivo | Função | Controlo |
|-------------|--------|----------|
| 🌀 Bomba d'água | Circulação/resfriamento | Ligar / Desligar |
| 💨 Aerador | Oxigenação da água | Ligar / Desligar |
| 🔥 Aquecedor | Aquecimento da água | Ligar / Desligar |
| 🍽️ Alimentador | Ração automática | Manual / Programado |

### Modos de Operação

| Modo | Descrição |
|------|-----------|
| 🤖 Automático | Sistema decide com base nos sensores |
| 👆 Manual | Utilizador controla diretamente |

---

## 🚀 Roadmap

### Funcionalidades Planeadas

| Prioridade | Funcionalidade | Previsão |
|------------|----------------|----------|
| 🔴 Alta | App Mobile (React Native) | Q3 2026 |
| 🔴 Alta | Notificações push (email/SMS) | Q3 2026 |
| 🟡 Média | Múltiplos tanques | Q4 2026 |
| 🟢 Baixa | IA para previsão de problemas | 2027 |

---

## 🔗 Links Úteis

- [README principal](../README.md)
- [Documentação Técnica (TECH.md)](./TECH.md)
- [Features (FEATURES.md)](./FEATURES.md)