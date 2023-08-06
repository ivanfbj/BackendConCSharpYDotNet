# Curso de APIs con .NET

## Clase 3 - ¿Qué es una API?

Application Programming Interface: Una aplicación que nos permite crear una capa de extracción entre una aplicación y otra.

**Catacteristicas:**

- Exponer método y funciones para ser consumido por otras aplicaciones.
- Posee una capa de abstracción para ser consumida.
- Puede tener capas de seguridad que brinden autenticación y autorización.

## Clase 4 - ¿Qué es REST?

REST es un acrónimo que significa “***Representational State Transfer***”. Es un estilo de arquitectura de software que se utiliza para desarrollar aplicaciones en la web.

REST es una forma estándar de crear `APIs`, y se basa en la utilización de protocolos HTTP (Hypertext Transfer Protocol) para realizar operaciones CRUD (Create, Read, Update, Delete) en recursos web. En otras palabras, REST utiliza los verbos HTTP (como GET, POST, PUT y DELETE) para realizar operaciones en los recursos web.

**Contiene las siguientes propiedades:**

- Rendimiento
- Simplicidad
- Escalabilidad
- Confialidad

**URL:**
Una URL en una API REST debe tener las siguientes propiedades:

1. **Clarity**: La URL debe ser clara y fácil de leer para que sea fácil de entender para los desarrolladores que la utilizan.
2. **Identificación de recursos**: La URL debe identificar de manera clara y concisa el recurso que se está solicitando.
3. **Hierarchía**: La URL debe ser un reflejo de la estructura jerárquica de los recursos, lo que permite una fácil navegación.
4. **Consistencia**: La URL debe ser consistente a lo largo de toda la API y seguir un estándar claro para que sea fácil de seguir.
5. **Accesibilidad**: La URL debe ser accesible para los clientes que utilizan la API, lo que significa que debe ser fácil de recordar y de escribir.
6. **Evitación de duplicados**: La URL debe ser única y evitar la duplicación de recursos para evitar confusiones.
7. **Selección de verbo HTTP adecuado**: La URL debe reflejar el verbo HTTP que se utiliza para la solicitud, por ejemplo, utilizar “GET /recursos” para recuperar una lista de recursos.

**Verbos Http:**
HTTP es un protocolo utilizado para transferir información en la web, y los verbos HTTP son los comandos utilizados para solicitar una acción en un recurso en la web. Los verbos HTTP más comunes son los siguientes:

**`GET`**: utilizado para recuperar información de un recurso. Este es el verbo HTTP más utilizado y es utilizado para recuperar información de una página web o un API.
**`POST`**: utilizado para enviar información a un recurso para que sea procesada. Por ejemplo, cuando se envía un formulario en una página web, se utiliza el verbo POST para enviar los datos del formulario al servidor.
**`PUT`**: utilizado para actualizar un recurso existente. Por ejemplo, si desea actualizar la información de un producto en una base de datos, utilizaría el verbo PUT para enviar la nueva información al servidor.
**`DELETE`**: utilizado para eliminar un recurso. Por ejemplo, si desea eliminar un producto de una base de datos, utilizaría el verbo DELETE para enviar una solicitud al servidor para que lo elimine.
**`HEAD`**: utilizado para recuperar la cabecera de un recurso sin la respuesta completa.
**`PATCH`**: utilizado para actualizar parcialmente un recurso existente. Por ejemplo, si desea actualizar solo algunos campos de un producto en una base de datos, utilizaría el verbo PATCH para enviar la información actualizada al servidor.

**Respuestas Http:**
Las respuestas HTTP son mensajes que se envían desde un servidor web a un cliente (como un navegador web o una aplicación) después de haber recibido una solicitud HTTP. Cada respuesta HTTP incluye un código de estado que indica el resultado de la solicitud.

Algunos de los códigos de estado HTTP más comunes son los siguientes:

- **200 OK**: Indica que la solicitud HTTP se ha realizado correctamente y el servidor ha devuelto la información solicitada.
- **201 Created**: Indica que se ha creado un recurso nuevo en el servidor como resultado de la solicitud HTTP.
- **204 No Content**: Indica que la solicitud HTTP se ha procesado correctamente, pero no hay ninguna información que devolver.
- **400 Bad Request**: Indica que la solicitud HTTP no es válida y el servidor no puede procesarla.
- **401 Unauthorized**: Indica que la solicitud requiere autenticación y el cliente no proporcionó credenciales válidas.
- **403 Forbidden**: Indica que el cliente no tiene permisos para acceder al recurso solicitado.
- **404 Not Found**: Indica que el servidor no pudo encontrar el recurso solicitado.
- **500 Internal Server Error**: Indica que ha ocurrido un error en el servidor y no se pudo procesar la solicitud HTTP.

Estos son solo algunos de los códigos de estado HTTP más comunes, pero hay muchos otros. Al trabajar con APIs REST, es importante comprender los códigos de estado HTTP y cómo utilizarlos para determinar el resultado de las solicitudes HTTP y tomar las acciones apropiadas en consecuencia.

## Clase 5 - Creando tu primera API con .NET

Comando en la CLI para mostrar todos los tipos de proyectos que se pueden crear:

```bash
dotnet new --list
```

Comando en la CLI para crear un proyecto webapi:

```bash
dotnet new webapi
```

## Clase 6 - ¿Consumiendo API desde Postman?

Comando en la CLI para ejecutar el proyecto webapi:

```bash
dotnet run
```

Al abrir Postman se utiliza la URL para consumir los datos de demostración que tiene el proyecto:

`http://localhost:5254/WeatherForecast`
