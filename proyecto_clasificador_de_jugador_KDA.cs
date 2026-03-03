El sistema calcula el KDA de uno o varios jugadores y los clasifica según su rendimiento.
También los ordena de mayor a menor para mostrar un ranking final.

Se evalúa:

Nombre

Asesinatos

Muertes

Asistencias

**IPO** — Diseño del Sistema
 Entradas
Nombre	Tipo
nombre	string
asesinatos	int
muertes	int
asistencias	int
Proceso

Cálculo del KDA:

Si muertes = 0 → KDA = asesinatos + asistencias

Si muertes > 0 → KDA = (asesinatos + asistencias) / muertes

Clasificación:

KDA < 1 → Jugador en desarrollo

1–2 → Jugador promedio

2–3 → Buen jugador

≥ 3 → Jugador elite

Los jugadores se ordenan de mayor a menor según su KDA.

 Salidas
Nombre	Tipo
kda	double
clasificacion	string
ranking	lista ordenada
 Casos de Prueba

Caso Normal
Asesinatos: 10
Muertes: 5
Asistencias: 5
Resultado: KDA 3.00 → Jugador elite

Caso Borde
Muertes: 0
Resultado: No hay división por cero → Se suman asesinatos + asistencias

ejecución

Abrir en Visual Studio o VS Code.

Compilar.

Ejecutar en consola.

Ingresar los datos solicitados.
