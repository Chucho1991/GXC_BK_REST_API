# GXC_BK_REST_API

## DESARROLLADO POR: Jesús Guerra Cedeño

## IMPORTANTE:

## CONSIDERACIONES PARA CORRER EL PROYECTO LOCALMENTE:

## BASE DE DATOS
1. DESCARGAR LOS FUENTES
2. EN LA CARPETA BDD SE ENCUENTRA EL ARCHIVO Esquema_LIBROS.sql (https://github.com/Chucho1991/GXC_BK_REST_API/blob/master/BDD/Esquema_LIBROS.sql) QUE DEBE SER DESPLEGADO DESDE UN SERVIDOR DE BASE DE DATOS SQL SERVER CON UNA BASE DE DATOS LLAMADA GXC

## PUBLICAR API REST EN IIS
1. DESDE UN SERVIDOR INTERNET INFORMATION SERVICES DESPLEGAR LOS FUENTES REFERENTES A LOS FUENTES PUBLICADOS UBICADOS EN LA CARPETA PUBLICADO EN EL ARCHIVO COMPRIMIDO LibrosAPI.rar (https://github.com/Chucho1991/GXC_BK_REST_API/blob/master/PUBLICADO/LibrosAPI.rar)
EN LA CARPETA CONFIGURADA PARA ESE FIN (POR DEFECTO ES 'C:\inetpub\wwwroot')
2. UNA VEZ EN LA CARPETA DESPLEGADA MODIFICAR EL ARCHVIO {DIRECTORIO-DESPLIEGUE-IIS}\LibrosAPI\appsettings.json EN LA LINEA 3 CON EL STRING DE CONEXIÓN DE BASE DE DATOS 
`"GXCContext": "Server=localhost;Database=GXC;User ID=SAADMIN;Password=SAADMIN"`
3. ES POSIBLE QUE EL EL API NO RESPONDA CORRECTAMENTE POR LO QUE ES NECESARIO INSTALAR EL SIGUIENTE COMPLEMENTO AL SERVIDOR: https://dotnet.microsoft.com/download/dotnet-core/thank-you/runtime-aspnetcore-3.1.8-windows-hosting-bundle-installer

## EJECUTAR DESDE PROYECTO DE VISUAL ESTUDIO
1. DESDE VISUAL STUDIO ABRIR EL PROYECTO APUNTANDO AL ARCHIVO GXC_API.sln (https://github.com/Chucho1991/GXC_BK_REST_API/blob/master/GXC_API.sln)
2. ES NECESARIO TENER INSTALADO LOS SIGUIENTES COMPLEMENTOS DE VISUAL STUDIO DESDE EL ADMINISTRADOR DE PAQUETES NUGET:
  - AutoMapper
  - Microsoft.AspNetCore.Cors
  - Microsoft.AspNetCore.Mvc.Cors
  - Microsoft.EntityFrameworkCore.Desing
  - Microsoft.EntityFrameworkCore.Sqllite
  - Microsoft.EntityFrameworkCore.SqlServer
  - Microsoft.EntityFrameworkCore.SqlServer.Desing
  - Microsoft.EntityFrameworkCore.Tools
  - Microsoft.VisualStudio.Web.CodeGeneration.Desing
 3. COMPILAR SOLUCIÓN
 4. EJECUTAR DESDE IIS Express
  
