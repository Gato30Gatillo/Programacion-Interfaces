package es.iesjandula.ReaktorIssuesServer.repository;

import java.util.List;

import org.springframework.data.jpa.repository.JpaRepository;
import org.springframework.data.jpa.repository.Query;
import org.springframework.data.repository.query.Param;

import es.iesjandula.ReaktorIssuesServer.models.IncidenciaTic;

/**
 * interfaz que proporciona metodos para interracccionar con la base de datos
 */
public interface IncidenciaRepository extends JpaRepository<IncidenciaTic, Integer>{

	@Query("SELECT new es.iesjandula.ReaktorIssuesServer.dto.IncidenciaDTO("
			+ "e.numeroAula, e.correoDocente, e.fechaIncidencia, e.descripcionIncidencia, e.estadoIncidencia, e.comentario"
			+ ") " + "FROM IncidenciaEntity e WHERE ( :numeroAula IS NULL OR e.numeroAula = :numeroAula ) AND "
			+ "( :correoDocente IS NULL OR e.correoDocente = :correoDocente ) AND "
			+ "( (:fecha IS NULL) OR e.fechaActual = :fecha ) AND "
			+ "( :descripcionIncidencia IS NULL OR e.descripcionIncidencia LIKE CONCAT('%', :descripcionIncidencia, '%') ) ")
	public static List<IncidenciaTic> buscaIncidencia(  
			@Param("numeroAula") String numeroAula, 
			@Param("correoDocente")String correoDocente, 
			@Param("fecha")String fecha, 
			@Param("descripcionIncidencia")String descripcionIncidencia) {
		// TODO Auto-generated method stub
		return null;
	}
	
	
}
