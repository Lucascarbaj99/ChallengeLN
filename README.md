# ChallengeLN

Este proyecto es una api en .net core 6 que tiene la funcionalidad de:
- Buscar por id
- Crear un contacto nuevo (todo lo que no se complete de los campos, excepturando el id, será una cadena vacía seteada en la creación de la db)
- Modificar un contacto
- Eliminar un contacto por id (revisando la autenticación, que en el codigo fue seteada que sea "lucas")

-También en otro controller se implementó buscar por parametro
que en caso de que sea un numero, se infiere que es el telefono, sino estimo que es un domicilio compuesto por numeros y letras.

Para ejecutar el proyecto se debe:
- Crear una db llamada ChallengeLN
- Correr el script de creación de base de datos de domicilio y de contacto que se encuentra en la raiz del repo

