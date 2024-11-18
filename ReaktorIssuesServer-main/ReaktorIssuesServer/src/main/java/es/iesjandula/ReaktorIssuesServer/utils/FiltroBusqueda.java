package es.iesjandula.ReaktorIssuesServer.utils;

import lombok.AllArgsConstructor;
import lombok.Data;
import lombok.NoArgsConstructor;

/**
 * Clase que representa un filtro de búsqueda para incidencias.
 * 
 * <p>
 * Esta clase se utiliza para encapsular los criterios de búsqueda que se
 * pueden aplicar al consultar incidencias en el sistema. Permite especificar
 * distintos parámetros que se pueden usar para filtrar los resultados de la
 * búsqueda.
 * </p>
 */
@AllArgsConstructor
@NoArgsConstructor
@Data
public class FiltroBusqueda {


    private String numeroAula;

    private String correoDocente;

    private String fecha;

    private String descripcionIncidencia;

}
