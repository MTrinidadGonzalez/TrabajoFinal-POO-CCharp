Este proyecto en C# es parte de una aplicación que gestiona vuelos y pasajeros para una aerolínea. Se trata de una estructura básica que permite agregar vuelos, registrar pasajeros, calcular la ocupación de vuelos, y más. A continuación se explica el contenido de cada archivo que forma parte del proyecto.
Cómo usar este proyecto:
Ejecuta el programa desde el archivo Program.cs.
Se mostrará un menú con opciones para gestionar vuelos y pasajeros.
Puedes agregar vuelos, registrar pasajeros, y consultar la ocupación de los vuelos.
Los datos de los vuelos se guardarán automáticamente en un archivo vuelos.xml al finalizar.

1. Archivo: Program.cs
Este archivo contiene el punto de entrada principal de la aplicación (Main), que ejecuta un programa de consola interactivo.

Funciones Principales:
Mostrar Menú: Se le presenta al usuario un menú con varias opciones, como agregar un vuelo, registrar un pasajero, ver la ocupación media, y más.
Agregar Vuelo: Permite al usuario ingresar los datos de un vuelo (como código de vuelo, piloto, fecha de salida y llegada, etc.) y agregarlo a la lista de vuelos.
Registrar Pasajero: Registra a un pasajero en un vuelo específico.
Calcular Ocupación Media: Muestra el porcentaje de ocupación media de todos los vuelos registrados.
Ver Vuelo con Mayor Ocupación: Muestra el vuelo con la mayor ocupación.
Buscar Vuelo por Código: Permite buscar y mostrar información de un vuelo utilizando su código.
Listar Vuelos Ordenados por Ocupación: Muestra todos los vuelos ordenados por su nivel de ocupación.
Guardar y Salir: Guarda los datos de los vuelos en un archivo XML y termina el programa.
2. Archivo: Aerolineas.cs
Este archivo contiene la clase Aerolineas, que gestiona los vuelos registrados y la información relacionada con la aerolínea.

Propiedades:
RazonSocial: El nombre de la aerolínea.
Telefono: El número de teléfono de la aerolínea.
Domicilio: La dirección de la aerolínea.
Vuelos: Una lista de objetos Vuelos que representa todos los vuelos registrados por la aerolínea.

Métodos:
AgregarVuelo: Añade un vuelo a la lista de vuelos de la aerolínea.
CalcularOcupacionMedia: Calcula y devuelve la ocupación media de todos los vuelos de la aerolínea. Si no hay vuelos, muestra un mensaje de advertencia.
VueloConMayorOcupacion: Devuelve el vuelo con mayor ocupación. Si no hay vuelos registrados, devuelve null y muestra un mensaje.
BuscarVueloPorCodigo: Busca un vuelo por su código. Si no lo encuentra, devuelve null.
ListarVuelosOrdenadosPorOcupacion: Devuelve una lista de vuelos ordenada de mayor a menor según su ocupación.
GuardarDatosXML: Guarda los datos de los vuelos en un archivo XML.
CargarDatosXML: Carga los datos de vuelos desde un archivo XML, si existe.

3. Archivo: Vuelos.cs
Este archivo define la clase Vuelos, que representa a un vuelo individual y maneja la información de cada vuelo.

Propiedades:
CodigoVuelo: El código único del vuelo.
FechaHoraSalida: La fecha y hora de salida del vuelo.
FechaHoraLlegada: La fecha y hora de llegada del vuelo.
Piloto: El nombre del piloto del vuelo.
Copiloto: El nombre del copiloto del vuelo.
CapacidadMaxima: La capacidad máxima de pasajeros que puede transportar el vuelo.
PasajerosActuales: El número de pasajeros registrados actualmente en el vuelo.
ListaPasajeros: Una lista de objetos Pasajeros, que contiene a todos los pasajeros registrados en el vuelo.

Métodos:
CalcularOcupacion: Calcula la ocupación del vuelo en porcentaje, usando la fórmula (PasajerosActuales / CapacidadMaxima) * 100. Si la capacidad máxima es 0, devuelve 0.
AgregarPasajero: Permite agregar un pasajero a la lista de pasajeros del vuelo, siempre y cuando no se haya alcanzado la capacidad máxima. Si el vuelo ya está lleno, no agrega al pasajero y retorna false.

4. Archivo: Pasajeros.cs
Este archivo contiene la clase Pasajeros, que representa la información de un pasajero.

Propiedades:
Nombre: El nombre del pasajero.
Apellido: El apellido del pasajero.
Telefono: El número de teléfono del pasajero.
DNI: El DNI del pasajero.
Email: El correo electrónico del pasajero.
Métodos:
Constructor: Inicializa los datos del pasajero con los valores proporcionados (nombre, apellido, teléfono, DNI, email).



Archivo de Datos: vuelos.xml
Este archivo XML almacena los datos de los vuelos de la aerolínea. El formato es el siguiente:

xml
Copiar código
<Vuelos>
  <Vuelo>
    <CodigoVuelo>V001</CodigoVuelo>
    <FechaHoraSalida>2023-12-01 10:00</FechaHoraSalida>
    <FechaHoraLlegada>2023-12-01 12:00</FechaHoraLlegada>
    <Piloto>Juan Pérez</Piloto>
    <Copiloto>Maria Gómez</Copiloto>
    <CapacidadMaxima>150</CapacidadMaxima>
    <PasajerosActuales>50</PasajerosActuales>
  </Vuelo>
</Vuelos>
Función:
CargarDatosXML: Carga la lista de vuelos desde este archivo.
GuardarDatosXML: Guarda los vuelos actuales en este archivo XML.

