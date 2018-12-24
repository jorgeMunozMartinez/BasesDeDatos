# BasesDeDatos
El  sistema  a  desarrollar  consiste  en  un  sencillo  generador  automático  de 
Curricula Vitarum. 
La base de datos a gestionar (que se adjunta a esta especificación) contendrá una serie 
de  tablas  para  almacenar  información  personal  sobre  investigadores,  artículos, 
conferencias, etc. 
  Cada investigador, publica habitualmente los resultados de su investigación en 
una serie de conferencias. Dichos artículos pueden escribirse en solitario o en compañía 
de  otros  autores.  A  su  vez,  los  investigadores  pueden  asistir  a  dichas  conferencias, 
independientemente  de  que  vayan  a  publicar  un  trabajo  en  ellas  o  no.  Toda  esta 
información también debe almacenarse en la base de datos. 
A  continuación,  se  detalla  gráficamente  el  esquema  relacional  de  la  base  de 
datos a utilizar: 
Figura 1. Esquema relacional de la base de datos 
Los nombres tanto de las tablas como de los atributos son suficientemente auto‐
explicativos, por lo que no se detalla el contenido de los mismos. Si aún así, existiera 
alguna duda, se os invita a que la comentéis con el profesor responsable del grupo de 
laboratorio a la mayor brevedad posible. 
Otras restricciones a tener en cuenta: 
 Ningún campo de ninguna tabla admite valores nulos.
 Un mismo artículo puede estar escrito por varios
autores. El atributo orden indica en qué orden debe
listarse un determinado autor al referenciar ese
artículo.
 En CONFERENCIAS, la fecha de inicio siempre será menor
o igual que la fecha de finalización.
Una vez comprendido el sistema, la lista de funcionalidades del mismo es: 
 El  sistema  deberá  permitir  seleccionar  el  fichero  con  la  base  de  datos  que 
contendrá  la  información  con  la  que  se  va  a  trabajar.  Junto  con  esta 
especificación se encuentra un fichero de MS‐Access® que puede utilizarse para 
tal fin. 
 El  sistema  deberá  permitir  la  gestión  (inserción,  modificación  y  borrado  de 
registros), a través de los formularios correspondientes, de todas las tablas de la 
base de datos que así lo requieran.  
 El sistema debe permitir la generación automática del Curriculum Vitae (CV) de 
un investigador. Dicho CV se estructurará de la siguiente manera: 
o Datos personales. 
o Relación de conferencias a las que ha asistido. 
o Relación de artículos que ha publicado, según el formato: 
Lista_de_autores. Título. Conferencia (Siglas). pp.
pag_inicio-pag_fin. Lugar de celebración. Año de
celebración.
Ejemplo: G. Rosado, David, Cruz-Lemus, José A. y Genero,
Marcela. Proyecto CV-BD: Construcción de una aplicación para
gestión de CV en la asignatura de Bases de Datos. XXV
Jornadas de Enseñanza Universitaria de la Informática (JENUI
2017). pp. 177-185. Cáceres (España). 2017. 
Consideraciones adicionales: 
 Las decisiones de diseño adicionales que haya que tomar para el desarrollo de la 
aplicación serán responsabilidad de cada equipo de desarrollo. Cualquier duda 
que pudiera surgir sobre dichas decisiones durante la corrección de la aplicación, 
deberá  ser  convenientemente  justificada  ante  el  profesor  de  prácticas  de 
laboratorio en el momento de la evaluación de la práctica. 
 En el momento de la entrega, cada una de las tablas de la base de datos debe 
contar con un mínimo de 5 registros. 
La elección del lenguaje de desarrollo y del SGBD para gestionar la base de datos 
es libre, si bien se recomienda que se utilicen VB.NET y MS‐Access, pues serán 
los que se comenten en las clases de laboratorio. 
 El  sistema  se  deberá  desarrollar  utilizando  una  arquitectura  en  3  capas 
(presentación,  dominio  y  persistencia),  siguiendo  los  principios  comúnmente 
utilizados en la Ingeniería del Software. Se valorará especialmente la utilización 
de patrones de diseño (p.ej. patrón agente de bases de datos). 
 Cualquier  modificación  realizada  sobre  el  esquema  propuesto  deberá  ser 
convenientemente justificada y consensuada con el profesor de laboratorio. 
